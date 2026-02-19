using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace Day1.Model
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
        [Required][MaxLength(50)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreateDate {  get; set; }
        public virtual List<Course> Courses { get; set; } = new List<Course>();
        
    }

    public class Course
    {
        [Key]
        public int Course_Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "Decimal(18,2)")] 
        public Decimal Fees { get; set; }
        public int DurationInMonths { get; set; }
        public virtual List<Batch> Batches { get; set; } = new List<Batch>();


        public virtual List<Student> Students { get; set; } = new List<Student>();
    }


    public class Trainer
    {
        [Key]
        public int Trainer_ID { get; set; }   
        [Required]
        public string Name { get; set; }
        public int Experience_Years { get; set; }
        public virtual List<Batch> Batches { get; set; } = new List<Batch>();   
    }

    public class Batch
    {
        [Key]
        public int ID { get; set; }
        public DateTime StartDate { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey(nameof(Trainer))]
        public int TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
