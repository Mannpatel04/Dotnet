
CREATE TABLE Department (
    DepartmentID INT  IDENTITY(1,1),
    DeptName VARCHAR(50) NOT NULL UNIQUE
);


CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    DepartmentID INT ,
    Salary DECIMAL(10,2) ,
    DateOfJoining DATE NOT NULL
);

CREATE TABLE Skill (
    SkillID INT PRIMARY KEY IDENTITY(1,1),
    SkillName VARCHAR(50) NOT NULL UNIQUE
);


CREATE TABLE EmployeeSkill (
    EmployeeID INT ,
    SkillID INT ,
    
);

INSERT INTO Department (DeptName) VALUES 
('IT'), ('HR'), ('Finance'), ('Marketing'), ('Sales');

INSERT INTO Employee (EmployeeName, Email, DepartmentID, Salary, DateOfJoining)
VALUES
('John Doe', 'john.doe@company.com', 1, 60000.00, '2022-01-15'),
('Jane Smith', 'jane.smith@company.com', 2, 55000.00, '2021-08-10'),
('Michael Brown', 'michael.brown@company.com', 3, 70000.00, '2020-03-25'),
('Emily Davis', 'emily.davis@company.com', 4, 52000.00, '2023-06-01'),
('David Wilson', 'david.wilson@company.com', 1, 65000.00, '2019-11-18'),
('Sarah Johnson', 'sarah.johnson@company.com', 5, 58000.00, '2022-09-05'),
('Robert Miller', 'robert.miller@company.com', 3, 72000.00, '2018-04-12'),
('Linda Taylor', 'linda.taylor@company.com', 2, 54000.00, '2020-07-19'),
('James Anderson', 'james.anderson@company.com', 1, 80000.00, '2017-02-28'),
('Patricia Thomas', 'patricia.thomas@company.com', 4, 56000.00, '2021-05-10'),
('Christopher Jackson', 'chris.jackson@company.com', 1, 75000.00, '2019-09-14'),
('Barbara White', 'barbara.white@company.com', 5, 59000.00, '2020-12-01'),
('Daniel Harris', 'daniel.harris@company.com', 3, 68000.00, '2022-03-22'),
('Susan Martin', 'susan.martin@company.com', 2, 53000.00, '2023-01-16'),
('Matthew Thompson', 'matt.thompson@company.com', 1, 82000.00, '2016-06-30'),
('Jessica Garcia', 'jessica.garcia@company.com', 4, 61000.00, '2021-10-08'),
('Anthony Martinez', 'anthony.martinez@company.com', 5, 63000.00, '2019-04-27'),
('Karen Robinson', 'karen.robinson@company.com', 2, 57000.00, '2018-11-09'),
('Mark Clark', 'mark.clark@company.com', 3, 90000.00, '2015-08-17'),
('Nancy Lewis', 'nancy.lewis@company.com', 4, 60000.00, '2022-06-11'),
('Steven Walker', 'steven.walker@company.com', 1, 67000.00, '2023-03-14'),
('Paul Young', 'paul.young@company.com', 5, 54000.00, '2021-11-20'),
('Michelle King', 'michelle.king@company.com', 2, 59500.00, '2020-05-05'),
('Kevin Wright', 'kevin.wright@company.com', 3, 71000.00, '2019-01-30'),
('Lisa Scott', 'lisa.scott@company.com', 4, 58000.00, '2022-08-22');

INSERT INTO Skill (SkillName) VALUES 
('SQL'), 
('Python'), 
('Project Management'), 
('Financial Analysis'), 
('Public Speaking'), 
('Tableau'), 
('Negotiation'), 
('Excel Mastery');

INSERT INTO EmployeeSkill (EmployeeID, SkillID) VALUES 
(1, 1), (1, 2), (1, 3), 
(2, 5), 
(3, 4), (3, 8), 
(4, 3), (4, 5), 
(5, 1), 
(7, 4), (7, 6), 
(9, 1), (9, 2), (9, 6), 
(11, 1), (11, 8), 
(19, 4), (19, 7), 
(21, 2),
(24, 4), (24, 1);

--Query 1
CREATE VIEW vw_EmployeeBasicInfo AS
select
      EmployeeID, 
      EmployeeName, 
      DepartmentID
from Employee

select * from vw_EmployeeBasicInfo


--Query 2
WITH MyCTE As(
    select * 
    from Employee
    where DepartmentID = '3'--finance id is 3.
 )
 
 select * from MyCTE;


 --Query 3
 SELECT EmployeeID, EmployeeName
INTO #HRTempTable
FROM Employee
WHERE DepartmentID = 2; 

select * from #HRTempTable;

--query 4
SELECT E.EmployeeName,  COUNT(ES.SkillID) AS SkillCount
FROM Employee E
JOIN EmployeeSkill ES ON E.EmployeeID = ES.EmployeeID
GROUP BY E.EmployeeID, E.EmployeeName
HAVING COUNT(ES.SkillID) > 1;


--Question 5
--The Primary Key is the "Unique ID" for a table. It ensures that every single row can be identified without any confusion.and it cannot be null.
--EmployeeID in the Employee table.

--Foreign key is the "Link" between two tables, It is a column in one table that points to the Primary Key of another table.
--Example: DepartmentID in the Employee table "points back" to the DepartmentID in the Department table.

--A Unique Key ensures that all values in a column are different from one another, similar to a Primary Key, but with more flexibility. you can have a multiple unique key in the table, null value allowed
--Example: An Email column should be unique so two employees don't share the same login.