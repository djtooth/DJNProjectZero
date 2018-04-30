Create Database CodingChallange2;
Go 
Create Schema CodingChallange2;
Go
Create Table CodingChallange2.Products(
ProductID int Not Null Identity(1,1) Constraint Product Primary Key Clustered(ProductID),
ProductName NVARCHAR Not Null,
Price Money Not Null);

Create Table CodingChallange2.Customers(
CustomerID int Not Null Identity(1,1) Constraint Customers Primary Key Clustered(CustomerID),
FirstName NVarChar Not Null,
LastName NVarChar Not NUll,
CardNumber int Not Null);

Create Table CodingChallange2.Orders(
OrderID int Not Null Identity(1,1) Constraint Orders Primary Key Clustered(OrderID),
ProductID int Not Null,
CustomerID int Not Null
Constraint Products Foreign Key(OrderID) References CodingChallange2.Customers(CustomerID),
Constraint Products Foreign Key(OrderID) References CodingChallange2.Products(ProductID)
 );

 Insert Into CodingChallange2.Products Values (1, Iphone, 200);
 Insert Into CodingChallange2.Products Values (2, WindowsPhone, 50);
 Insert Into CodingChallange2.Products Values (3, AndriodPhone, 100);

 Insert Into CodingChallange2.Customer Values (1, Tina, Smith, 123456);
 Insert Into CodingChallange2.Customer Values (2, Tom, Smith, 123455);
 Insert Into CodingChallange2.Customer Values (3, Tony, Smiteingson, 123454);

 Insert Into CodingChallange2.Orders Values (1, 1, 1);
 Insert Into CodingChallange2.Orders Values (2, 2, 2);
 Insert Into CodingChallange2.Orders Values (3, 3, 3);
 go

 Select OrderID from CodingChallange2.Orders, CodingChallange2.Customers where FirstName = 'Tina' And LastName = Smith;
Select Sum(price) from CodingChallange2.Orders, CodingChallange2.Products where ProductName = 'Iphone';

update CodingChallange2.Products Set Price = 250 where ProductName = 'Iphone';