SELECT Prod.Name as Product, ISNULL(Cat.Name, '-') as Category
FROM Products Prod
LEFT JOIN ProductsCategories PC ON Prod.Id = PC.ProductId
LEFT JOIN Categories Cat ON PC.CategoryId = Cat.Id;