-- Lab 3: Database Setup, Tables, Constraints, Data & Queries

-- Create database if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'FacultyDBMS')
BEGIN
    CREATE DATABASE FacultyDBMS;
END
GO

USE FacultyDBMS;
GO

-- Drop children first to avoid FK conflicts
DROP TABLE IF EXISTS Transcript;
DROP TABLE IF EXISTS Assignment;
DROP TABLE IF EXISTS Enrollment;
DROP TABLE IF EXISTS Course;
DROP TABLE IF EXISTS Student;
GO

-- Table creation with named PK/FK and CHECK constraints
CREATE TABLE Student
(
    StudentID INT CONSTRAINT PK_Student PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Age INT CONSTRAINT CK_Student_Age CHECK (Age >= 0 AND Age <= 120),
    Gender CHAR(1) CONSTRAINT CK_Student_Gender CHECK (Gender IN ('M', 'F'))
);

CREATE TABLE Course
(
    CourseID INT CONSTRAINT PK_Course PRIMARY KEY,
    CourseName VARCHAR(50) NOT NULL,
    Instructor VARCHAR(50) NOT NULL
);

CREATE TABLE Enrollment
(
    EnrollmentID INT CONSTRAINT PK_Enrollment PRIMARY KEY,
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    Grade INT CONSTRAINT CK_Enrollment_Grade CHECK (Grade >= 0 AND Grade <= 100),
    
    CONSTRAINT FK_Enrollment_Student FOREIGN KEY (StudentID) 
        REFERENCES Student(StudentID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Enrollment_Course FOREIGN KEY (CourseID) 
        REFERENCES Course(CourseID) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Assignment
(
    AssignmentID INT CONSTRAINT PK_Assignment PRIMARY KEY,
    AssignmentName VARCHAR(50) NOT NULL,
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    Deadline DATE NOT NULL,
    
    CONSTRAINT FK_Assignment_Student FOREIGN KEY (StudentID) 
        REFERENCES Student(StudentID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Assignment_Course FOREIGN KEY (CourseID) 
        REFERENCES Course(CourseID) ON DELETE CASCADE ON UPDATE CASCADE
);

-- The assignment says to add Transcript via the Diagram UI,
-- but the DDL is included here for completeness.
CREATE TABLE Transcript
(
    TranscriptID INT CONSTRAINT PK_Transcript PRIMARY KEY,
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    Grade INT CONSTRAINT CK_Transcript_Grade CHECK (Grade >= 0 AND Grade <= 100),
    
    CONSTRAINT FK_Transcript_Student FOREIGN KEY (StudentID) 
        REFERENCES Student(StudentID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Transcript_Course FOREIGN KEY (CourseID) 
        REFERENCES Course(CourseID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Data insertion
INSERT INTO Student (StudentID, FirstName, LastName, Age, Gender)
VALUES
    (1, 'Ahmed', 'Yassin', 22, 'M'),
    (2, 'Esraa', 'Hassan', 20, 'F'),
    (3, 'Ahmed', 'Faris', 21, 'M'),
    (4, 'Mohamed', 'Ibrahim', 23, 'M'),
    (5, 'Ahmed', 'Wael', 25, 'M');

INSERT INTO Course (CourseID, CourseName, Instructor)
VALUES
    (2031, 'Algorithms', 'Ahmed Hamdy'),
    (1035, 'Ordinary Differential Equations', 'Ehab'),
    (1032, 'Data Structures', 'Ahmed Hamdy'),
    (2040, 'Data Bases', 'Lydia'),
    (1033, 'Object Oriented Programming', 'Howida');

INSERT INTO Enrollment (EnrollmentID, StudentID, CourseID, Grade)
VALUES
    (1, 1, 2031, 85),
    (2, 2, 1035, 90),
    (3, 3, 1032, 75),
    (4, 4, 2040, 88),
    (5, 5, 1033, 92);

INSERT INTO Assignment (AssignmentID, AssignmentName, StudentID, CourseID, Deadline)
VALUES 
    (122, 'Solving Linear Equations', 1, 1035, '2024-10-30'),
    (135, 'Data Base Creation', 4, 2040, '2024-11-03'),
    (215, 'Inheritance', 2, 1033, '2024-11-07'),
    (187, 'Stacks and Queues', 3, 1032, '2024-11-10'),
    (336, 'DFS on Graphs', 5, 1032, '2024-11-30');

INSERT INTO Transcript (TranscriptID, StudentID, CourseID, Grade)
VALUES
    (1, 1, 2031, 85),
    (2, 2, 1035, 90),
    (3, 3, 1032, 75),
    (4, 4, 2040, 88),
    (5, 5, 1033, 92);
GO

--DML
--ALTER TABLE Enrollment ADD CONSTRAINT FK_StudentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID) ON DELETE CASCADE ON UPDATE CASCADE
--ALTER TABLE Enrollment ADD CONSTRAINT FK_CourseID FOREIGN KEY (CourseID) REFERENCES Course(CourseID) ON DELETE CASCADE ON UPDATE CASCADE

-- Queries (DQL)

-- Get the names of all students
SELECT FirstName, LastName FROM Student;

-- Alternative: concatenated full name
SELECT FirstName + ' ' + LastName AS FullName FROM Student;

-- Bonus: average grade per student (LEFT JOIN to include students with no grades)
SELECT 
    s.StudentID,
    s.FirstName + ' ' + s.LastName AS FullName, 
    AVG(t.Grade) AS AverageGrade 
FROM 
    Student s 
LEFT JOIN 
    Transcript t ON s.StudentID = t.StudentID 
GROUP BY 
    s.StudentID, s.FirstName, s.LastName;
