/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          ERP_Learning.dez                                */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Alter database script                           */
/* Created on:            2018-01-15 23:02                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop views                                                             */
/* ---------------------------------------------------------------------- */

DROP VIEW [sys].[database_firewall_rules]
GO


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[User] DROP CONSTRAINT [Role_User]
GO


/* ---------------------------------------------------------------------- */
/* Drop and recreate table "User"                                         */
/* ---------------------------------------------------------------------- */

/* Table must be recreated because some of the changes can't be done with the regular commands available. */

ALTER TABLE [dbo].[User] DROP CONSTRAINT [PK_User]
GO


CREATE TABLE [User_TMP] (
    [UserID] INTEGER IDENTITY(1,1) NOT NULL,
    [UserName] VARCHAR(50) NOT NULL,
    [UserPwd] VARCHAR(50) NOT NULL,
    [RoleID] INTEGER NOT NULL)
GO



SET IDENTITY_INSERT [User_TMP] ON
GO



INSERT INTO [User_TMP]
    ([UserID],[UserName],[UserPwd],[RoleID])
SELECT
    [UserID],[UserName],[UserPwd],[RoleID]
FROM [dbo].[User]
GO



SET IDENTITY_INSERT [User_TMP] OFF
GO



DROP INDEX [dbo].[User].[IDX_User_1]
GO


DROP TABLE [dbo].[User]
GO


EXEC sp_rename '[User_TMP]', 'User', 'OBJECT'
GO


ALTER TABLE [User] ADD CONSTRAINT [PK_User] 
    PRIMARY KEY ([UserID], [RoleID])
GO


CREATE UNIQUE NONCLUSTERED INDEX [IDX_User_1] ON [User] ([UserName],[UserPwd])
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'User', NULL, NULL
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'UserID'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'Login Name', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'UserName'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'Login Pwd', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'UserPwd'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'FK from Role table', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'RoleID'
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
/* Drop and recreate table "Employee"                                     */
/* ---------------------------------------------------------------------- */

/* Table must be recreated because some of the changes can't be done with the regular commands available. */

ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [DEF_Employee_EntryDate]
GO


ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [DEF_Employee_ChangeDate]
GO


ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [PK_Employee]
GO


CREATE TABLE [Employee_TMP] (
    [EmployeeID] INTEGER IDENTITY(1,1) NOT NULL,
    [EmployeeName] NVARCHAR(40) NOT NULL,
    [IsActive] BIT NOT NULL,
    [IDNumber] VARCHAR(40),
    [Gender] BIT NOT NULL,
    [Email] VARCHAR(100),
    [Phone] VARCHAR(40),
    [Address] NVARCHAR(200),
    [EntryDate] DATE CONSTRAINT [DEF_Employee_EntryDate] DEFAULT getdate() NOT NULL,
    [ChangeDate] DATETIME CONSTRAINT [DEF_Employee_ChangeDate] DEFAULT getdate(),
    [DepartmentID] INTEGER NOT NULL)
GO



SET IDENTITY_INSERT [Employee_TMP] ON
GO



INSERT INTO [Employee_TMP]
    ([EmployeeID],[EmployeeName],[IsActive],[IDNumber],[Gender],[Email],[Phone],[Address],[EntryDate],[ChangeDate])
SELECT
    [EmployeeID],[EmployeeName],[IsActive],[IDNumber],[Gender],[Email],[Phone],[Address],[EntryDate],[ChangeDate]
FROM [dbo].[Employee]
GO



SET IDENTITY_INSERT [Employee_TMP] OFF
GO



DROP INDEX [dbo].[Employee].[IDX_Employee_1]
GO


DROP INDEX [dbo].[Employee].[IDX_Employee_2]
GO


DROP TABLE [dbo].[Employee]
GO


EXEC sp_rename '[Employee_TMP]', 'Employee', 'OBJECT'
GO


ALTER TABLE [Employee] ADD CONSTRAINT [PK_Employee] 
    PRIMARY KEY ([EmployeeID])
GO


CREATE NONCLUSTERED INDEX [IDX_Employee_1] ON [Employee] ([EmployeeName])
GO


CREATE UNIQUE NONCLUSTERED INDEX [IDX_Employee_2] ON [Employee] ([IDNumber])
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', NULL, NULL
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'EmployeeID'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'EmployeeName'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'IsActive'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'Identity Card Number ', 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'IDNumber'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'0 is Woman, 1 is Man', 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'Gender'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'Email'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'Phone'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'Address'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'EntryDate'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'ChangeDate'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Employee', 'COLUMN', N'DepartmentID'
GO


/* ---------------------------------------------------------------------- */
/* Drop and recreate table "Module"                                       */
/* ---------------------------------------------------------------------- */

/* Table must be recreated because some of the changes can't be done with the regular commands available. */

ALTER TABLE [dbo].[Module] DROP CONSTRAINT [PK_Module]
GO


CREATE TABLE [Module_TMP] (
    [ModuleID] INTEGER IDENTITY(1,1) NOT NULL,
    [ModuleName] NVARCHAR(100))
GO



SET IDENTITY_INSERT [Module_TMP] ON
GO



INSERT INTO [Module_TMP]
    ([ModuleID],[ModuleName])
SELECT
    [ModuleID],[ModuleName]
FROM [dbo].[Module]
GO



SET IDENTITY_INSERT [Module_TMP] OFF
GO



DROP TABLE [dbo].[Module]
GO


EXEC sp_rename '[Module_TMP]', 'Module', 'OBJECT'
GO


ALTER TABLE [Module] ADD CONSTRAINT [PK_Module] 
    PRIMARY KEY ([ModuleID])
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Module', NULL, NULL
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Module', 'COLUMN', N'ModuleID'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N, 'SCHEMA', N'dbo', 'TABLE', N'Module', 'COLUMN', N'ModuleName'
GO


/* ---------------------------------------------------------------------- */
/* Add table "Department"                                                 */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Department] (
    [DepartmentID] INTEGER IDENTITY(1,1) NOT NULL,
    [DepartmentName] NVARCHAR(40) NOT NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY ([DepartmentID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

ALTER TABLE [User] ADD CONSTRAINT [Role_User] 
    FOREIGN KEY ([RoleID]) REFERENCES [Role] ([RoleID])
GO


ALTER TABLE [Employee] ADD CONSTRAINT [Department_Employee] 
    FOREIGN KEY ([DepartmentID]) REFERENCES [Department] ([DepartmentID])
GO

