INSERT INTO Products (Name)
VALUES ('Butter'),
       ('Bread'),
	   ('Shirt'),
	   ('Trousers'),
	   ('Not categorised product'),
	   ('Charlie Chaplin`s eatable boot')

INSERT INTO Categories (Name)
VALUES ('Food'),
       ('Clothes')

INSERT INTO ProductsCategories (ProductId, CategoryId)
VALUES ((SELECT Id FROM Products WHERE Name LIKE('Butter')), (SELECT Id FROM Categories WHERE Name LIKE('Food'))),
       ((SELECT Id FROM Products WHERE Name LIKE('Bread')), (SELECT Id FROM Categories WHERE Name LIKE('Food'))),
	   ((SELECT Id FROM Products WHERE Name LIKE('Shirt')), (SELECT Id FROM Categories WHERE Name LIKE('Clothes'))),
       ((SELECT Id FROM Products WHERE Name LIKE('Trousers')), (SELECT Id FROM Categories WHERE Name LIKE('Clothes'))),
	   ((SELECT Id FROM Products WHERE Name LIKE('Charlie Chaplin`s eatable boot')), (SELECT Id FROM Categories WHERE Name LIKE('Food'))),
       ((SELECT Id FROM Products WHERE Name LIKE('Charlie Chaplin`s eatable boot')), (SELECT Id FROM Categories WHERE Name LIKE('Clothes')));