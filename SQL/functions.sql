Use Techlabs
GO

CREATE function GetSalaryTop3()
RETURNS @SALARY3 TABLE
(
[EMPID] int,
[EMPNAME] varchar,
[SAL] int,
[COMM] int,
[CTC] int
)
AS
BEGIN
Insert into @SALARY3
	SELECT EMPNO, ENAME, SAL, COMM, (SAL* 12) + (ISNULL(COMM, 0 ) *12) AS CTC 
	FROM EMP
RETURN
END
GO

