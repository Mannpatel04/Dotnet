select * from Employee;

--Query-1
CREATE FUNCTION dbo.TotalExperience(@Date DATE)
RETURNS DECIMAL(10,1)
AS
BEGIN
    DECLARE @Experience DECIMAL(10,1);
    SET @Experience = DATEDIFF(MONTH, @Date, GETDATE()) / 12.0;
    RETURN @Experience;
END
GO

select EmployeeID, EmployeeName, dbo.TotalExperience(DateOfJoining) as Total_Experience from Employee


--Query-2
CREATE FUNCTION dbo.EmployeeDetail(@Did INT)
RETURNS TABLE
AS
RETURN(
     SELECT *,
             CASE 
                 when dbo.TotalExperience(DateOfJoining) >5 then 'YES'
                 else 'NO'
                 END as SeniorEmployee
                 FROM Employee WHERE DepartmentID = @Did
);
GO

select * from dbo.EmployeeDetail(1);

--Query-3
CREATE PROCEDURE AddEmployee
    @Name varchar(50),
    @Email varchar(50),
    @did INT ,
    @salary INT , 
    @Dateofjoining DATE
AS
BEGIN
   IF EXISTS (SELECT 1 FROM Employee WHERE Email = @Email)
   BEGIN
       PRINT'Email is Already Exist'
   END
   ELSE
   BEGIN
   INSERT INTO Employee 
   values ( @Name, @Email, @did, @salary, @Dateofjoining);
   END
END
GO


EXEC AddEmployee @name = 'Mann', @Email = 'patelmann655@gmail.com', @did = 1, @salary = 100000, @Dateofjoining = '2026-01-05';


--query-4

CREATE PROCEDURE salaryPaid
@startdate date,
@enddate date
AS
BEGIN
          SELECT DepartmentID,
          SUM(Salary) as totalsalary
          From Employee
          WHERE DateOfJoining between @startdate and @enddate
          group by DepartmentID
END
GO

exec salaryPaid  @StartDate = '2018-11-01', @EndDate = '2019-11-01'



--query-5
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName varchar(100),
    OrderAmount DECIMAL(10,2),
    OrderDate DATE 
);

CREATE TABLE OrderAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT,
    InsertedDate DATE,
    InsertedBy varchar(100)
);

create trigger order_To_Audit
on Orders
AFTER INSERT
AS
BEGIN
    INSERT INTO OrderAudit (OrderId, InsertedDate, InsertedBy)
    select
    OrderID, 
    getdate(),
    'New order'
    from inserted;
END;
GO  

insert into Orders values ('Mann', 4500.0, '2026-02-11');

select * from Orders;
select * from OrderAudit;


--query-6
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName varchar(50)
);

ALTER TABLE Orders
ADD ProductID INT;

insert into Products values (1, 'Laptop'), (2, 'Mouse');
insert into Orders (ProductID)values(1); 


create trigger ProtectProducts
ON Products
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Orders WHERE ProductID IN (SELECT ProductID FROM deleted))
    BEGIN
        PRINT 'STOP! You cannot delete this product. It has active orders.'
    END
    ELSE
    BEGIN
        DELETE FROM Products WHERE ProductID IN (SELECT ProductID FROM deleted);
        PRINT 'Product deleted successfully.';
    END
END
GO

DELETE FROM Products WHERE ProductID = 1;--this will print stop message.
DELETE FROM Products WHERE ProductID = 2; --this will delete because no one order mouse