--Query Strategy Labs
--SELECT *
--	 FROM Employee

--SELECT * 
--	FROM Location

--SELECT *
--	FROM Employee
--	CROSS JOIN Location 

--select * FROM [Grant]

SELECT *
FROM employee e
LEFT JOIN [Grant] g
on e.EmpID = g.EmpID
WHERE g.GrantName IS NULL

