CREATE PROCEDURE AddToHistory
@AuctionId INT
AS
BEGIN
    declare @ProductName NVARCHAR(50);
	declare @ProductId INT;
	declare @SupplierName NVARCHAR(50);
	declare @SupplierId INT;
	declare @CustomerName varchar(50);
	declare @StartPrice DECIMAL;
	declare @EndPrice DECIMAL

	If (SELECT COUNT(id) FROM Bids WHERE Bids.AuctionId = @AuctionId) < 1
      Begin
		  PRINT 'Fanns ingen köpare'
          Return
      End

	SET @ProductId = (Select ProductId FROM Auctions WHERE Auctions.Id = @AuctionId)
	SET @ProductName = (Select Products.ProductName from Products WHERE Products.Id = @ProductId)
	SET @SupplierId = (Select products.SupplierId FROM Products WHERE Products.Id = @ProductId)
	SET @SupplierName = (Select Suppliers.Name FROM Suppliers WHERE Suppliers.Id = @SupplierId)
	SET @EndPrice = (Select MAX(bid) FROM Bids WHERE Bids.AuctionId = @AuctionId)
	SET @StartPrice = (Select Products.StartPrice FROM Products WHERE Products.Id = @ProductId)



		insert into AuctionHistory
(AuctionNumber,ProductName,SuplierName,StartPrice,EndPrice,CustomerName) 
	values(@AuctionId,@ProductName,@SupplierName,@StartPrice,@EndPrice,'TOMT');

	PRINT 'Fanns en köpare, lägger till i Historik'
END