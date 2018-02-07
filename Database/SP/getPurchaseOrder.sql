ALTER PROCEDURE getPurchaseOrder
    (
      @PurchaseOrderID INT = NULL ,
      @PurchaseDate DATE = NULL
    )
AS
--getPurchaseOrder 100002, null 
    BEGIN TRY	
        SELECT  po.PurchaseOrderID ,
                po.CreateDate ,
                m.MaterialName ,
                v.VendorName ,
                po.UnitPrice ,
                po.Quantity ,
                e.EmployeeName ,
                po.Amount ,
               IsAudit= CASE WHEN po.IsAudit = 1 THEN '“—…Û∫À' ELSE 'Œ¥…Û∫À' END 
        FROM    dbo.PurchaseOrder po
                JOIN dbo.Material m ON m.MaterialID = po.MaterialID
                JOIN dbo.Vendor v ON v.VendorID = po.VendorID
                JOIN dbo.Employee e ON e.EmployeeID = po.EmployeeID
        WHERE   
                PurchaseOrderID = ISNULL(@PurchaseOrderID, PurchaseOrderID)
                AND  CreateDate = ISNULL(@PurchaseDate, CreateDate);

    END TRY 
    BEGIN CATCH
        THROW;
    END CATCH;