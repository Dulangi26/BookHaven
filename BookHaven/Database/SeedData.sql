USE BookHavenDB;
GO

-- Users
INSERT INTO Users (Username, Password, Role)
VALUES
('admin', 'Admin@123', 'Admin'),
('salesclerk', 'Clerk@123', 'SalesClerk');

-- Books
INSERT INTO Books (Title, Author, Genre, ISBN, Price, StockQuantity)
VALUES
('The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction', '9780743273565', 1500.00, 10),
('To Kill a Mockingbird', 'Harper Lee', 'Fiction', '9780061120084', 1800.00, 8),
('Clean Code', 'Robert C. Martin', 'Programming', '9780132350884', 4500.00, 5);

-- Customers
INSERT INTO Customers (Name, Contact, Email)
VALUES
('John Silva', '0771234567', 'john@email.com'),
('Nimal Perera', '0719876543', 'nimal@email.com');

-- Sales
INSERT INTO Sales (CustomerID, TotalAmount)
VALUES
(1, 3000.00),
(2, 4500.00);

-- SalesTransactions
INSERT INTO SalesTransactions (CustomerID, TotalAmount, PaymentDetails)
VALUES
(1, 3000.00, 'Cash'),
(2, 4500.00, 'Card');

-- Orders
INSERT INTO Orders (CustomerId, BookId, Quantity, OrderStatus)
VALUES
(1, 1, 2, 'Completed'),
(2, 3, 1, 'Pending');