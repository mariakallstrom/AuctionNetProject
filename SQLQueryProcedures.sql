USE AuctionNet
GO

--Fr�ga 1
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

--EXEC AddProduct 'Gammal v�ska','R�d l�derv�ska fr�n Michael Kors',4500,0.12,1


--Fr�ga 2
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
--PRINT 'NEJ P� HELEVETE'
--END CATCH

--EXEC AddAuction 15000, 10000, '2016.11.12','2016.11.13', 4
--SELECT * FROM Auctions


----Fr�ga 3
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


--Fr�ga 4
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
--PRINT 'Kunde inte hitta n�gra bud'
--END CATCH

--EXEC ViewBids 1


--Fr�ga 5
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


--Fr�ga 8
--Visa en kundlista p� alla kunder som k�pt n�got, samt vad deras totala orderv�rde �r.

CREATE VIEW CustomerTotalOrderValue
AS
SELECT  CustomerName, Sum(EndPrice) as TotalOrderValue
FROM AuctionHistory 
GROUP BY CustomerName


--Fr�ga 9
--Vad den totala provisionen �r per m�nad.

CREATE VIEW CommisionMonth
AS
SELECT FORMAT(EndDate,'yyyy,MM') AS YearMonth , Sum(EndPrice) AS TotalCommision
FROM AuctionHistory
GROUP BY EndDate




SELECT * FROM AuctionHistory

SELECT * FROM Auctions