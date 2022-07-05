CREATE TABLE Products (
    Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    Name VARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE Categories (
    Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    Name VARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE ProductsCategories (
    ProductId INT,
    CategoryId INT,
    CONSTRAINT FK_ProductsCategories_To_Products FOREIGN KEY (ProductId)  REFERENCES Products (Id),
    CONSTRAINT FK_ProductsCategories_To_Categories FOREIGN KEY (CategoryId)  REFERENCES Categories (Id)
);