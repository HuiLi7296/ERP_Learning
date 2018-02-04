ALTER PROC addUser
(@UserName VARCHAR(50), 
 @UserPwd VARCHAR(50),
 @Role VARCHAR(50))


 AS 
 /*
 exec addUser 'TestUser01', 'qqqqqq', 'HR1'
 */
 BEGIN TRY	

 DECLARE @RoleID INT 
 DECLARE @UserID INT 

 SELECT @RoleID = RoleID FROM dbo.Role WHERE ShortName = @Role 
 IF @RoleID IS NULL 
 
    RAISERROR (N'没有设定此角色！', -- Message text.  
               16, -- Severity.  
               1 -- State.  
               ); 

 INSERT INTO dbo.[User]
         ( UserName, UserPwd )
 VALUES  ( @UserName, -- UserName - varchar(50)
                   @UserPwd -- UserPwd - varchar(50)
                 )

SET	@UserID =  SCOPE_IDENTITY() 

INSERT INTO dbo.User_Role
        ( UserID, RoleID )
VALUES  ( @UserID,  
          @RoleID
          )

SELECT u.UserID ,
       u.UserName ,
       u.UserPwd ,
       ur.RoleID ,
       r.RoleID ,
       r.ShortName ,
       r.Description FROM dbo.[User] u 
JOIN dbo.User_Role ur ON ur.UserID = u.UserID
JOIN dbo.Role r ON r.RoleID = ur.RoleID
WHERE u.UserID = @UserID 

END TRY 
BEGIN CATCH
THROW
END CATCH