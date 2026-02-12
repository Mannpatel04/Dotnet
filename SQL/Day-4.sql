use [Training Day-4]


create table Department (DepartmentID int IDENTITY(1,1) primary key,
                         DepartmentName varchar(50) UNIQUE NOT NULL
              );

create table Employees (EmployeeID int IDENTITY(1,1) primary key,
                        Name varchar(50) NOT NULL,
                        salary int check (salary> 15000),
                        HireDate date,
                        DepartmentID int,
                        foreign key (DepartmentID) references Department(DepartmentID)
              );
             
--Alter Table & Constraint
--1.
alter table Employees 
add Email varchar(50) unique;

--2.
alter table Employees
add IsActive int default 1;

--3.
alter table Employees
alter column salary decimal(10,2) ;

--4.
alter table Employees
add constraint chk_HireDate check(HireDate <= CURRENT_DATE);

--DML
--1.
insert into Employees (Name,salary,HireDate,DepartmentID,Email)
values 
 ('Mann', 100000, '2026-01-05',1, 'mann@bacancy.com'),
 ('Ayush', 80000, '2026-01-09',2, 'Ayush@bacancy.com'),
 ('Devam,', 59000, '2026-01-10',1, 'Devam@bacancy.com'),
 ('Krunal', 63000, '2026-01-09',1, 'krunal@bacancy.com'),
 ('Niken', 54000, '2026-01-18',2, 'Niken@bacancy.com'),
 ('Raj', 43000, '2026-01-23',2,'Raj@bacancy.com'),
 ('Ashish', 33000, '2026-01-31',3, 'Ashish@bacancy.com' ),
 ('Het', 20000, '2026-01-07',3, 'Het@bacancy.com')

insert into Department values ('Dotnet');
insert into Department values ('Devops');
insert into Department values ('JAVA');

--2.
update Employees
set salary = salary *1.05
where DepartmentID = 1;

--3.
update Employees
set IsActive = 0
where HireDate> '2026- 01-18'

--4.
delete from Employees
where IsActive = 0

--5.
update Employees
set DepartmentID =1
where DepartmentID = 3

--Joins

--1.
Select * 
from Employees as e
join Department as d
on e.DepartmentID  = d.DepartmentID

--2.
select *
from Department d
left join  Employees as e
on e.DepartmentID  = d.DepartmentID
where EmployeeID is null;

--3.
select  d.DepartmentName, max(salary) as Highestsalary
from Department as d
join  Employees as e
on e.DepartmentID  = d.DepartmentID
group by DepartmentName
























