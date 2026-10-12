-- =========================================================================
-- SEED DATA: BASE CORE SEEDING
-- =========================================================================

-- 1. Seed Portal Admin
INSERT INTO Admin (username, password) VALUES ('admin', 'admin');
GO

-- 2. Seed Base Employees (null relations initially to bypass circular FK constraints)
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

-- 3. Seed Departments
INSERT INTO Department
VALUES
('Headquarters',1,888665555,'1981-06-19'),
('Administration',4,987654321,'1995-01-01'),
('Research',5,333445555,'1988-05-22');
GO

-- 4. Seed Department Locations
INSERT INTO Dept_Locations
VALUES
(1, 'Houston'),
(4, 'Stafford'),
(5, 'Bellaire'),
(5, 'Houston'),
(5, 'Sugarland');
GO

-- 5. Seed Base Projects
INSERT INTO Project
VALUES
('ProductX',1,'Bellaire',5),
('ProductY',2,'Sugarland',5),
('ProductZ',3,'Houston',5),
('Computerization',10,'Stafford',4),
('Reorganization',20,'Houston',1),
('Newbenefits',30,'Stafford',4);
GO

-- 6. Seed Base Works_On records
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

-- 7. Update circular employee supervisor and department IDs
UPDATE Employee SET Super_SSN = 333445555, Dno = 5 WHERE SSN = 123456789;
UPDATE Employee SET Super_SSN = 888665555, Dno = 5 WHERE SSN = 333445555;
UPDATE Employee SET Super_SSN = 333445555, Dno = 5 WHERE SSN = 453453453;
UPDATE Employee SET Super_SSN = 333445555, Dno = 5 WHERE SSN = 666884444;
UPDATE Employee SET Super_SSN = NULL, Dno = 1	   WHERE SSN = 888665555;
UPDATE Employee SET Super_SSN = 888665555, Dno = 4 WHERE SSN = 987654321;
UPDATE Employee SET Super_SSN = 987654321, Dno = 4 WHERE SSN = 987987987;
UPDATE Employee SET Super_SSN = 987654321, Dno = 4 WHERE SSN = 999887777;
GO
