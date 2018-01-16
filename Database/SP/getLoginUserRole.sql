CREATE PROCEDURE getLoginUserRole 
(@UserName VARCHAR(50), 
 @UserPwd VARCHAR(50))
AS 


SELECT * 
FROM dbo.[User] u 
JOIN dbo.Role r ON r.RoleID = u.RoleID 
WHERE u.UserName = @UserName 
	AND u.UserPwd = @UserPwd

