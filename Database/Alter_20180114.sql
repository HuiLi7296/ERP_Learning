/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          Project1.dez                                    */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Alter database script                           */
/* Created on:            2018-01-14 15:42                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Add table "User"                                                       */
/* ---------------------------------------------------------------------- */

CREATE TABLE [User] (
    [UserID] INTEGER IDENTITY(1,1) NOT NULL,
    [UserName] VARCHAR(50) NOT NULL,
    [UserPwd] VARCHAR(50) NOT NULL,
    [RoleID] INTEGER NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([UserID], [RoleID])
)
GO


CREATE UNIQUE NONCLUSTERED INDEX [IDX_User_1] ON [User] ([UserName],[UserPwd])
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'Login Name', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'UserName'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'Login Pwd', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'UserPwd'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'FK from Role table', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'RoleID'
GO


/* ---------------------------------------------------------------------- */
/* Add table "Role"                                                       */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Role] (
    [RoleID] INTEGER IDENTITY(0,1) NOT NULL,
    [ShortName] VARCHAR(50) NOT NULL,
    [Description] VARCHAR(100),
    CONSTRAINT [PK_Role] PRIMARY KEY ([RoleID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

ALTER TABLE [User] ADD CONSTRAINT [Role_User] 
    FOREIGN KEY ([RoleID]) REFERENCES [Role] ([RoleID])
GO

