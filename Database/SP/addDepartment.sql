CREATE PROC addDepartment
(@DepartmentName NVARCHAR(40)
)


 AS 
  
 BEGIN TRY	

INSERT INTO dbo.Department
        ( DepartmentName )
VALUES  ( @DepartmentName -- DepartmentName - nvarchar(40)
          )
 


END TRY 
BEGIN CATCH
THROW
END CATCH