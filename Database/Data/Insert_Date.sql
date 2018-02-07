INSERT INTO dbo.Department
        ( DepartmentName )
VALUES  ( N'人力资源部'  -- DepartmentName - nvarchar(40)
          ),
		  (N'财务部'), (N'销售部'), (N'运输部'), (N'后勤部'), 
		  (N'采购部')

SELECT *FROM  dbo.Department


SELECT * FROM dbo.EducationLevel 
INSERT INTO dbo.EducationLevel
        ( EducationLevel )
VALUES  ( N'小学'  ), ( N'初中'  ),( N'高中'  ),( N'本科'  ),( N'专科'  ),( N'研究生'  ),( N'博士'  ) 

SELECT * FROM dbo.EducationLevel WHERE EducationLevel = '小学'


EXEC dbo.addEmployee @EmployeeName = N'22', -- nvarchar(40)
    @IsActive = 1, -- bit
    @IDNumber = '22', -- varchar(40)
    @Gender = 1, -- bit
    @Email = '22', -- varchar(100)
    @Phone = '22', -- varchar(40)
    @Address = N'22', -- nvarchar(200)
    @EntryDate = '2018-01-28 15:12:43', -- date
    @DepartmentName = N'财务部', -- nvarchar(40)
    @BirthDay = '2018-01-28 15:12:43', -- date
    @Position = N'订单', -- nvarchar(40)
    @EducationLevel = N'小学' -- nvarchar(40)




	SELECT e.EmployeeID ,   e.EmployeeName ,  CASE	WHEN	IsActive = 1 THEN '在职' ELSE'离职'END IsActive,           e.IDNumber ,          CASE	 WHEN e.Gender = 0 THEN '男' ELSE '女'END Gender ,          e.Email ,           e.Phone ,           e.Address ,           e.EntryDate ,           e.ChangeDate ,           d.DepartmentName,           e.BirthDay ,          
	 e.Position ,           el.EducationLevel 	FROM dbo.Employee e JOIN dbo.Department d ON	d.DepartmentID = e.DepartmentID
		JOIN dbo.EducationLevel el ON el.EducationLevelID = e.EducationLevelID
		WHERE Position LIKE '%经理%'


		"SELECT e.EmployeeID ,e.EmployeeName ,CASE WHEN IsActive = 1 THEN '在职' ELSE'离职'END IsActive, e.IDNumber ,   CASE  WHEN e.Gender = 0 THEN '男' ELSE '女'END Gender  ,  e.Email ,e.Phone ,e.Address , e.EntryDate , e.ChangeDate , d.DepartmentName,e.BirthDay ,"

UPDATE dbo.Employee SET Gender = 1

DELETE dbo.Employee WHERE EmployeeID >15

SELECT MaterialID ,
       MaterialName FROM dbo.Material

INSERT INTO dbo.Vendor
        ( VendorID, VendorName )
VALUES  ( 2, -- VendorID - int
          N'英特尔'  -- VendorName - nvarchar(50)
          )

		  INSERT INTO dbo.Material
		          ( MaterialID, MaterialName )
		  VALUES  ( 2, -- MaterialID - int
		            N'CPU'  -- MaterialName - nvarchar(50)
		            )