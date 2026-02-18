using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace Day1.Model
{
    class Student
    {
        [Key]
        public int Student_Id { get; set; }
        [Required][MaxLength(50)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreateDate {  get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        
    }

    class Course
    {
        [Key]
        public int Course_Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "Decimal(18,2)")] 
        public Decimal Fees { get; set; }
        public int DurationInMonths { get; set; }
        public List<Batch> Batches { get; set; } = new List<Batch>();


        public List<Student> Students { get; set; } = new List<Student>();
    }


    class Trainer
    {
        [Key]
        public int Trainer_ID { get; set; }   
        [Required]
        public string Name { get; set; }
        public int Experience_Years { get; set; }
        public List<Batch> Batches { get; set; } = new List<Batch>();   
    }

    class Batch
    {
        [Key]
        public int ID { get; set; }
        public DateTime StartDate { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey(nameof(Trainer))]
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
