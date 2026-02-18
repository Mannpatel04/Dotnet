
using EF_Core_Demo.Data;
using Day1.Model;
using EF_Core_Demo.CRUD;

class day1
{
    static void Main(string[] args)
    {

        using var Context = new AppDBContext();

        StudentCourseCRUD SCCrud  = new StudentCourseCRUD();
        SCCrud.StartStudentCourseCRUD(Context);
        


    }

    
}
