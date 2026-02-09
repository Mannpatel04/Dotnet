CREATE TABLE Employee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Department VARCHAR(50),
    Salary DECIMAL(10,2) CHECK (Salary >= 0),
    DateOfJoining DATE NOT NULL
);


INSERT INTO Employee (FirstName, LastName, Email, Department, Salary, DateOfJoining)
VALUES
('John', 'Doe', 'john.doe1@company.com', 'IT', 60000.00, '2022-01-15'),
('Jane', 'Smith', 'jane.smith1@company.com', 'HR', 55000.00, '2021-08-10'),
('Michael', 'Brown', 'michael.brown1@company.com', 'Finance', 70000.00, '2020-03-25'),
('Emily', 'Davis', 'emily.davis1@company.com', 'Marketing', 52000.00, '2023-06-01'),
('David', 'Wilson', 'david.wilson1@company.com', 'IT', 65000.00, '2019-11-18'),
('Sarah', 'Johnson', 'sarah.johnson1@company.com', 'Sales', 58000.00, '2022-09-05'),
('Robert', 'Miller', 'robert.miller1@company.com', 'Finance', 72000.00, '2018-04-12'),
('Linda', 'Taylor', 'linda.taylor1@company.com', 'HR', 54000.00, '2020-07-19'),
('James', 'Anderson', 'james.anderson1@company.com', 'IT', 80000.00, '2017-02-28'),
('Patricia', 'Thomas', 'patricia.thomas1@company.com', 'Marketing', 56000.00, '2021-05-10'),
('Christopher', 'Jackson', 'chris.jackson1@company.com', 'IT', 75000.00, '2019-09-14'),
('Barbara', 'White', 'barbara.white1@company.com', 'Sales', 59000.00, '2020-12-01'),
('Daniel', 'Harris', 'daniel.harris1@company.com', 'Finance', 68000.00, '2022-03-22'),
('Susan', 'Martin', 'susan.martin1@company.com', 'HR', 53000.00, '2023-01-16'),
('Matthew', 'Thompson', 'matt.thompson1@company.com', 'IT', 82000.00, '2016-06-30'),
('Jessica', 'Garcia', 'jessica.garcia1@company.com', 'Marketing', 61000.00, '2021-10-08'),
('Anthony', 'Martinez', 'anthony.martinez1@company.com', 'Sales', 63000.00, '2019-04-27'),
('Karen', 'Robinson', 'karen.robinson1@company.com', 'HR', 57000.00, '2018-11-09'),
('Mark', 'Clark', 'mark.clark1@company.com', 'Finance', 90000.00, '2015-08-17'),
('Nancy', 'Lewis', 'nancy.lewis1@company.com', 'Marketing', 60000.00, '2022-06-11');

--query 1
SELECT TOP 5  FirstName, LastName, Salary FROM Employee
ORDER BY Salary DESC

--query 2
SELECT DISTINCT Department from Employee where Department LIKE 's%'

--query 3
select * from Employee 
where Department  IN ('HR', 'Finance', 'IT') and Salary > 50000

--query 4
--  Here we filter the data based on DeptName and Salary, our intention is to find the employee whoes department is sales
--  or whoes salary is greater than 75000. We don't want both to be true at the same time. we check for any of the
--  two conditions, if any one or both is true then we will include those rows in our result set.
select * 
from Employee
where Department = 'Sales' OR Salary >75000

--query 5
SELECT *
FROM Employee
WHERE Email LIKE '%' + FirstName + '%';

--query 6
select *
from Employee
ORDER BY DateOfJoining
OFFSET 5 ROWS
FETCH NEXT 4 ROWS ONLY

--query 7
select *
from Employee
where (Department  = 'IT' AND Salary > 60000) OR (Department  = 'HR' AND DateOfJoining < '2020-01-01');
  






