CREATE PROCEDURE deletePurchaseOrder
    (
      @PurchaseOrderID INT 
    )
AS
    BEGIN TRY	

IF EXISTS (SELECT * FROM dbo.PurchaseOrder WHERE PurchaseOrderID = @PurchaseOrderID AND IsAudit = 1 ) 
RETURN 1   -------this order has been audited, cannot remove 

DELETE dbo.PurchaseOrder WHERE PurchaseOrderID = @PurchaseOrderID 
RETURN 0

    END TRY 
    BEGIN CATCH
        THROW;
    END CATCH;