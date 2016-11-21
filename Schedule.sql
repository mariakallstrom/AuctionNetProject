USE [msdb]
GO

BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
IF NOT EXISTS (SELECT name FROM msdb.dbo.syscategories WHERE name=N'[Uncategorized (Local)]' AND category_class=1)
BEGIN
EXEC @ReturnCode = msdb.dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'[Uncategorized (Local)]'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

END

DECLARE @jobId BINARY(16)
EXEC @ReturnCode =  msdb.dbo.sp_add_job @job_name=N'CheckEndedAuctions', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=0, 
		@notify_level_netsend=0, 
		@notify_level_page=0, 
		@delete_level=0, 
		@description=N'Checks auctions that has ended', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'DESKTOP-6MRRPSL\Carl-Fredrik', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'Check Auction End', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=3, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'DECLARE @Ended INT
SELECT @Ended = COUNT(id) FROM(
SELECT dbo.Auctions.Endtime, dbo.Auctions.Id, dbo.Bids.bid
FROM dbo.Auctions
LEFT JOIN dbo.Bids ON dbo.Bids.AuctionId = dbo.Auctions.Id
WHERE GETDATE() > EndTime)a
IF @Ended < 1
BEGIN
	RAISERROR(''Gå inte vidare.'',11,1);
END', 
		@database_name=N'AuctionNet', 
		@output_file_name=N'C:\error.txt', 
		@flags=2
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'History or mail', 
		@step_id=2, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'DECLARE @EndedAuction INT
DECLARE @ProductId INT
DECLARE @ProductName NVARCHAR(50)
DECLARE @SupplierId INT
DECLARE @SupplierName NVARCHAR(50)
DECLARE @StartPrice DECIMAL
DECLARE @EndPrice DECIMAL
DECLARE @CustomerId INT
DECLARE @CustomerName NVARCHAR(50)
DECLARE @StartDate DATETIME
DECLARE @EndDate DATETIME
DECLARE @Commission DECIMAL(5,2)



SELECT @EndedAuction = Id FROM(
SELECT TOP(1) * FROM
(SELECT * FROM Auctions WHERE GETDATE() > Auctions.EndTime)A)A
IF @EndedAuction IS NULL
BEGIN
	RAISERROR(''Inga auktioner har tagit slut'',11,1)
END
ELSE
	BEGIN
		IF (SELECT COUNT(id) FROM Bids WHERE Bids.AuctionId = @EndedAuction) > 0
			BEGIN
				SET @ProductId = (SELECT ProductId FROM Auctions WHERE Auctions.Id = @EndedAuction)
				SET @ProductName = (SELECT ProductName FROM Products WHERE Id = @ProductId)
				SET @SupplierId = (SELECT SupplierId FROM Products WHERE Id = @ProductId)
				SET @SupplierName = (SELECT name FROM Suppliers WHERE id = @SupplierId)
				SET @StartPrice = (SELECT StartPrice FROM Products WHERE Id = @ProductId)
				SET @EndPrice = (SELECT MAX(bid) FROM Bids WHERE Bids.AuctionId = @EndedAuction)
				SET @CustomerId = (SELECT CustomerId FROM (SELECT TOP 1 * FROM(SELECT MAX(bid) AS [Max Bid], CustomerId FROM Bids
								   WHERE Bids.AuctionId = @EndedAuction GROUP BY CustomerId)a)a)
				SET @CustomerName = (SELECT Name FROM Customers WHERE id = @CustomerId)
				SET @StartDate = (SELECT StartTime FROM Auctions WHERE Id = @EndedAuction)
				SET @EndDate = (SELECT EndTime FROM Auctions WHERE Id = @EndedAuction)
				SET @Commission = (SELECT Commission FROM Products WHERE Id = @ProductId)


				INSERT INTO AuctionHistory(AuctionNumber,ProductName,SuplierName,StartPrice,EndPrice,CustomerName,StartDate,EndDate,Commission)
				VALUES (@EndedAuction,@ProductName,@SupplierName,@StartPrice,@EndPrice,@CustomerName,@StartDate,@EndDate,@Commission)
				DELETE FROM Auctions WHERE Id = @EndedAuction
			 END
	    ELSE
			BEGIN
			SET @ProductId = (SELECT ProductId FROM Auctions WHERE Auctions.Id = @EndedAuction)
			SET @ProductName = (SELECT ProductName FROM Products WHERE Id = @ProductId)
			SET @SupplierId = (SELECT SupplierId FROM Products WHERE Id = @ProductId)
			SET @SupplierName = (SELECT name FROM Suppliers WHERE id = @SupplierId)

			DECLARE @rBody NVARCHAR(300) = (@ProductName + '' från '' + @SupplierName + '' fick aldrig några bud. Auktionen avslutades.'')
			DECLARE @rSubject NVARCHAR(300) = (''Auctionnet meddelande angående auktion'' + convert(nvarchar(10), @EndedAuction))

			EXEC msdb.dbo.sp_send_dbmail  
			@profile_name = ''AuctionNetMail'',  
			@recipients = ''kallstrom.maria@gmail.com'',  
			@body = @rBody,  
			@subject = @rSubject;  

			DELETE FROM Auctions WHERE Id = @EndedAuction

			END
				
END', 
		@database_name=N'AuctionNet', 
		@flags=0
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id=@jobId, @name=N'Schedule', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=1, 
		@freq_subday_type=4, 
		@freq_subday_interval=1, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=0, 
		@active_start_date=20161116, 
		@active_end_date=99991231, 
		@active_start_time=0, 
		@active_end_time=235959, 
		@schedule_uid=N'98414497-bc58-4000-a4a4-52372304caf8'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:
