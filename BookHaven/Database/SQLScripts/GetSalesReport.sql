SELECT SaleDate, TotalAmount, CustomerName, BookTitle
FROM Sales
INNER JOIN Books ON Sales.BookID = Books.BookID
ORDER BY SaleDate DESC;
