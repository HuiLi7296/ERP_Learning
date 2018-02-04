CREATE PROCEDURE updatePurchaseOrder
    (
      @PurchaseOrderID INT ,
      @CreateDate DATE ,
      @MaterialID INT ,
      @VendorID INT ,
      @UnitPrice MONEY ,
      @Quantity INT ,
      @EmployeeID INT ,
      @IsAudit BIT	
    )
AS
    BEGIN TRY	

        UPDATE  dbo.PurchaseOrder
        SET     CreateDate = @CreateDate ,
                MaterialID = @MaterialID ,
                VendorID = @VendorID ,
                UnitPrice = @UnitPrice ,
                Quantity = @Quantity ,
                EmployeeID = @EmployeeID ,
                IsAudit = @IsAudit
        WHERE   PurchaseOrderID = @PurchaseOrderID;


    END TRY 
    BEGIN CATCH
        THROW;
    END CATCH;