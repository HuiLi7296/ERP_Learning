/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          ERP_Learning.dez                                */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Alter database script                           */
/* Created on:            2018-01-26 21:05                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [Department_Employee]
GO


/* ---------------------------------------------------------------------- */
/* Modify table "Employee"                                                */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[Employee] ADD
    [EducationLevelID] INTEGER NOT NULL
GO


/* ---------------------------------------------------------------------- */
/* Add table "EducationLevel"                                             */
/* ---------------------------------------------------------------------- */

CREATE TABLE [EducationLevel] (
    [EducationLevelID] INTEGER IDENTITY(1,1) NOT NULL,
    [EducationLevel] NVARCHAR(40),
    CONSTRAINT [PK_EducationLevel] PRIMARY KEY ([EducationLevelID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [Department_Employee] 
    FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department] ([DepartmentID])
GO


ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [EducationLevel_Employee] 
    FOREIGN KEY ([EducationLevelID]) REFERENCES [EducationLevel] ([EducationLevelID])
GO

