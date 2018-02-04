ALTER PROC setDepartment
(@DepartmentID INT ,
 @DepartmentName NVARCHAR(40)
)
 AS 
  
 BEGIN TRY	

 IF ISNULL(@DepartmentID,'')=''
 BEGIN	 
 INSERT INTO dbo.Department
         ( DepartmentName )
 VALUES  ( @DepartmentName  -- DepartmentName - nvarchar(40)
           )

SET @DepartmentID = SCOPE_IDENTITY()

END 
ELSE 
BEGIN
UPDATE dbo.Department
 SET DepartmentName = @DepartmentName
  WHERE DepartmentID = @DepartmentID  
 END


 SELECT * FROM dbo.Department WHERE DepartmentID = @DepartmentID 

END TRY 
BEGIN CATCH
THROW
END CATCH

GO 
--EXEC dbo.setDepartment @DepartmentID = NULL , -- int
--    @DepartmentName = N'x²¿' -- nvarchar(40)
