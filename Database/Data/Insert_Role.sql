INSERT INTO dbo.Role
        ( ShortName, Description )
VALUES  ( 'Admin', -- ShortName - varchar(50)
          N'管理员，可以操作所有模块'  -- Description - nvarchar(50)
          )

INSERT INTO dbo.Role
        ( ShortName, Description )
VALUES  ( 'HR', -- ShortName - varchar(50)
          N'可以操作HR模块'  -- Description - nvarchar(50)
          )


 exec addUser 'TestUser01', 'qqqqqq', 'HR1'

SELECT * FROM dbo.Role


INSERT INTO dbo.[User]
        ( UserName, UserPwd)
VALUES  ( 'HuiLi', -- UserName - varchar(50)
          '123456'-- UserPwd - varchar(50)
          )

SELECT * FROM dbo.[User] 

INSERT INTO dbo.User_Role
        ( UserID, RoleID )
VALUES  ( 1, -- UserID - int
          0  -- RoleID - int
          )

 EXEC dbo.addUser @UserName = '', -- varchar(50)
     @UserPwd = '', -- varchar(50)
     @Role = '' -- varchar(50)
 