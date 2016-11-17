USE AuctionNet
GO
DELETE FROM AuctionHistory
DELETE FROM Products
DELETE FROM Customers
DELETE FROM Suppliers
DELETE FROM Auctions
DELETE FROM Bids

GO
INSERT INTO Customers(Name,Email,Phone)
VALUES ('Kalle Anka', 'Kalle@Anka.se','0701234567')

INSERT INTO Customers(Name,Email,Phone)
VALUES ('Janne Långben','janne@langman.se','0899997778');

INSERT INTO Customers(Name,Email,Phone)
VALUES ('Mikael Mus','Musse@mus.se','123456789');

INSERT INTO Customers(Name,Email,Phone)
VALUES ('Joakim Von Anka','Jocke@Anka.com','987654321');

INSERT INTO Customers(Name,Email,Phone)
VALUES ('Donald Trump','Donald@trumpen.com','6666666666');

INSERT INTO Suppliers(Name,Phone)
VALUES ('Ikea','085557778')

INSERT INTO Suppliers(Name,Phone)
VALUES ('Mio','09012777222')

INSERT INTO Suppliers(Name,Phone)
VALUES ('BR','123987456')

INSERT INTO Suppliers(Name,Phone)
VALUES ('Coop','01074510000')

INSERT INTO Products(ProductName,Description,StartPrice,Commission,SupplierId)
VALUES ('Vas','Mingvas med blå buddor',5000,0.15,1);

INSERT INTO Products(ProductName,Description,StartPrice,Commission,SupplierId)
VALUES ('Vas','Mingvas med gröna buddor',5000,0.15,2);

INSERT INTO Products(ProductName,Description,StartPrice,Commission,SupplierId)
VALUES ('Snöslunga','Antik snöslunga i trä med handvev',500,0.20,4);

INSERT INTO Products(ProductName,Description,StartPrice,Commission,SupplierId)
VALUES ('Utegym','Metall och trä gym',40000,0.40,3);

INSERT INTO Products(ProductName,Description,StartPrice,Commission,SupplierId)
VALUES ('Luftgitarr','Luftgitarr med plektrum',30,0.05,3);

INSERT INTO Products(ProductName,Description,StartPrice,Commission,SupplierId)
VALUES ('Ögonmått','med Error 40',400,0.15,4);

INSERT INTO Products(ProductName,Description,StartPrice,Commission,SupplierId)
VALUES ('Gamla mynt','Från 2007',100,0.05,2);

INSERT INTO Auctions(AcceptPrice, StartTime,EndTime,ProductId)
VALUES (6000, GETDATE(),'2016-11-16 12:00:00.000',1) 

INSERT INTO Auctions(AcceptPrice, StartTime,EndTime,ProductId)
VALUES (60000, GETDATE(),'2016-11-16 12:00:00.000',4) 

INSERT INTO Auctions(AcceptPrice, StartTime,EndTime,ProductId)
VALUES (600, GETDATE(),'2016-11-16 12:00:00.000',6) 

INSERT INTO Auctions(AcceptPrice, StartTime,EndTime,ProductId)
VALUES (800,GETDATE(),'2016-10-16 12:00:00.000',3) 

--INSERT INTO Auctions(AcceptPrice, StartTime,EndTime,ProductId)
--VALUES (800,GETDATE(),GETDATE()+10,3) 

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (1,1,5000,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (2,1,8000,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (1,1,10000,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (2,2,400,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (4,2,500,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (2,2,800,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (4,2,900,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (5,3,7000,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (2,3,6000,GETDATE());

INSERT INTO Bids(CustomerId,AuctionId,Bid,Date)
VALUES (1,4,667000,GETDATE());