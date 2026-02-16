using System;
using System.Collections.Generic;
using System.Text;

namespace Day1.Model
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public DateOnly CreateDate {  get; set; }
        
    }

    class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Fees { get; set; }
        public int DurationInMonths { get; set; }

    }
}
                                         