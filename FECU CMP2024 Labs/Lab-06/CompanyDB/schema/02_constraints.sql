-- =========================================================================
-- SCHEMA: CIRCULAR CONSTRAINTS & ALTERATIONS
-- =========================================================================

-- Bind Dno foreign key on Employee back to Department table (resolves creation order circular dependency)
ALTER TABLE Employee ADD FOREIGN KEY (Dno) REFERENCES Department(Dnumber);
GO
