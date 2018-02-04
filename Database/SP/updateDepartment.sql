CREATE PROC updateDepartment
(@DepartmentID INT ,
 @DepartmentName NVARCHAR(40)
)
 AS 
  
 BEGIN TRY	

UPDATE dbo.Department
 SET DepartmentName = @DepartmentName
  WHERE DepartmentID = @DepartmentID  
 


END TRY 
BEGIN CATCH
THROW
END CATCH