USE AdventureWorks2014;
Select * From Person.Address
USE AdventureWorks2014
GO

/* Create the Proc */
Create Proc dbo.uspGetAddress
AS
Select * From Person.Address
GO

/* Exec the Proc */
EXEC dbo.uspGetAddress

/* Use Drop proc to remove the proc */
Drop proc dbo.uspGetAddress

/* Create Proc with a parameter */
USE AdventureWorks2014
GO
Create Proc dbo.uspGetAddressCity @City nvarchar(30) = NULL, @AddressLine1 nvarchar(60) = NULL
AS
Select *
From Person.Address 
Where City = ISNULL(@City,City)
AND AddressLine1 LIKE '%' + ISNULL(@AddressLine1,AddressLine1) + '%'
GO

/* Call Proc and pass in parameter */
Exec dbo.uspGetAddressCity @City = 'New York'
--or
Exec dbo.uspGetAddressCity @City = 'New York', @AddressLine1 = 'U'
--or
Exec dbo.uspGetAddressCity @AddressLine1 = 'Union Square'

/* Create Proc with Two JOINs and Two parameters */
USE AdventureWorks2014
GO
Create Proc dbo.uspGetAddressCity2 @City nvarchar(30) = NULL, @AddressLine1 nvarchar(60) = NULL
AS
Select
	C.City,
	C.PostalCode,
	C.ModifiedDate,
	D.CardType,
	E.ListPrice
From 
	Person.Address AS C
	INNER JOIN Sales.CreditCard AS D
	ON C.ModifiedDate = D.ModifiedDate
	INNER JOIN Production.Product AS E
	ON E.ModifiedDate = C.ModifiedDate
	
Where City = ISNULL(@City,City)
AND AddressLine1 LIKE '%' + ISNULL(@AddressLine1,AddressLine1) + '%'
GO

Exec dbo.uspGetAddressCity2 @City = 'New York'