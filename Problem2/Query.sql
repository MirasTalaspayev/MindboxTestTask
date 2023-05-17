CREATE TABLE Product (
    ID INT PRIMARY KEY IDENTITY,
    ProductName VARCHAR(255)
);

CREATE TABLE Category (
    ID INT PRIMARY KEY IDENTITY,
    CategoryName VARCHAR(255)
);

CREATE TABLE Product_Category (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Product(ID),
    FOREIGN KEY (CategoryID) REFERENCES Category(ID)
);

/*
	query for getting Product_Category
*/

SELECT 
    P.ProductName, 
    ISNULL(C.CategoryName, '') AS CategoryName
FROM 
    Product AS P
LEFT JOIN 
    Product_Category AS PC ON P.ID = PC.ProductID
LEFT JOIN 
    Category AS C ON PC.CategoryID = C.ID
ORDER BY 
    P.ProductName;

