INSERT INTO dbo.Role
        ( ShortName, Description )
VALUES  ( 'Admin', -- ShortName - varchar(50)
          N'管理员，可以操作所有模块'  -- Description - nvarchar(50)
          )


SELECT * FROM dbo.Role


INSERT INTO dbo.[User]
        ( UserName, UserPwd, RoleID )
VALUES  ( 'HuiLi', -- UserName - varchar(50)
          '123456', -- UserPwd - varchar(50)
          0  -- RoleID - int
          )


		  SELECT * FROM dbo.[User] u JOIN dbo.Role r ON r.RoleID = u.RoleID