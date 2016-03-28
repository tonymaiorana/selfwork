--Relations and Joins Labs using SWCCorp
SELECT * FROM EmployeeTerritories

SELECT * FROM Employees

SELECT e.EmployeeID, FirstName,LastName,et.TerritoryID,t.TerritoryDescription FROM Employees e
	INNER JOIN EmployeeTerritories et
	on e.EmployeeID = et.EmployeeID
	INNER JOIN Territories t
	ON et.TerritoryID = t.TerritoryID

--Relations and Joins Labs using Northwind
SELECT * FROM [Order Details]
SELECT * FROM Orders


--Can't Believe I figured this out!
SELECT CompanyName, o.OrderDate, od.* 
FROM Customers c
INNER JOIN Orders o
ON c.CustomerID = o.CustomerID
INNER JOIN [Order Details] od
ON o.OrderID = od.OrderID
INNER JOIN Products p
ON p.ProductID = od.ProductID
where ShipCountry = 'USA'

SELECT p.ProductName, o.* FROM Products p
INNER JOIN [Order Details] od
ON p.ProductID = od.ProductID
INNER JOIN Orders o
ON o.OrderID = od.OrderID
where ProductName = 'Chai'

