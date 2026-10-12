-- =========================================================================
-- SCHEMA: BASE TABLES CREATION
-- =========================================================================

-- 1. Create Employee Table
CREATE TABLE Employee
(
    Fname VARCHAR(50) NOT NULL,
    Minit CHAR(1) NOT NULL,
    Lname VARCHAR(50) NOT NULL,
    SSN BIGINT PRIMARY KEY,
    Bdate DATE,
    Address VARCHAR(50),
    Sex CHAR(1),
    Salary INT,
    Super_SSN BIGINT,
    Dno INT,
    FOREIGN KEY (Super_SSN) REFERENCES Employee(SSN)
);
GO

-- 2. Create Department Table
CREATE TABLE Department
(
    Dname VARCHAR(50),
    Dnumber INT PRIMARY KEY,
    Mgr_SSN BIGINT,
    Mgr_Start_Date DATE,
    FOREIGN KEY (Mgr_SSN) REFERENCES Employee(SSN)
);
GO

-- 3. Create Department Locations Table
CREATE TABLE Dept_Locations
(
    Dnumber INT,
    Dlocation VARCHAR(50),
    PRIMARY KEY (Dnumber, Dlocation),
    FOREIGN KEY (Dnumber) REFERENCES Department(Dnumber)
);
GO

-- 4. Create Project Table
CREATE TABLE Project
(
    Pname VARCHAR(50),
    Pnumber INT PRIMARY KEY,
    Plocation VARCHAR(50),
    Dnum INT,
    FOREIGN KEY (Dnum) REFERENCES Department(Dnumber)
);
GO

-- 5. Create Works_On Table
CREATE TABLE Works_On
(
    Essn BIGINT,
    Pno INT,
    PRIMARY KEY (Essn, Pno),
    Hours FLOAT,
    FOREIGN KEY (Essn) REFERENCES Employee(SSN),
    FOREIGN KEY (Pno) REFERENCES Project(Pnumber)
);
GO

-- 6. Create Portal Administration Table
CREATE TABLE Admin
(
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL
);
GO

-- 7. Create Supplier Table
CREATE TABLE Supplier
(
    SNum INT PRIMARY KEY,
    SName VARCHAR(50),
    City VARCHAR(50),
    Status INT
);
GO

-- 8. Create Dependent Table
CREATE TABLE Dependent
(
    Essn BIGINT,
    Dependent_name VARCHAR(50),
    Sex CHAR(1),
    Bdate DATE,
    Relationship VARCHAR(50),
    PRIMARY KEY (Essn, Dependent_name),
    FOREIGN KEY (Essn) REFERENCES Employee(SSN) ON DELETE CASCADE
);
GO
