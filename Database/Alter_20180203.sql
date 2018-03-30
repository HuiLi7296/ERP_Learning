/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          ERP_Learning.dez                                */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Alter database script                           */
/* Created on:            2018-02-25 21:33                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Add table "SalesOutbound"                                              */
/* ---------------------------------------------------------------------- */

CREATE TABLE [SalesOutbound] (
    [SalesOutboundID] INTEGER IDENTITY(600001,1) NOT NULL,
    [SalesOrderID] VARCHAR(40) NOT NULL,
    [CreateDate] DATE CONSTRAINT [DEF_SalesOutbound_CreateDate] DEFAULT getdate() NOT NULL,
    [Quantity] INTEGER CONSTRAINT [DEF_SalesOutbound_Quantity] DEFAULT 0 NOT NULL,
    [Address] NVARCHAR(200),
    CONSTRAINT [PK_SalesOutbound] PRIMARY KEY ([SalesOutboundID])
)
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'销售出库单编号', 'SCHEMA', N'dbo', 'TABLE', N'SalesOutbound', 'COLUMN', N'SalesOutboundID'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'销售订单', 'SCHEMA', N'dbo', 'TABLE', N'SalesOutbound', 'COLUMN', N'SalesOrderID'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'出库单日期', 'SCHEMA', N'dbo', 'TABLE', N'SalesOutbound', 'COLUMN', N'CreateDate'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'数量', 'SCHEMA', N'dbo', 'TABLE', N'SalesOutbound', 'COLUMN', N'Quantity'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'地址', 'SCHEMA', N'dbo', 'TABLE', N'SalesOutbound', 'COLUMN', N'Address'
GO


/* ---------------------------------------------------------------------- */
/* Add table "SalesCollection"                                            */
/* ---------------------------------------------------------------------- */

CREATE TABLE [SalesCollection] (
    [SalesCollectionID] INTEGER IDENTITY(900001,1) NOT NULL,
    [SalesOrderID] INTEGER NOT NULL,
    [CreateDate] DATE CONSTRAINT [DEF_SalesCollection_CreateDate] DEFAULT getdate() NOT NULL,
    [Amount] MONEY NOT NULL,
    CONSTRAINT [PK_SalesCollection] PRIMARY KEY ([SalesCollectionID])
)
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'销售收款单编号', 'SCHEMA', N'dbo', 'TABLE', N'SalesCollection', 'COLUMN', N'SalesCollectionID'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'销售订单', 'SCHEMA', N'dbo', 'TABLE', N'SalesCollection', 'COLUMN', N'SalesOrderID'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'收款单日期', 'SCHEMA', N'dbo', 'TABLE', N'SalesCollection', 'COLUMN', N'CreateDate'
GO


EXECUTE sp_addextendedproperty N'MS_Description', N'收款金额', 'SCHEMA', N'dbo', 'TABLE', N'SalesCollection', 'COLUMN', N'Amount'
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

ALTER TABLE [SalesOutbound] ADD CONSTRAINT [SalesOrder_SalesOutbound] 
    FOREIGN KEY ([SalesOrderID]) REFERENCES [dbo].[SalesOrder] ([SalesOrderID])
GO


ALTER TABLE [SalesCollection] ADD CONSTRAINT [SalesOrder_SalesCollection] 
    FOREIGN KEY ([SalesOrderID]) REFERENCES [dbo].[SalesOrder] ([SalesOrderID])
GO

