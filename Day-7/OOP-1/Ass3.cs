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

    public partial class Student
    {
        public string Course;
        public int Year;
        public Double GPA;

        public void SetAcademicInfo(string course, int year, Double gpa)
        {
            Course = course;
            Year = year;
            GPA = gpa;
        }


        public void DisplayCompleteInfo()
        {
            Console.WriteLine("Student Complete Information:");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Email:{Email}");
            Console.WriteLine($"Course:{Course}");
            Console.WriteLine($"Year:{Year}");
            Console.WriteLine($"GPA:{GPA}");
        }
    }
    internal class Ass3
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
