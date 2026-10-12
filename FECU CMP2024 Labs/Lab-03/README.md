# Lab 3 — Database Creation, Tables, Constraints, Diagrams & Queries

## Requirements

### 1. Create the following tables

**Student**
| StudentID | FirstName | LastName | Age | Gender |
|-----------|-----------|----------|-----|--------|

**Course**
| CourseID | CourseName | Instructor |
|----------|------------|------------|

**Enrollment**
| EnrollmentID | StudentID | CourseID | Grade |
|--------------|-----------|----------|-------|

**Assignment**
| AssignmentID | AssignmentName | StudentID | CourseID | Deadline |
|--------------|----------------|-----------|----------|----------|

### 2. Define Primary Key constraints

- `StudentID` → Student
- `CourseID` → Course
- `EnrollmentID` → Enrollment
- `AssignmentID` → Assignment

### 3. Define Foreign Key constraints

- `StudentID` in Enrollment → Student
- `CourseID` in Enrollment → Course
- `StudentID` in Assignment → Student
- `CourseID` in Assignment → Course

### 4. Create a Database Diagram

- Visual representation of the schema with relationships.
- **Add a new table through the diagram:**

  **Transcript:** TranscriptID (PK), StudentID (FK → Student), CourseID (FK → Course), Grade

### 5. Fill each table with at least 5 rows

### 6. Write queries

- Get the names of all students.
- **Bonus:** Average grade for each student across all courses.

---

## Grading Criteria

| Points | Item |
|--------|------|
| 1 | Create the database |
| 2 | Create tables with proper types and null specification |
| 1 | Define PKs |
| 2 | Define FKs with proper update/delete rules |
| 1 | Create Database Diagram |
| 1 | Add Transcript table through diagram |
| 1 | Fill the database |
| 1 | Simple Queries |
| 0.25 | Bonus query |
