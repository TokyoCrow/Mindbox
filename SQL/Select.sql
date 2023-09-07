SELECT p."Name", c."Name"
FROM dbo.Product p
LEFT JOIN dbo.ProductCategory pc on pc.ProductId = p.Id 
LEFT JOIN dbo.Category c on c.Id = pc.CategoryId;