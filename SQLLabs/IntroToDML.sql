Update Employee
	SET LastName = 'Green'
	WHERE EmpID = 11

Update Employee
	SET Status = 'External'
	FROM Employee e
	INNER JOIN Location l
	ON e.LocationID = l.LocationID
	WHERE l.City = 'Spokane'

UPDATE Location
	SET Street = '111 1st Ave.'
	WHERE Location.City = 'Seattle'

UPDATE [Grant]
	SET Amount = 20000
	From [Grant] g
	INNER JOIN Employee e
	ON g.EmpID = e.EmpID
	INNER JOIN Location l
	ON e.LocationID = l.LocationID
	where l.City = 'Boston'