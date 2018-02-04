CREATE PROCEDURE addPurchaseOrder
( 
  --@PurchaseOrderID	int	
 --,@CreateDate	date	
@MaterialID	int	
,@VendorID	int	
,@UnitPrice	money	
,@Quantity	int	
,@EmployeeID	int	 
,@IsAudit	bit	
)

AS 
BEGIN TRY	

INSERT INTO dbo.PurchaseOrder
        ( CreateDate ,
          MaterialID ,
          VendorID ,
          UnitPrice ,
          Quantity ,
          EmployeeID ,
          IsAudit
        )
VALUES  ( GETDATE() , -- CreateDate - date
          @MaterialID , -- MaterialID - int
         @VendorID, -- VendorID - int
          @UnitPrice , -- UnitPrice - money
          @Quantity , -- Quantity - int
          @EmployeeID , -- EmployeeID - int
          @IsAudit  -- IsAudit - bit
        )


 END TRY 
BEGIN CATCH
THROW
END CATCH