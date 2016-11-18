USE AuctionNet
GO

----Fråga 1
----Registrera en produkt.

--CREATE PROCEDURE AddProduct
--@ProductName NVARCHAR(50),
--@Description NVARCHAR(200),
--@StartPrice DECIMAL,
--@Commission DECIMAL(5,2),
--@SupplierId INT
--AS
--BEGIN TRY
--INSERT INTO Products(ProductName,Description,StartPrice,Commission,SupplierId)
--VALUES(@ProductName,@Description,@StartPrice,@Commission,@SupplierId)
--END TRY
--BEGIN CATCH
--Print 'NEJ'
--END CATCH

--EXEC AddProduct 'Gammal väska','Röd läderväska från Michael Kors',4500,0.12,1


----Fråga 2
----Skapa en auktion utifrån en viss produkt där man kan sätta utgångspris,
----acceptpris samt start och slutdatum för auktionen.

--CREATE PROCEDURE AddAuction
--@AcceptPrice DECIMAL(18,0),
--@StartPrice DECIMAL,
--@StartDate DATETIME,
--@EndTime DATETIME,
--@ProductId INT
--AS
--BEGIN TRY
--UPDATE Products
--SET StartPrice= @StartPrice
--WHERE Id = @ProductId
--INSERT INTO Auctions(AcceptPrice, StartTime, EndTime, ProductId)
--VALUES (@AcceptPrice, @StartDate, @EndTime, @ProductId)
--END TRY
--BEGIN CATCH
--PRINT 'NEJ PÅ HELEVETE'
--END CATCH

--EXEC AddAuction 15000, 10000, '2016.11.12','2016.11.13', 4
--SELECT * FROM Auctions


----Fråga 3
----Lista pågående auk-oner samt kunna se det högsta budet och vilken kund
----som lagt det.

--CREATE VIEW MaxBid
--AS
--Select Auctions.Id, Products.ProductName, Max(Bid) AS MaxBid, 
--Auctions.EndTime FROM Bids 
--INNER JOIN Auctions ON Bids.AuctionId = Auctions.Id
--INNER JOIN Products ON Products.Id = Auctions.ProductId
--Group by Auctions.Id, Products.ProductName, 
--Auctions.EndTime;

--Select MaxBid.Id , MaxBid.MaxBid, MaxBid.EndTime, Customers.Name, Customers.Id from MaxBid
--inner join bids on bids.AuctionId= MaxBid.Id
--inner join customers on Customers.Id = bids.CustomerId
--Group by MaxBid.Id , MaxBid.MaxBid, MaxBid.EndTime, Customers.Name, Customers.Id
--having (Max(Bids.bid) = MaxBid.MaxBid)


----Fråga 4
----Se budhistoriken på en viss auk-on, samt vilka kunder som lagt buden.

--CREATE PROCEDURE ViewBids (@AuctionId INT)
--AS
--BEGIN TRY
--DECLARE @test INT
--SET @test = (select Count(Id) FROM Auctions);

--Select top (@test)  Auctions.AcceptPrice, Bids.Date, CustomerId, Bid FROM Auctions
--INNER JOIN Bids ON Auctions.Id = Bids.AuctionId
--INNER JOIN Products ON Products.Id = Auctions.ProductId
--WHERE Auctions.Id = @AuctionId ORDER BY Bid;
--END TRY
--BEGIN CATCH
--PRINT 'Kunde inte hitta några bud'
--END CATCH

--EXEC ViewBids 1


----Fråga 5
----Vilka auktioner avslutas under ett visst datumintervall? Samt vad blir
----provisionen för varje auk-on inom det intervallet? 

--CREATE PROCEDURE ViewCommission(@Fromdate Datetime, @ToDate DateTime)
--AS
--BEGIN TRY
--Select Products.ProductName, Max(Bid) AS MaxBid, Products.Commission, 
--Auctions.EndTime, (Products.Commission*Max(Bid)) AS CountCommission FROM Bids 
--INNER JOIN Auctions ON Bids.AuctionId = Auctions.Id
--INNER JOIN Products ON Products.Id = Auctions.ProductId
--WHERE Auctions.EndTime BETWEEN @Fromdate AND @ToDate
--GROUP BY Products.ProductName, Bids.AuctionId, Products.Commission, Auctions.EndTime
--END TRY
--BEGIN CATCH
--Print 'Detta gick inte'
--END CATCH

--EXEC ViewCommission '2016.05.12','2016.11.26'


----Fråga 8
----Visa en kundlista på alla kunder som köpt något, samt vad deras totala ordervärde är.

--CREATE VIEW CustomerTotalOrderValue
--AS
--SELECT  CustomerName, Sum(EndPrice) as TotalOrderValue
--FROM AuctionHistory 
--GROUP BY CustomerName


----Fråga 9
----Vad den totala provisionen är per månad.

--CREATE VIEW CommissionMonth
--AS
--SELECT FORMAT(EndDate,'yyyy,MM') AS YearMonth , Sum(EndPrice*Commission) AS TotalCommision
--FROM AuctionHistory
--GROUP BY EndDate


----Trigger

--CREATE TRIGGER trgBidInsert ON Bids
--FOR INSERT
--AS
-- DECLARE @bid DECIMAL
-- DECLARE @CustomerID INT
-- DECLARE @bidid INT
-- DECLARE @productID INT
-- DECLARE @AuctionId INT
-- DECLARE @AcceptPrice INT

-- SELECT @bid = d.bid FROM INSERTED d
-- SELECT @CustomerID = d.CustomerId FROM inserted d
-- SELECT @AuctionId = d.AuctionId FROM inserted d
-- SELECT @productID = (SELECT ProductId from Auctions WHERE Id = @AuctionId)
-- SELECT @AcceptPrice = (SELECT AcceptPrice FROM Auctions WHERE Id = @AuctionId)
-- IF(@bid >= @AcceptPrice)
-- BEGIN
-- UPDATE Auctions
-- SET EndTime = GETDATE()
-- WHERE id = @AuctionId
-- END