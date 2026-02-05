namespace Linq_3
{

    class Employee
    {
        public int EmployeeId;
        public string Name;
        public string Department;
        public int Salary;
        public int DepartmentId;
    }

    class Student
    {
        public int RollNo;
        public string Name;
        public int Marks;
    }

    class Order
    {
        public int OrderID;
        public string CustomerName;
        public List<OrderItem> OrderItems;
    }

    class OrderItem
    {
        public string ProductName;
        public int ProductPrice;
    }

    class Department
    {
        public int DepartmentId;
        public string DepartmentName;
    }

    class Product
    {
        public int ProductId;
        public string ProductName;
    }
}
