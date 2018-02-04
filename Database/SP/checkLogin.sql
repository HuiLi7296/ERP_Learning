SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
GO
CREATE PROC checkLogin
(@UserName VARCHAR(50), 
 @UserPwd VARCHAR(50)
 )

 AS 
 /*
 exec checkLogin 'huili', '123456' 
 */
 BEGIN TRY	


SELECT u.UserID ,
       u.UserName ,
       u.UserPwd ,
       ur.RoleID ,
       r.RoleID ,
       r.ShortName ,
       r.Description FROM dbo.[User] u 
JOIN dbo.User_Role ur ON ur.UserID = u.UserID
JOIN dbo.Role r ON r.RoleID = ur.RoleID
WHERE u.UserName = @UserName 
AND u.UserPwd = @UserPwd

END TRY 
BEGIN CATCH
THROW
END CATCH
GO