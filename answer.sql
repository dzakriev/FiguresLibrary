SELECT Product.Name, Category.Name
FROM Product
LEFT JOIN ProductInCategory ON Product.Id = ProductInCategory.ProductId
LEFT JOIN Category ON ProductInCategory.CategoryId = Category.Id
-- ProductInCategory - развязочная таблица для связи многие ко многим