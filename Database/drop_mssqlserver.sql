/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          Project1.dez                                    */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database drop script                            */
/* Created on:            2018-01-14 15:35                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [User] DROP CONSTRAINT [Role_User]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "User"                                                      */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [User] DROP CONSTRAINT [PK_User]
GO


/* Drop table */

EXECUTE sp_dropextendedproperty N'MS_Description', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'UserName'
GO


EXECUTE sp_dropextendedproperty N'MS_Description', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'UserPwd'
GO


EXECUTE sp_dropextendedproperty N'MS_Description', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'RoleID'
GO


DROP TABLE [User]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Role"                                                      */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [Role] DROP CONSTRAINT [PK_Role]
GO


/* Drop table */

DROP TABLE [Role]
GO

