/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.3.4                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          ERP_Learning.dez                                */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Alter database script                           */
/* Created on:            2018-02-06 22:56                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[WarehouseWarrant] DROP CONSTRAINT [Employee_WarehouseWarrant]
GO


ALTER TABLE [dbo].[WarehouseWarrant] DROP CONSTRAINT [PurchaseOrder_WarehouseWarrant]
GO


/* ---------------------------------------------------------------------- */
/* Modify table "WarehouseWarrant"                                        */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[WarehouseWarrant] ADD
    [WarehouseID] INTEGER
GO


/* ---------------------------------------------------------------------- */
/* Add table "Warehouse"                                                  */
/* ---------------------------------------------------------------------- */

CREATE TABLE [Warehouse] (
    [WarehouseID] INTEGER IDENTITY(1,1) NOT NULL,
    [WarehouseName] NVARCHAR(40) NOT NULL,
    CONSTRAINT [PK_Warehouse] PRIMARY KEY ([WarehouseID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

ALTER TABLE [dbo].[WarehouseWarrant] ADD CONSTRAINT [Employee_WarehouseWarrant] 
    FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([EmployeeID])
GO


ALTER TABLE [dbo].[WarehouseWarrant] ADD CONSTRAINT [PurchaseOrder_WarehouseWarrant] 
    FOREIGN KEY ([PurchaseOrderID]) REFERENCES [dbo].[PurchaseOrder] ([PurchaseOrderID])
GO


ALTER TABLE [dbo].[WarehouseWarrant] ADD CONSTRAINT [Warehouse_WarehouseWarrant] 
    FOREIGN KEY ([WarehouseID]) REFERENCES [Warehouse] ([WarehouseID])
GO

