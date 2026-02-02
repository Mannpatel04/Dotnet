using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{
    internal class Task_5
    {
        static void Main()
        {
            var student = new[]
            {
                new {Rollno = 1, Name = "Mann", Marks = 95},
                new {Rollno = 2, Name = "Ayush", Marks = 67 },
                new {Rollno = 3, Name = "smit",  Marks = 76},
                new {Rollno= 4, Name = "Yash",  Marks = 35},
                new {Rollno = 5, Name = "Niken",  Marks = 97}
            };

            var Result = student.Select(s => new
            {
                s.Marks,
                s.Name,
                Result  = s.Marks >= 40 ? "pass" : "Fail"
            });

            foreach (var s in Result)
            {
                Console.WriteLine($"{s.Name}:- {s.Marks}:{s.Result}");
            }

        }
    }
}


//Explaination:-
//in this program select is use for the apply condition for the transform the data in something new, 
//For each student, create a new object with only the data I want.