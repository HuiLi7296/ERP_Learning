ALTER PROCEDURE getPurchaseOrder
( @PurchaseOrderID INT = NULL, 
  @PurchaseDate DATE = NULL
)

AS 
BEGIN TRY	
SELECT po.PurchaseOrderID ,
       po.CreateDate ,
       --po.MaterialID ,
       --po.VendorID ,
       po.UnitPrice ,
       po.Quantity ,
       --po.EmployeeID ,
       po.IsAudit ,
       po.Amount ,
       --m.MaterialID ,
       m.MaterialName ,
       --v.VendorID ,
       v.VendorName ,
       e.EmployeeID ,
       e.EmployeeName 
 
FROM dbo.PurchaseOrder po
JOIN dbo.Material m ON m.MaterialID = po.MaterialID
JOIN dbo.Vendor v ON v.VendorID = po.VendorID
JOIN dbo.Employee e ON e.EmployeeID = po.EmployeeID

WHERE 1=1
AND PurchaseOrderID = ISNULL(@PurchaseOrderID ,PurchaseOrderID) 
OR    CreateDate = ISNULL(@PurchaseDate , CreateDate)

 END TRY 
BEGIN CATCH
THROW
END CATCH