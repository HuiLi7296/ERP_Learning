INSERT INTO dbo.Department
        ( DepartmentName )
VALUES  ( N'������Դ��'  -- DepartmentName - nvarchar(40)
          ),
		  (N'����'), (N'���۲�'), (N'���䲿'), (N'���ڲ�'), 
		  (N'�ɹ���')

SELECT *FROM  dbo.Department


SELECT * FROM dbo.EducationLevel 
INSERT INTO dbo.EducationLevel
        ( EducationLevel )
VALUES  ( N'Сѧ'  ), ( N'����'  ),( N'����'  ),( N'����'  ),( N'ר��'  ),( N'�о���'  ),( N'��ʿ'  ) 

SELECT * FROM dbo.EducationLevel WHERE EducationLevel = 'Сѧ'


EXEC dbo.addEmployee @EmployeeName = N'22', -- nvarchar(40)
    @IsActive = 1, -- bit
    @IDNumber = '22', -- varchar(40)
    @Gender = 1, -- bit
    @Email = '22', -- varchar(100)
    @Phone = '22', -- varchar(40)
    @Address = N'22', -- nvarchar(200)
    @EntryDate = '2018-01-28 15:12:43', -- date
    @DepartmentName = N'����', -- nvarchar(40)
    @BirthDay = '2018-01-28 15:12:43', -- date
    @Position = N'����', -- nvarchar(40)
    @EducationLevel = N'Сѧ' -- nvarchar(40)




	SELECT e.EmployeeID ,   e.EmployeeName ,  CASE	WHEN	IsActive = 1 THEN '��ְ' ELSE'��ְ'END IsActive,           e.IDNumber ,          CASE	 WHEN e.Gender = 0 THEN '��' ELSE 'Ů'END Gender ,          e.Email ,           e.Phone ,           e.Address ,           e.EntryDate ,           e.ChangeDate ,           d.DepartmentName,           e.BirthDay ,          
	 e.Position ,           el.EducationLevel 	FROM dbo.Employee e JOIN dbo.Department d ON	d.DepartmentID = e.DepartmentID
		JOIN dbo.EducationLevel el ON el.EducationLevelID = e.EducationLevelID
		WHERE Position LIKE '%����%'


		"SELECT e.EmployeeID ,e.EmployeeName ,CASE WHEN IsActive = 1 THEN '��ְ' ELSE'��ְ'END IsActive, e.IDNumber ,   CASE  WHEN e.Gender = 0 THEN '��' ELSE 'Ů'END Gender  ,  e.Email ,e.Phone ,e.Address , e.EntryDate , e.ChangeDate , d.DepartmentName,e.BirthDay ,"

UPDATE dbo.Employee SET Gender = 1

DELETE dbo.Employee WHERE EmployeeID >15

SELECT MaterialID ,
       MaterialName FROM dbo.Material

INSERT INTO dbo.Vendor
        ( VendorID, VendorName )
VALUES  ( 2, -- VendorID - int
          N'Ӣ�ض�'  -- VendorName - nvarchar(50)
          )

		  INSERT INTO dbo.Material
		          ( MaterialID, MaterialName )
		  VALUES  ( 2, -- MaterialID - int
		            N'CPU'  -- MaterialName - nvarchar(50)
		            )