/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          ERP_Learning.dez                                */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Alter database script                           */
/* Created on:            2018-01-21 23:12                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[User] DROP CONSTRAINT [Role_User]
GO


ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [Department_Employee]
GO


/* ---------------------------------------------------------------------- */
/* Modify table "User"                                                    */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[User] DROP CONSTRAINT [PK_User]
GO


ALTER TABLE [dbo].[User] DROP COLUMN [RoleID]
GO


ALTER TABLE [dbo].[User] ADD CONSTRAINT [PK_User] 
    PRIMARY KEY CLUSTERED ([UserID])
GO


/* ---------------------------------------------------------------------- */
/* Modify table "Employee"                                                */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[Employee] ADD
    [BirthDay] DATE NOT NULL
GO


ALTER TABLE [dbo].[Employee] ADD
    [Position] NVARCHAR(40)
GO


/* ---------------------------------------------------------------------- */
/* Add table "User_Role"                                                  */
/* ---------------------------------------------------------------------- */

CREATE TABLE [User_Role] (
    [UserID] INTEGER NOT NULL,
    [RoleID] INTEGER NOT NULL,
    CONSTRAINT [PK_User_Role] PRIMARY KEY ([UserID], [RoleID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "Role_Module"                                                */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Role_Module] (
    [RoleID] INTEGER NOT NULL,
    [ModuleID] INTEGER NOT NULL,
    CONSTRAINT [PK_Role_Module] PRIMARY KEY ([RoleID], [ModuleID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [Department_Employee] 
    FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department] ([DepartmentID])
GO


ALTER TABLE [User_Role] ADD CONSTRAINT [User_User_Role] 
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([UserID])
GO


ALTER TABLE [User_Role] ADD CONSTRAINT [Role_User_Role] 
    FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Role] ([RoleID])
GO


ALTER TABLE [Role_Module] ADD CONSTRAINT [Role_Role_Module] 
    FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Role] ([RoleID])
GO


ALTER TABLE [Role_Module] ADD CONSTRAINT [Module_Role_Module] 
    FOREIGN KEY ([ModuleID]) REFERENCES [dbo].[Module] ([ModuleID])
GO

