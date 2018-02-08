Use Techlabs;
GO

CREATE PROCEDURE GetSalary
    -- Define parameters here @Salary nvarchar(50),   
	-- Define parameters here @Name nvarchar(50)   
AS
	SELECT ENAME, SAL, COMM, (SAL* 12) + (ISNULL(COMM, 0 ) *12) AS CTC 
	FROM EMP;
GO

EXEC GetSalary
GO