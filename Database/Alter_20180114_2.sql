/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          Project1.dez                                    */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Alter database script                           */
/* Created on:            2018-01-14 22:21                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop procedures                                                        */
/* ---------------------------------------------------------------------- */

DROP PROCEDURE [dbo].[getLoginUserRole]
GO


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[User] DROP CONSTRAINT [Role_User]
GO


/* ---------------------------------------------------------------------- */
/* Drop and recreate table "Role"                                         */
/* ---------------------------------------------------------------------- */

/* Table must be recreated because some of the changes can't be done with the regular commands available. */

ALTER TABLE [dbo].[Role] DROP CONSTRAINT [PK_Role]
GO


CREATE TABLE [Role_TMP] (
    [RoleID] INTEGER IDENTITY(0,1) NOT NULL,
    [ShortName] VARCHAR(50) NOT NULL,
    [Description] NVARCHAR(50))
GO



SET IDENTITY_INSERT [Role_TMP] ON
GO



INSERT INTO [Role_TMP]
    ([RoleID],[ShortName],[Description])
SELECT
    [RoleID],[ShortName],[Description]
FROM [dbo].[Role]
GO



SET IDENTITY_INSERT [Role_TMP] OFF
GO



DROP TABLE [dbo].[Role]
GO


EXEC sp_rename '[Role_TMP]', 'Role', 'OBJECT'
GO


ALTER TABLE [Role] ADD CONSTRAINT [PK_Role] 
    PRIMARY KEY ([RoleID])
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Role', NULL, NULL
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Role', 'COLUMN', N'RoleID'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Role', 'COLUMN', N'ShortName'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Role', 'COLUMN', N'Description'
GO


/* ---------------------------------------------------------------------- */
/* Add table "Employee"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Employee] (
    [EmployeeID] INTEGER IDENTITY(0,1) NOT NULL,
    [EmployeeName] NVARCHAR(40) NOT NULL,
    [IsActive] BIT NOT NULL,
    [IDNumber] VARCHAR(40),
    [Gender] BIT NOT NULL,
    [Email] VARCHAR(100),
    [Phone] VARCHAR(40),
    [Address] NVARCHAR(200),
    [EntryDate] DATE CONSTRAINT [DEF_Employee_EntryDate] DEFAULT getdate() NOT NULL,
    [ChangeDate] DATETIME CONSTRAINT [DEF_Employee_ChangeDate] DEFAULT getdate(),
    CONSTRAINT [PK_Employee] PRIMARY KEY ([EmployeeID])
)
GO


CREATE NONCLUSTERED INDEX [IDX_Employee_1] ON [Employee] ([EmployeeName])
GO


CREATE UNIQUE NONCLUSTERED INDEX [IDX_Employee_2] ON [Employee] ([IDNumber])
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'Identity Card Number ', 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'IDNumber'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'0 is Woman, 1 is Man', 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'Gender'
GO


/* ---------------------------------------------------------------------- */
/* Add table "Module"                                                     */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Module] (
    [ModuleID] INTEGER IDENTITY(1,1) NOT NULL,
    [ModuleName] NVARCHAR(100),
    CONSTRAINT [PK_Module] PRIMARY KEY ([ModuleID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

ALTER TABLE [User] ADD CONSTRAINT [Role_User] 
    FOREIGN KEY ([RoleID]) REFERENCES [Role] ([RoleID])
GO

