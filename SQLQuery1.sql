CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Address VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20),
    Username VARCHAR(50) UNIQUE NOT NULL,  -- New field for username
    Password VARCHAR(100) NOT NULL,        -- New field for password
    RegistrationDate DATETIME DEFAULT GETDATE()
);