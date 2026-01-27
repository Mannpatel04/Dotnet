using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    public partial class Student
    {
        public string Name;
        public int Age;
        public string Email;

        public void SetPersonalInfo(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }

    
    internal class StudentInfo
    {
        static void Main()
        {
            Student st = new Student();

            st.SetPersonalInfo("Mann", 21, "patelmann655@gmail.com");
            st.SetAcademicInfo("Engineering", 4, 8.09);

            st.DisplayCompleteInfo();


        }


    }
}
