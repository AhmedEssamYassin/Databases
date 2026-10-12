-- CompanyDBLab_04_05: Full setup script

USE master;
GO

-- Remove the current database so it can be rebuilt fresh
IF DB_ID('CompanyDBLab_04_05') IS NOT NULL
BEGIN
    ALTER DATABASE CompanyDBLab_04_05 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CompanyDBLab_04_05;
END
GO
CREATE DATABASE CompanyDBLab_04_05;
GO


USE CompanyDBLab_04_05;
GO

-- Tables (Schemas)
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


CREATE TABLE Department
(
    Dname VARCHAR(50),
    Dnumber INT PRIMARY KEY,
    Mgr_SSN BIGINT,
    Mgr_Start_Date DATE,
    FOREIGN KEY (Mgr_SSN) REFERENCES Employee(SSN)
);
GO


CREATE TABLE Dept_Locations
(
    Dnumber INT,
    Dlocation VARCHAR(50),
    PRIMARY KEY (Dnumber, Dlocation),
    FOREIGN KEY (Dnumber) REFERENCES Department(Dnumber)
);
GO


CREATE TABLE Project
(
    Pname VARCHAR(50),
    Pnumber INT PRIMARY KEY,
    Plocation VARCHAR(50),
    Dnum INT,
    FOREIGN KEY (Dnum) REFERENCES Department(Dnumber)
);
GO


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


CREATE TABLE Admin
(
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL
);
GO


CREATE TABLE Supplier
(
    SNum INT PRIMARY KEY,
    SName VARCHAR(50),
    City VARCHAR(50),
    Status INT
);
GO


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

-- Circular FK constraints (Employee.Dno -> Department)

-- Alter Employee to bind DNO to Department (resolves circular dependency on creations)
ALTER TABLE Employee ADD FOREIGN KEY (Dno) REFERENCES Department(Dnumber);
GO

-- Stored procedures

-- Stored Procedure to search employees by name or exact SSN
CREATE PROCEDURE usp_SearchEmployees
    @SearchVal VARCHAR(50)
AS
BEGIN
    SELECT * FROM Employee 
    WHERE Fname LIKE '%' + @SearchVal + '%' 
       OR Lname LIKE '%' + @SearchVal + '%' 
       OR CAST(SSN AS VARCHAR(50)) = @SearchVal;
END
GO

-- Stored Procedure to get the count of employees working on a project
CREATE PROCEDURE usp_GetProjectEmployeeCount
    @Pnumber INT
AS
BEGIN
    SELECT COUNT(Essn) FROM Works_On WHERE Pno = @Pnumber;
END
GO

-- Stored Procedure to delete a project and clear Works_On dependencies safely
CREATE PROCEDURE usp_DeleteProject
    @Pnumber INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DELETE FROM Works_On WHERE Pno = @Pnumber;
        DELETE FROM Project WHERE Pnumber = @Pnumber;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Stored Procedure to delete an employee and clean up references safely
CREATE PROCEDURE dbo.usp_DeleteEmployee
    @SSN BIGINT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DELETE FROM Works_On WHERE Essn = @SSN;
        DELETE FROM Dependent WHERE Essn = @SSN;
        UPDATE Department SET Mgr_SSN = NULL WHERE Mgr_SSN = @SSN;
        UPDATE Employee SET Super_SSN = NULL WHERE Super_SSN = @SSN;
        DELETE FROM Employee WHERE SSN = @SSN;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Base data

-- Seed Portal Admin
-- Login: admin / admin
INSERT INTO Admin (username, password)
VALUES ('admin', 'admin');
GO

-- Seed Base Employees (null relations initially to bypass FK constraints)
INSERT INTO Employee 
VALUES
('John','B','Smith',123456789,'1965-09-11','731 Fondren, Houston, TX','M',30000,null,null),
('Franklin','T','Wong',333445555,'1955-12-08','638 Voss, Houston, TX','M',40000,null,null),
('Joyce','A','English',453453453,'1972-07-31','5631 Rice, Houston, T','F',25000,null,null),
('Ramesh','K','Narayan',666884444,'1962-09-15','975 Fire Oak, Humble, TX','M',38000,null,null),
('James','E','Borg',888665555,'1937-11-10','450 Stone, Houston, TX','M',55000,null,null),
('Jennifer','S','Wallace',987654321,'1941-06-20','291 Berry, Bellaire, TX','F',43000,null,null),
('Ahmad','V','Jabbar',987987987,'1969-03-29','980 Dallas, Houston, TX','M',25000,null,null),
('Alicia','J','Zelaya',999887777,'1968-01-19','3321,Castle, Spring, TX','F',25000,null,null);
GO

-- Seed Departments
INSERT INTO Department
VALUES
('Headquarters',1,888665555,'1981-06-19'),
('Administration',4,987654321,'1995-01-01'),
('Research',5,333445555,'1988-05-22');
GO

-- Seed Department Locations
INSERT INTO Dept_Locations
VALUES
(1, 'Houston'),
(4, 'Stafford'),
(5, 'Bellaire'),
(5, 'Houston'),
(5, 'Sugarland');
GO

-- Seed Base Projects
INSERT INTO Project
VALUES
('ProductX',1,'Bellaire',5),
('ProductY',2,'Sugarland',5),
('ProductZ',3,'Houston',5),
('Computerization',10,'Stafford',4),
('Reorganization',20,'Houston',1),
('Newbenefits',30,'Stafford',4);
GO

-- Seed Base Works_On records
INSERT INTO Works_On
VALUES
(123456789, 1, 32.5),
(123456789, 2, 7.5),
(666884444, 3, 40),
(453453453, 1, 20),
(453453453, 2, 20),
(333445555, 2, 10),
(333445555, 3, 10),
(333445555, 10, 10),
(333445555, 20, 10),
(999887777, 10, 10),
(999887777, 30, 30),
(987987987, 10, 35),
(987987987, 30, 5),
(987654321, 30, 20),
(987654321, 20, 15),
(888665555, 20, null);
GO

-- Update circular employee supervisor and department IDs
UPDATE Employee SET Super_SSN = 333445555, Dno = 5 WHERE SSN = 123456789;
UPDATE Employee SET Super_SSN = 888665555, Dno = 5 WHERE SSN = 333445555;
UPDATE Employee SET Super_SSN = 333445555, Dno = 5 WHERE SSN = 453453453;
UPDATE Employee SET Super_SSN = 333445555, Dno = 5 WHERE SSN = 666884444;
UPDATE Employee SET Super_SSN = NULL, Dno = 1	   WHERE SSN = 888665555;
UPDATE Employee SET Super_SSN = 888665555, Dno = 4 WHERE SSN = 987654321;
UPDATE Employee SET Super_SSN = 987654321, Dno = 4 WHERE SSN = 987987987;
UPDATE Employee SET Super_SSN = 987654321, Dno = 4 WHERE SSN = 999887777;
GO

-- Additional sample data

-- Seed Additional Employees
INSERT INTO Employee 
VALUES
('Michael', 'A', 'Johnson', 101010101, '1975-02-15', '123 Oak St, Houston, TX', 'M', 37000, NULL, NULL),
('Sara', 'M', 'Thompson', 102020202, '1980-11-05', '876 Maple Ave, Bellaire, TX', 'F', 45000, NULL, NULL),
('Daniel', 'B', 'Williams', 103030303, '1983-06-23', '445 Willow Dr, Sugarland, TX', 'M', 28000, NULL, NULL),
('Emily', 'C', 'Davis', 104040404, '1978-04-12', '22 Elm St, Stafford, TX', 'F', 36000, NULL, NULL),
('Christopher', 'L', 'Miller', 105050505, '1985-12-25', '678 Cedar St, Spring, TX', 'M', 50000, NULL, NULL),
('Olivia', 'N', 'Martinez', 106060606, '1990-03-18', '789 Pine Ave, Houston, TX', 'F', 42000, NULL, NULL),
('David', 'P', 'Rodriguez', 107070707, '1979-10-09', '32 Aspen Rd, Humble, TX', 'M', 35000, NULL, NULL),
('Sophia', 'Q', 'Garcia', 108080808, '1987-01-29', '85 Spruce Ln, Houston, TX', 'F', 33000, NULL, NULL),
('Lucas', 'R', 'Martinez', 109090909, '1993-09-16', '90 Poplar Dr, Houston, TX', 'M', 31000, NULL, NULL),
('Isabella', 'S', 'Hernandez', 110101010, '1982-05-06', '401 Birch St, Bellaire, TX', 'F', 44000, NULL, NULL);
GO

-- Seed Additional Departments
INSERT INTO Department
VALUES
('Marketing', 6, 101010101, '2000-01-10'),
('Sales', 7, 102020202, '2005-09-15'),
('Human Resources', 8, 103030303, '2010-11-20');
GO

-- Seed Additional Department Locations
INSERT INTO Dept_Locations
VALUES
(6, 'Houston'),
(7, 'Sugarland'),
(8, 'Bellaire'),
(6, 'Spring'),
(7, 'Stafford');
GO

-- Seed Additional Projects
INSERT INTO Project
VALUES
('CampaignA', 4, 'Houston', 6),
('CampaignB', 5, 'Bellaire', 6),
('InitiativeX', 6, 'Houston', 7),
('TrainingY', 7, 'Stafford', 8),
('EvaluationZ', 8, 'Sugarland', 8),
('Expansion', 9, 'Bellaire', 7),
('Outreach', 11, 'Houston', 6);
GO

-- Seed Additional Works_On records
INSERT INTO Works_On
VALUES
(101010101, 1, 20),
(101010101, 4, 15),
(102020202, 2, 25),
(102020202, 5, 10),
(103030303, 3, 35),
(103030303, 6, 5),
(104040404, 6, 30),
(105050505, 7, 40),
(106060606, 8, 20),
(107070707, 11, 10),
(108080808, 9, 30),
(109090909, 8, 15),
(110101010, 11, 20);
GO

-- Update additional employee supervisor and department structures
UPDATE Employee SET Super_SSN = 333445555, Dno = 6 WHERE SSN = 101010101;
UPDATE Employee SET Super_SSN = 888665555, Dno = 7 WHERE SSN = 102020202;
UPDATE Employee SET Super_SSN = 987654321, Dno = 8 WHERE SSN = 103030303;
UPDATE Employee SET Super_SSN = 333445555, Dno = 6 WHERE SSN = 104040404;
UPDATE Employee SET Super_SSN = 987654321, Dno = 7 WHERE SSN = 105050505;
GO

-- Seed Massive Bulk Employee Data
INSERT INTO Employee 
VALUES
('Liam', 'F', 'Clark', 111111111, '1986-02-03', '341 Aspen St, Houston, TX', 'M', 32000, NULL, NULL),
('Emma', 'D', 'Lewis', 222222222, '1992-07-22', '789 Willow Ave, Sugarland, TX', 'F', 47000, NULL, NULL),
('Ava', 'K', 'Harris', 444444444, '1991-11-01', '67 Oak St, Stafford, TX', 'F', 41000, NULL, NULL),
('Oliver', 'L', 'Brown', 555555555, '1984-06-09', '98 Birch St, Bellaire, TX', 'M', 39000, NULL, NULL),
('Charlotte', 'R', 'Dixon', 666666666, '1985-12-12', '43 Elm St, Houston, TX', 'F', 48000, NULL, NULL),
('Henry', 'G', 'Martin', 777777777, '1982-05-30', '273 Pine Ave, Spring, TX', 'M', 37000, NULL, NULL),
('Amelia', 'P', 'Hall', 888888888, '1988-03-25', '364 Cedar Rd, Houston, TX', 'F', 35000, NULL, NULL),
('William', 'N', 'Scott', 999999999, '1976-09-13', '64 Poplar Dr, Houston, TX', 'M', 46000, NULL, NULL),
('Mia', 'H', 'Moore', 123123123, '1990-08-18', '83 Aspen Rd, Sugarland, TX', 'F', 30000, NULL, NULL),
('Ethan', 'Q', 'Adams', 131313131, '1979-10-30', '213 Pine Ave, Houston, TX', 'M', 33000, NULL, NULL),
('Harper', 'Y', 'Stewart', 141414141, '1986-06-07', '90 Elm St, Stafford, TX', 'F', 45000, NULL, NULL),
('Alexander', 'T', 'Lopez', 151515151, '1978-01-05', '25 Cedar St, Bellaire, TX', 'M', 29000, NULL, NULL),
('Ella', 'B', 'Young', 161616161, '1981-05-10', '45 Spruce Ln, Houston, TX', 'F', 36000, NULL, NULL),
('Sebastian', 'C', 'Hill', 171717171, '1983-03-03', '102 Maple St, Humble, TX', 'M', 48000, NULL, NULL),
('Grace', 'V', 'Green', 181818181, '1993-02-02', '56 Oak Rd, Bellaire, TX', 'F', 42000, NULL, NULL),
('Benjamin', 'K', 'Baker', 191919191, '1980-07-11', '78 Willow Ave, Houston, TX', 'M', 36000, NULL, NULL),
('Zoey', 'D', 'Gonzalez', 202020202, '1989-12-12', '62 Elm St, Stafford, TX', 'F', 40000, NULL, NULL),
('Logan', 'S', 'Nelson', 212121212, '1992-04-01', '94 Cedar Ave, Sugarland, TX', 'M', 32000, NULL, NULL),
('Victoria', 'M', 'Carter', 232323232, '1984-10-22', '100 Oak Dr, Houston, TX', 'F', 47000, NULL, NULL),
('Jackson', 'Z', 'Mitchell', 242424242, '1991-09-29', '140 Birch St, Humble, TX', 'M', 35000, NULL, NULL),
('Layla', 'E', 'Perez', 252525252, '1993-08-15', '33 Aspen Rd, Spring, TX', 'F', 45000, NULL, NULL),
('Leo', 'H', 'Roberts', 262626262, '1987-05-19', '27 Willow Dr, Houston, TX', 'M', 37000, NULL, NULL),
('Hannah', 'A', 'Evans', 272727272, '1985-11-07', '91 Poplar Ln, Bellaire, TX', 'F', 46000, NULL, NULL),
('Samuel', 'B', 'Torres', 282828282, '1980-01-14', '84 Pine Ave, Houston, TX', 'M', 49000, NULL, NULL),
('Scarlett', 'C', 'Murphy', 292929292, '1988-02-26', '18 Maple St, Stafford, TX', 'F', 37000, NULL, NULL),
('Mason', 'R', 'Rivera', 303030303, '1983-06-18', '108 Oak St, Sugarland, TX', 'M', 33000, NULL, NULL),
('Chloe', 'G', 'Bell', 313131313, '1984-12-25', '101 Birch Dr, Bellaire, TX', 'F', 31000, NULL, NULL),
('Aiden', 'L', 'Sanchez', 323232323, '1986-10-06', '111 Maple Ave, Houston, TX', 'M', 39000, NULL, NULL),
('Ellie', 'M', 'Reed', 333333333, '1987-03-19', '120 Poplar Dr, Stafford, TX', 'F', 35000, NULL, NULL);
GO

-- Seed Bulk Employee Data Part 2
INSERT INTO Employee 
VALUES
('Henry', 'J', 'Carter', 201111111, '1985-08-15', '1502 Lake St, Stafford, TX', 'M', 37000, NULL, NULL),
('Natalie', 'G', 'Nguyen', 202222222, '1988-02-22', '501 Green St, Bellaire, TX', 'F', 48000, NULL, NULL),
('Matthew', 'H', 'Brown', 203333333, '1976-11-05', '80 Orange Dr, Sugarland, TX', 'M', 27000, NULL, NULL),
('Laura', 'D', 'Clark', 204444444, '1991-04-12', '130 Willow Dr, Spring, TX', 'F', 34000, NULL, NULL),
('Steven', 'M', 'Lee', 205555555, '1984-03-15', '564 Oak Dr, Houston, TX', 'M', 39000, NULL, NULL),
('Ashley', 'O', 'Garcia', 206666666, '1990-12-19', '675 Elm Rd, Humble, TX', 'F', 41000, NULL, NULL),
('Ethan', 'I', 'Moore', 207777777, '1987-07-09', '19 Pine Blvd, Bellaire, TX', 'M', 45000, NULL, NULL),
('Chloe', 'N', 'Lopez', 208888888, '1992-05-21', '4 Cedar Ave, Houston, TX', 'F', 35000, NULL, NULL),
('Brandon', 'T', 'Hill', 209999999, '1979-01-10', '999 Rose St, Stafford, TX', 'M', 33000, NULL, NULL),
('Samantha', 'E', 'Scott', 210101010, '1983-09-30', '555 Vine St, Houston, TX', 'F', 40000, NULL, NULL),
('Aaron', 'L', 'Green', 211111111, '1990-06-12', '12 Aspen Ave, Sugarland, TX', 'M', 37000, NULL, NULL),
('Emma', 'Q', 'Martin', 212222222, '1982-10-14', '72 Maple St, Houston, TX', 'F', 31000, NULL, NULL),
('Ryan', 'A', 'White', 213333333, '1993-12-25', '442 Chestnut Dr, Bellaire, TX', 'M', 32000, NULL, NULL),
('Grace', 'B', 'Taylor', 214444444, '1984-08-08', '32 Oak St, Spring, TX', 'F', 47000, NULL, NULL),
('Alexander', 'K', 'King', 215555555, '1989-11-15', '19 Pine Dr, Stafford, TX', 'M', 44000, NULL, NULL),
('Evelyn', 'Y', 'Perez', 216666666, '1978-02-26', '500 Maple Ave, Bellaire, TX', 'F', 34000, NULL, NULL),
('Jason', 'F', 'Rivera', 217777777, '1980-07-05', '234 Elm St, Sugarland, TX', 'M', 36000, NULL, NULL),
('Victoria', 'U', 'Roberts', 218888888, '1976-05-16', '876 Cypress St, Houston, TX', 'F', 37000, NULL, NULL),
('Benjamin', 'W', 'Walker', 219999999, '1981-03-21', '555 Willow St, Spring, TX', 'M', 35000, NULL, NULL),
('Mia', 'D', 'Young', 220101010, '1992-11-07', '112 Spruce Ave, Stafford, TX', 'F', 48000, NULL, NULL),
('Lucas', 'C', 'Allen', 221111111, '1991-08-01', '22 Birch Rd, Bellaire, TX', 'M', 37000, NULL, NULL),
('Jack', 'T', 'Hernandez', 223333333, '1989-04-02', '765 Cedar St, Humble, TX', 'M', 34000, NULL, NULL),
('Sophia', 'Z', 'Flores', 224444444, '1987-01-11', '505 Lake Rd, Sugarland, TX', 'F', 36000, NULL, NULL),
('Daniel', 'J', 'Sanders', 225555555, '1985-05-22', '4 Oak Ave, Bellaire, TX', 'M', 42000, NULL, NULL),
('Madison', 'V', 'Morris', 226666666, '1980-09-09', '201 Pine Rd, Houston, TX', 'F', 31000, NULL, NULL),
('Henry', 'G', 'Powell', 227777777, '1993-10-25', '600 Maple St, Spring, TX', 'M', 39000, NULL, NULL),
('Amelia', 'R', 'Peterson', 228888888, '1990-08-20', '3 Elm Ave, Stafford, TX', 'F', 44000, NULL, NULL),
('Elijah', 'O', 'Bailey', 229999999, '1986-03-30', '123 Lake Dr, Bellaire, TX', 'M', 41000, NULL, NULL),
('Scarlett', 'X', 'Reed', 230101010, '1982-06-19', '77 Willow Ave, Houston, TX', 'F', 35000, NULL, NULL);
GO

-- Seed Additional Bulk Departments
INSERT INTO Department
VALUES
('Finance', 9, 201111111, '1999-05-19'),
('Operations', 10, 202222222, '2004-02-11'),
('Logistics', 11, 203333333, '2012-10-07'),
('Customer Service', 12, 204444444, '2013-03-23'),
('Legal', 13, 205555555, '2008-07-17'),
('Quality Assurance', 14, 206666666, '2006-11-30'),
('Compliance', 15, 207777777, '2015-12-01'),
('Product Development', 16, 208888888, '2018-06-05'),
('IT Support', 17, 209999999, '2020-09-18'),
('Data Analytics', 18, 210101010, '2019-04-29'),
('Procurement', 19, 211111111, '2014-01-14'),
('Innovation', 20, 212222222, '2011-08-27'),
('Sustainability', 21, 213333333, '2022-07-19'),
('Public Relations', 22, 214444444, '2009-03-10'),
('Research & Development', 23, 215555555, '2017-01-25'),
('Strategy', 24, 216666666, '2023-05-22'),
('Security', 25, 217777777, '2021-08-18'),
('Design', 26, 218888888, '2016-10-30'),
('Growth', 27, 219999999, '2015-12-25'),
('Legal Compliance', 28, 220101010, '2010-11-22'),
('Market Analysis', 29, 221111111, '2012-04-18'),
('Policy', 30, 222222222, '2005-06-13'),
('Communication', 31, 223333333, '2008-12-05'),
('Supplier Relations', 32, 224444444, '2007-02-10'),
('Engineering', 33, 225555555, '2018-09-21'),
('Testing', 34, 226666666, '2022-01-19'),
('Training', 35, 227777777, '2021-05-16'),
('Mentorship', 36, 228888888, '2023-03-01'),
('Social Responsibility', 37, 229999999, '2017-09-13'),
('Innovation Lab', 38, 230101010, '2022-10-28');
GO

-- Seed Additional Bulk Department Locations
INSERT INTO Dept_Locations
VALUES
(9, 'Houston'),
(10, 'Bellaire'),
(11, 'Spring'),
(12, 'Sugarland'),
(13, 'Stafford'),
(14, 'Houston'),
(15, 'Humble'),
(16, 'Bellaire'),
(17, 'Spring'),
(18, 'Sugarland'),
(19, 'Stafford'),
(20, 'Houston'),
(21, 'Bellaire'),
(22, 'Spring'),
(23, 'Sugarland'),
(24, 'Stafford'),
(25, 'Houston'),
(26, 'Bellaire'),
(27, 'Spring'),
(28, 'Sugarland'),
(29, 'Stafford'),
(30, 'Houston'),
(31, 'Bellaire'),
(32, 'Spring'),
(33, 'Sugarland'),
(34, 'Stafford'),
(35, 'Houston'),
(36, 'Bellaire'),
(37, 'Spring'),
(38, 'Sugarland');
GO

-- Seed Additional Bulk Projects
INSERT INTO Project
VALUES
('RevampA', 12, 'Houston', 9),
('SurveyB', 13, 'Bellaire', 10),
('UpgradeX', 14, 'Spring', 11),
('StreamlineY', 15, 'Sugarland', 12),
('OptimizeZ', 16, 'Stafford', 13),
('InnovateW', 17, 'Houston', 14),
('DigitalX', 18, 'Bellaire', 15),
('EvaluationQ', 19, 'Spring', 16),
('OutreachM', 21, 'Stafford', 18),
('CampaignL', 22, 'Houston', 19),
('ProgramN', 23, 'Bellaire', 20),
('PilotO', 24, 'Spring', 21),
('TestP', 25, 'Sugarland', 22),
('ScaleQ', 26, 'Stafford', 23),
('ExpandR', 27, 'Houston', 24),
('EngageS', 28, 'Bellaire', 25),
('AnalyzeT', 29, 'Spring', 26),
('ValidateU', 42, 'Sugarland', 27),
('ActivateV', 31, 'Stafford', 28),
('CommunicateW', 32, 'Houston', 29),
('RespondX', 33, 'Bellaire', 30),
('DevelopY', 34, 'Spring', 31),
('EnableZ', 35, 'Sugarland', 32),
('PrototypeA', 36, 'Stafford', 33),
('BetaTestB', 37, 'Houston', 34),
('InitiateC', 38, 'Bellaire', 35),
('TestD', 39, 'Spring', 36),
('ResearchE', 40, 'Sugarland', 37),
('TrialF', 41, 'Stafford', 38);
GO

-- Seed Additional Bulk Works_On records
INSERT INTO Works_On
VALUES
(201111111, 12, 20),
(202222222, 13, 15),
(203333333, 14, 30),
(204444444, 15, 25),
(205555555, 16, 35),
(206666666, 17, 40),
(207777777, 18, 10),
(208888888, 19, 20),
(209999999, 20, 15),
(210101010, 21, 25),
(211111111, 22, 30),
(212222222, 23, 35),
(213333333, 24, 40),
(214444444, 25, 10),
(215555555, 26, 15),
(216666666, 27, 30),
(217777777, 28, 25),
(218888888, 29, 40),
(219999999, 42, 10),
(220101010, 31, 35),
(221111111, 32, 30),
(222222222, 33, 25),
(223333333, 34, 40),
(224444444, 35, 10),
(225555555, 36, 15),
(226666666, 37, 30),
(227777777, 38, 20),
(228888888, 39, 10),
(229999999, 40, 35),
(230101010, 41, 40);
GO

-- Update additional circular relationships
UPDATE Employee SET Super_SSN = 333445555, Dno = 9 WHERE SSN = 201111111;
UPDATE Employee SET Super_SSN = 888665555, Dno = 10 WHERE SSN = 202222222;
UPDATE Employee SET Super_SSN = 987654321, Dno = 11 WHERE SSN = 203333333;
UPDATE Employee SET Super_SSN = 333445555, Dno = 12 WHERE SSN = 204444444;
UPDATE Employee SET Super_SSN = 987654321, Dno = 13 WHERE SSN = 205555555;
UPDATE Employee SET Super_SSN = 987987987, Dno = 14 WHERE SSN = 206666666;
UPDATE Employee SET Super_SSN = 987654321, Dno = 15 WHERE SSN = 207777777;
UPDATE Employee SET Super_SSN = 333445555, Dno = 16 WHERE SSN = 208888888;
UPDATE Employee SET Super_SSN = 888665555, Dno = 17 WHERE SSN = 209999999;
UPDATE Employee SET Super_SSN = 987654321, Dno = 18 WHERE SSN = 210101010;
UPDATE Employee SET Super_SSN = 987987987, Dno = 19 WHERE SSN = 211111111;
UPDATE Employee SET Super_SSN = 987654321, Dno = 20 WHERE SSN = 212222222;
UPDATE Employee SET Super_SSN = 333445555, Dno = 21 WHERE SSN = 213333333;
UPDATE Employee SET Super_SSN = 888665555, Dno = 22 WHERE SSN = 214444444;
UPDATE Employee SET Super_SSN = 987654321, Dno = 23 WHERE SSN = 215555555;
UPDATE Employee SET Super_SSN = 987987987, Dno = 24 WHERE SSN = 216666666;
UPDATE Employee SET Super_SSN = 987654321, Dno = 25 WHERE SSN = 217777777;
UPDATE Employee SET Super_SSN = 333445555, Dno = 26 WHERE SSN = 218888888;
UPDATE Employee SET Super_SSN = 888665555, Dno = 27 WHERE SSN = 219999999;
UPDATE Employee SET Super_SSN = 987654321, Dno = 28 WHERE SSN = 220101010;
UPDATE Employee SET Super_SSN = 987987987, Dno = 29 WHERE SSN = 221111111;
UPDATE Employee SET Super_SSN = 987654321, Dno = 30 WHERE SSN = 222222222;
UPDATE Employee SET Super_SSN = 333445555, Dno = 31 WHERE SSN = 223333333;
UPDATE Employee SET Super_SSN = 888665555, Dno = 32 WHERE SSN = 224444444;
UPDATE Employee SET Super_SSN = 987654321, Dno = 33 WHERE SSN = 225555555;
UPDATE Employee SET Super_SSN = 987987987, Dno = 34 WHERE SSN = 226666666;
UPDATE Employee SET Super_SSN = 987654321, Dno = 35 WHERE SSN = 227777777;
UPDATE Employee SET Super_SSN = 333445555, Dno = 36 WHERE SSN = 228888888;
UPDATE Employee SET Super_SSN = 888665555, Dno = 37 WHERE SSN = 229999999;
UPDATE Employee SET Super_SSN = 987654321, Dno = 38 WHERE SSN = 230101010;
GO

-- Blanket fallback fix for unassigned relation links
UPDATE Employee SET Super_SSN = 333445555, Dno = 5 WHERE Super_SSN IS NULL AND SSN != 888665555;
GO

-- Seed Supplier Table
INSERT INTO Supplier (SNum, SName, City, Status)
VALUES
(1, 'Global Tech Solutions', 'Houston', 1),
(2, 'Elite Office Supplies', 'Bellaire', 1),
(3, 'Nexus Industrial Parts', 'Sugarland', 2),
(4, 'Summit Logistics Corp', 'Stafford', 1),
(5, 'Vertex Tech Services', 'Spring', 3),
(6, 'Apex Hardware Suppliers', 'Houston', 1),
(7, 'Omni Office Furniture', 'Bellaire', 2),
(8, 'Prime Consulting', 'Stafford', 1);
GO

-- Seed Dependent Table
INSERT INTO Dependent (Essn, Dependent_name, Sex, Bdate, Relationship)
VALUES
(123456789, 'Alice Smith', 'F', '1990-05-14', 'Daughter'),
(123456789, 'Bob Smith', 'M', '1992-08-20', 'Son'),
(123456789, 'Elizabeth Smith', 'F', '1967-03-12', 'Spouse'),
(333445555, 'Alice Wong', 'F', '1986-04-18', 'Daughter'),
(333445555, 'Theodore Wong', 'M', '1983-10-25', 'Son'),
(333445555, 'Joy Wong', 'F', '1958-05-03', 'Spouse'),
(987654321, 'Abner Wallace', 'M', '1970-02-28', 'Spouse'),
(101010101, 'Sarah Johnson', 'F', '1977-09-12', 'Spouse'),
(101010101, 'Emily Johnson', 'F', '2005-04-05', 'Daughter'),
(102020202, 'David Thompson', 'M', '1979-12-01', 'Spouse'),
(103030303, 'James Williams', 'M', '2010-06-15', 'Son'),
(105050505, 'Emma Miller', 'F', '2012-07-22', 'Daughter'),
(105050505, 'Lucas Miller', 'M', '2015-11-30', 'Son'),
(201111111, 'Grace Clark', 'F', '1988-01-20', 'Spouse'),
(202222222, 'Chloe Nguyen', 'F', '2016-03-14', 'Daughter');
GO