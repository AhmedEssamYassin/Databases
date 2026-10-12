# Databases: Theory, Design & Engineering

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey.svg)](https://microsoft.com)
[![SQL Server](https://img.shields.io/badge/RDBMS-Microsoft%20SQL%20Server-CC292B?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![.NET](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white)](https://docs.microsoft.com/dotnet/csharp/)
[![LaTeX](https://img.shields.io/badge/Documentation-XeLaTeX%20%2F%20TikZ-008080?logo=latex&logoColor=white)](https://www.latex-project.org/)

Relational database theory, T-SQL programming and administration notes, TikZ-rendered Entity-Relationship Diagrams (ERD/EERD), and C# WinForms lab assignments built for the Database Systems course at the Faculty of Engineering, Cairo University (CMP 2024).

---

## Table of Contents

- [Overview](#overview)
- [Repository Structure](#repository-structure)
- [Database Systems Reference Guide (`Database ITI`)](#database-systems-reference-guide-database-iti)
  - [Topics Covered](#topics-covered)
  - [Visual ERD/EERD Components](#visual-erdeerd-components)
- [Lab Projects (`FECU CMP2024 Labs`)](#lab-projects-fecu-cmp2024-labs)
  - [Lab 1: Enter Movie / Actors Form](#lab-1-enter-movie--actors-form)
  - [Lab 2: Course Registration App](#lab-2-course-registration-app)
  - [Lab 3: Database Creation, Tables, Constraints & Queries](#lab-3-database-creation-tables-constraints--queries)
  - [Lab 4 & 5: Accessing SQL Server from C# Application](#lab-4--5-accessing-sql-server-from-c-application)
  - [Lab 6: CompanyDB Management System](#lab-6-companydb-management-system)
- [Prerequisites & Development Setup](#prerequisites--development-setup)
  - [Database Tools](#database-tools)
  - [Application Development](#application-development)
  - [Compiling LaTeX Documentation](#compiling-latex-documentation)
- [Author & License](#author--license)

---

## Overview

The repository has two parts:

- `Database ITI`: a reference manual and T-SQL guide in LaTeX, over 1,700 lines. It covers database lifecycles, ERD/EERD modeling (Chen notation), relational mapping, normalization (1NF through BCNF), T-SQL querying, window functions, indexing, concurrency, and SQL Server administration.
- `FECU CMP2024 Labs`: a progressive series of lab assignments in C# and SQL Server. They start with basic WinForms state management and direct ADO.NET queries, and build up to a layered client using stored procedures, `MaterialSkin.2`, and local RDLC reporting.

---

## Repository Structure

```text
Databases/
├── Database ITI/          # Reference manual and ERD components
├── FECU CMP2024 Labs/     # Database lab assignments
├── LICENSE
└── README.md
```

---

## Database Systems Reference Guide (`Database ITI`)

[`Database ITI/`](./Database%20ITI/) contains the source and compiled PDF ([`DatabaseITI.pdf`](./Database%20ITI/DatabaseITI.pdf)) for an 11-part database engineering manual built with XeLaTeX.

### Topics Covered

| Part | Title | Topics |
|---|---|---|
| I | Introduction to Database Systems | DBMS vs. DB vs. DBS, file-based system limitations, database taxonomy (RDBMS, NoSQL, Distributed, Cloud, Time-Series), Database Life Cycle (DBLC). |
| II | Database Design (ERD & EERD) | Chen notation, strong vs. weak entities, simple/composite/multivalued/derived attributes, relationship degrees (unary to n-ary), cardinality and participation constraints, specialization/generalization, disjointness and completeness. Includes full Company and Vehicle case studies. |
| III | Relational Mapping | 7-step ERD-to-relational mapping algorithm (regular entities, weak entities, 1:1, 1:M, M:N, recursive self-references, n-ary), 3 EERD supertype/subtype mapping strategies, and full T-SQL schema translation with foreign key constraints and circular reference handling. |
| IV | Database Normalization | Insertion, deletion, and update anomalies; functional dependencies (full, partial, transitive); normal forms: 1NF, 2NF, 3NF, and Boyce-Codd Normal Form (BCNF). |
| V | Relational Query Languages & T-SQL | DDL, DML, DQL filtering/projection, joins (Inner, Left, Right, Full, Cross, Self-Join), `GROUP BY` and `HAVING`, logical query execution order, `CASE` and `IIF`, type casting (`CAST`, `CONVERT`, `TRY_PARSE`), and date arithmetic. |
| VI | Advanced Query Techniques | Scalar/correlated subqueries, set operations (`UNION`, `UNION ALL`, `INTERSECT`, `EXCEPT`), `TOP (N) WITH TIES`, `SELECT INTO`, window functions (`ROW_NUMBER`, `RANK`, `DENSE_RANK`, `NTILE`, `LAG`, `LEAD`, `FIRST_VALUE`, `LAST_VALUE`), grouping extensions (`ROLLUP`, `CUBE`, `GROUPING SETS`), and `PIVOT`/`UNPIVOT`. |
| VII | Constraints & Data Integrity | Domain and referential integrity, cascading actions (`CASCADE`, `SET NULL`, `SET DEFAULT`, `NO ACTION`), `DELETE` vs. `TRUNCATE` vs. `DROP`, rules, bound defaults, user-defined types, and persisted computed columns. |
| VIII | Database Schemas & Objects | Schema namespaces (`dbo`, custom schemas), security boundaries, and synonyms. |
| IX | Programming in T-SQL | Local and table variables, dynamic SQL with parameterized `sp_executesql`, control flow (`IF-ELSE`, `WHILE`), error handling (`BEGIN TRY...BEGIN CATCH`, `THROW`), ACID transactions, UDFs (Scalar, Inline TVF, Multi-statement TVF), Views (encrypted, indexed/materialized, `WITH CHECK OPTION`), Stored Procedures, DML Triggers (`AFTER`, `INSTEAD OF`, `inserted`/`deleted` virtual tables), and `MERGE`. |
| X | Indexes & Performance Optimization | B+ Tree structures, Table Scan vs. Index Seek vs. Index Scan, Clustered vs. Non-Clustered indexes, covering indexes (`INCLUDE`), and the cursor lifecycle. |
| XI | Backup, Recovery & Integration | Recovery models (Simple, Full, Bulk-Logged), backups (Full, Differential, Transaction Log), copy-on-write Database Snapshots, `IDENTITY` cache and gap resolution, `BULK INSERT`, XML querying (`FOR XML`, `OPENXML`), and SQL CLR integration. |

### Visual ERD/EERD Components

[`erd_components.pdf`](./Database%20ITI/erd_components.pdf) (built from [`erd_components.tex`](./Database%20ITI/erd_components.tex) and [`erdstyles.sty`](./Database%20ITI/erdstyles.sty)) defines reusable TikZ primitives for:
- **Entities**: Regular, Weak, Associative
- **Attributes**: Simple, Composite, Derived, Multivalued, Key, Partial Key
- **Relationships**: Identifying, Recursive, High-degree
- **Constraints**: Total (double line), Partial (single line), `(min, max)` notation
- **Specialization/Generalization**: Disjoint (`d`), Overlapping (`o`), Total (double circle), Partial (single line)

---

## Lab Projects (`FECU CMP2024 Labs`)

Lab coursework for the CMP 2024 Database Systems class at Cairo University.

### [Lab 1: Enter Movie / Actors Form](./FECU%20CMP2024%20Labs/Lab-01/)
WinForms basics, input validation, and passing state between forms.
- Toggles UI controls dynamically based on selected movie genre.
- Validates user input with error dialogs.
- Passes state between `MovieForm` (Form 1) and `ActorsForm` (Form 2), using both modal and non-modal navigation.
- Syncs actor collections across forms into a `DataGridView`.

### [Lab 2: Course Registration App](./FECU%20CMP2024%20Labs/Lab-02/)
Authentication flow, cascading controls, and registration constraints.
- Login screen with password masking and show/hide toggle.
- Cascading `ComboBox` controls: picking a course updates valid time slots and credit hours.
- Blocks duplicate registrations for the same course.
- Tracks total enrolled credit hours in real time.

### [Lab 3: Database Creation, Tables, Constraints & Queries](./FECU%20CMP2024%20Labs/Lab-03/)
SQL Server schema creation, constraints, and analytical queries.
- Defines the `FacultyDBMS` schema (`Student`, `Course`, `Enrollment`, `Assignment`, `Transcript`).
- Enforces Primary Key and Foreign Key constraints.
- Includes SQL Server Database Diagrams for visual schema inspection.
- Seeds test data and runs aggregate queries (e.g., student average grades).

### [Lab 4 & 5: Accessing SQL Server from C# Application](./FECU%20CMP2024%20Labs/Lab-04-05/)
Direct ADO.NET database operations from a WinForms client.
- Provisions the database via `CompanyDBLab_04_05.sql`.
- Manages `SqlConnection`, `SqlCommand`, and connection strings.
- Implements CRUD operations:
  - Insert new employees and update employee details.
  - Filter employees by department.
  - Project headcount (`COUNT` aggregation).
  - Cascading project deletion.

### [Lab 6: CompanyDB Management System](./FECU%20CMP2024%20Labs/Lab-06/)
Layered client application with modular SQL deployment, stored procedures, and local reporting.
- **Database Tier**: Split into `schema/`, `stored_procedures/`, and `seeds/`, deployed via `master_setup.sql` and a PowerShell runner (`deploy.ps1`).
- **Data Access Tier (`DBManager.cs`)**: Parameterized queries to prevent SQL injection.
- **Business Logic Tier (`Controller.cs`)**: Encapsulated controller methods.
- **Presentation Tier**: Built on `MaterialSkin.2` with light and dark mode support.
- **Reporting**: Embedded Microsoft ReportViewer (`.rdlc`) with typed reports for employees and department statistics.

---

## Prerequisites & Development Setup

### Database Tools
- **SQL Server**: 2019 or newer (Developer or Express).
- **Management GUI**: [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) or [Azure Data Studio](https://learn.microsoft.com/en-us/azure-data-studio/download-azure-data-studio).

### Application Development
- **IDE**: [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload installed.
- **Target Framework**: .NET Framework 4.8.
- **NuGet Dependencies** (restored on build):
  - `MaterialSkin.2` (`v2.3.1`)
  - `Microsoft.ReportingServices.ReportViewerControl.Winforms` (`v150.1652.0`)

#### Quick Run: Lab 6 Application
```powershell
# 1. Deploy the database (ServerInstance defaults to ".")
cd "FECU CMP2024 Labs/Lab-06/CompanyDB"
powershell -ExecutionPolicy Bypass -File .\deploy.ps1

# 2. Build the client (SDK-style project; dotnet build or msbuild in Developer Prompt)
cd "../DBapplication"
dotnet build
```

### Compiling LaTeX Documentation
Building the PDFs in [`Database ITI/`](./Database%20ITI/) requires:
- **Engine**: [XeLaTeX](https://tug.org/xetex/) or [LuaLaTeX](https://lualatex.org/) (needed for `fontspec`).
- **Fonts**: Segoe UI and Consolas (standard on Windows), plus Montserrat (optional).

```bash
cd "Database ITI"
# Run twice to resolve table of contents and page numbers
xelatex DatabaseITI.tex
xelatex DatabaseITI.tex
xelatex erd_components.tex
```

---

## Author & License

- **Author**: Ahmed Essam Yassin ([@AhmedEssamYassin](https://github.com/AhmedEssamYassin))
- **Affiliation**: Faculty of Engineering, Cairo University (FECU CMP 2024)
- **License**: [MIT License](LICENSE)