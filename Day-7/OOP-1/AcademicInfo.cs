using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
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
}
