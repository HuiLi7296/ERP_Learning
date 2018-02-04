ALTER PROC addEmployee
(  
@EmployeeName	NVARCHAR(40),
@IsActive	bit ,
@IDNumber	VARCHAR(40),
@Gender	BIT,
@Email	VARCHAR(100),
@Phone	VARCHAR(40),
@Address	NVARCHAR(200),
@EntryDate	DATE,
--@ChangeDate	DATETIME,
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

 INSERT INTO dbo.Employee
        ( EmployeeName ,
          IsActive ,
          IDNumber ,
          Gender ,
          Email ,
          Phone ,
          Address ,
          EntryDate ,
          --ChangeDate ,
          DepartmentID ,
          BirthDay ,
          Position,
		  EducationLevelID
        )
 VALUES ( @EmployeeName ,
          @IsActive ,
          @IDNumber ,
          @Gender ,
          @Email ,
          @Phone ,
          @Address ,
          @EntryDate ,
          --@ChangeDate ,
          @DepartmentID ,
          @BirthDay ,
          @Position,
		  @EducationLevelID
        );






--MERGE dbo.Employee AS tgt 
--USING ( SELECT @EmployeeID, @EmployeeName,@IsActive,@IDNumber,@Gender,@Email,@Phone,@Address,@EntryDate,@ChangeDate,@DepartmentID,@BirthDay,@Position) AS src
--			(EmployeeID,EmployeeName,IsActive,IDNumber,Gender,Email,Phone,Address,EntryDate,ChangeDate,DepartmentID,BirthDay,Position)
--ON tgt.EmployeeID = src.



END TRY 
BEGIN CATCH
THROW
END CATCH