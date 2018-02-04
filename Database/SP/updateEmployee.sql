ALTER PROC updateEmployee
( @EmployeeID INT, 
@EmployeeName	NVARCHAR(40),
@IsActive	bit ,
@IDNumber	VARCHAR(40),
@Gender	BIT,
@Email	VARCHAR(100),
@Phone	VARCHAR(40),
@Address	NVARCHAR(200),
@EntryDate	DATE,
@DepartmentName NVARCHAR(40),
@BirthDay	DATE,
@Position	NVARCHAR(40),
@EducationLevel NVARCHAR (40) 
)


 AS 
  
 BEGIN TRY	

 DECLARE @DepartmentID INT 
 DECLARE @EducationLevelID INT 

 SELECT @DepartmentID= DepartmentID 
 FROM dbo.Department WHERE DepartmentName = @DepartmentName

  SELECT @EducationLevelID = EducationLevelID
 FROM dbo.EducationLevel WHERE EducationLevel = @EducationLevel


 UPDATE dbo.Employee 
 SET  EmployeeName = @EmployeeName,
          IsActive              = @IsActive,
          IDNumber         = @IDNumber,
          Gender              = @Gender,
          Email					 = @Email,
          Phone				 = @Phone,
          Address			 = @Address,
          EntryDate			 = @EntryDate,
          ChangeDate		 = GETDATE(),
          DepartmentID  = @DepartmentID,
          BirthDay			 = @BirthDay,
          Position			 = @Position,
		  EducationLevelID = @EducationLevelID
WHERE	EmployeeID = @EmployeeID


END TRY 
BEGIN CATCH
THROW
END CATCH