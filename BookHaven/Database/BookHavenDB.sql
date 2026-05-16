USE master;
GO

IF DB_ID('BookHavenDB') IS NULL
    CREATE DATABASE BookHavenDB;
GO

USE BookHavenDB;
GO

-- Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

-- Books Table
CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    Genre NVARCHAR(50) NOT NULL,
    ISBN NVARCHAR(20) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    StockQuantity INT NOT NULL
);

-- Customers Table
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Contact NVARCHAR(15) NOT NULL,
    Email NVARCHAR(100) NOT NULL
);

-- Sales Table
CREATE TABLE Sales (
    SaleID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT,
    TotalAmount DECIMAL(10,2) NOT NULL,
    SaleDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- SalesTransactions Table
CREATE TABLE SalesTransactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT,
    TransactionDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2),
    PaymentDetails VARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Orders Table
CREATE TABLE Orders (
    OrderId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT NOT NULL,
    BookId INT NOT NULL,
    Quantity INT NOT NULL,
    OrderStatus VARCHAR(50) NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    FOREIGN KEY (BookId) REFERENCES Books(BookId)
);

--Suppliers Table
CREATE TABLE SaleDetails (
    SaleDetailID INT IDENTITY(1,1) PRIMARY KEY,
    SaleID INT NOT NULL,
    BookID INT NOT NULL,
    Quantity INT NOT NULL,
    TotalPrice DECIMAL(10,2) NOT NULL,

    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
    FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

-- Payments Table

CREATE TABLE Payment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    SaleID INT NOT NULL,
    CustomerID INT NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod NVARCHAR(50),
    Amount DECIMAL(10,2),
    PaymentStatus NVARCHAR(50),

    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);