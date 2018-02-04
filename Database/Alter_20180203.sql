/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          ERP_Learning.dez                                */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Alter database script                           */
/* Created on:            2018-02-03 11:40                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[PurchaseOrder] DROP CONSTRAINT [Material_PurchaseOrder]
GO


ALTER TABLE [dbo].[PurchaseOrder] DROP CONSTRAINT [Vendor_PurchaseOrder]
GO


ALTER TABLE [dbo].[PurchaseOrder] DROP CONSTRAINT [Employee_PurchaseOrder]
GO


ALTER TABLE [dbo].[WarehouseWarrant] DROP CONSTRAINT [Employee_WarehouseWarrant]
GO


ALTER TABLE [dbo].[WarehouseWarrant] DROP CONSTRAINT [PurchaseOrder_WarehouseWarrant]
GO


/* ---------------------------------------------------------------------- */
/* Modify table "PurchaseOrder"                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[PurchaseOrder] DROP CONSTRAINT [DEF_PurchaseOrder_CreateDate]
GO


ALTER TABLE [dbo].[PurchaseOrder] ALTER COLUMN [CreateDate] DATE NOT NULL
GO


ALTER TABLE [dbo].[PurchaseOrder] ADD CONSTRAINT [DEF_PurchaseOrder_CreateDate] 
    DEFAULT (getdate()) FOR [CreateDate]
GO


/* ---------------------------------------------------------------------- */
/* Modify table "WarehouseWarrant"                                        */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[WarehouseWarrant] DROP CONSTRAINT [DEF_WarehouseWarrant_CreateDate]
GO


ALTER TABLE [dbo].[WarehouseWarrant] ALTER COLUMN [CreateDate] DATE NOT NULL
GO


ALTER TABLE [dbo].[WarehouseWarrant] ADD CONSTRAINT [DEF_WarehouseWarrant_CreateDate] 
    DEFAULT (getdate()) FOR [CreateDate]
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[PurchaseOrder] ADD CONSTRAINT [Material_PurchaseOrder] 
    FOREIGN KEY ([MaterialID]) REFERENCES [dbo].[Material] ([MaterialID])
GO


ALTER TABLE [dbo].[PurchaseOrder] ADD CONSTRAINT [Vendor_PurchaseOrder] 
    FOREIGN KEY ([VendorID]) REFERENCES [dbo].[Vendor] ([VendorID])
GO


ALTER TABLE [dbo].[PurchaseOrder] ADD CONSTRAINT [Employee_PurchaseOrder] 
    FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([EmployeeID])
GO


ALTER TABLE [dbo].[WarehouseWarrant] ADD CONSTRAINT [Employee_WarehouseWarrant] 
    FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([EmployeeID])
GO


ALTER TABLE [dbo].[WarehouseWarrant] ADD CONSTRAINT [PurchaseOrder_WarehouseWarrant] 
    FOREIGN KEY ([PurchaseOrderID]) REFERENCES [dbo].[PurchaseOrder] ([PurchaseOrderID])
GO

