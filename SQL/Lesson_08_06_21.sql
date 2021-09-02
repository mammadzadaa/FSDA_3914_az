CREATE DATABASE Store;
USE Store;

CREATE TABLE Categories(
Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
[Name] NVARCHAR(500) NOT NULL,
ParentId INT,
CONSTRAINT fk_Id_Parent_Id FOREIGN KEY(ParentId) 
REFERENCES Categories(Id) ON DELETE SET NULL
);

ALTER TABLE Categories
ADD CONSTRAINT ck_Parent_Id CHECK (Id <> ParentId);

INSERT INTO Categories VALUES('Phone',6);
UPDATE Categories SET ParentId = NULL WHERE Id = 5;

UPDATE Categories SET [Name] = 'No Category' WHERE Id = 1;
SELECT * FROM Categories;

CREATE TABLE Products(
Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
[Name] NVARCHAR(500) NOT NULL,
Price MONEY,
Expire_date DATE,
CategoryId INT NOT NULL DEFAULT 1
);

ALTER TABLE Products
ADD CONSTRAINT fk_CategoryId_Id 
FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
ON DELETE SET DEFAULT ON UPDATE SET DEFAULT;

INSERT INTO Products([Name],[Price],[Expire_date],[CategoryId]) VALUES ('IPhone',650,'01-06-50',7);

SELECT * FROM Products;

DELETE FROM Categories WHERE Id = 7;

