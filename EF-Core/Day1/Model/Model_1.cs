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
        [Required]
        public string? Email { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreateDate {  get; set; }
        public List<Course> courses { get; set; }
        
    }

    class Course
    {
        [Key]
        public int Course_Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "Decimal")] 
        public Decimal Fees { get; set; }
        public int DurationInMonths { get; set; }
        public List<Batch> Batches { get; set; }  
        public List<Student> Students { get; set; }

    }


    class Trainer
    {
        [Key]
        public int Trainer_ID { get; set; }   
        [Required]
        public string Name { get; set; }
        public int Experience_Years { get; set; }
        public List<Batch> Batches {  get; set; }
    }

    class Batch
    {
        [Key]
        public int ID { get; set; }
        public DateTime startDate { get; set; }
        [ForeignKey("Course")]
        public int CourseID {  get; set; }
        [ForeignKey("Trainer")]
        public int TraineID { get; set; }
        public Course course { get; set; }
        public Trainer trainer { get; set; }

    }

}
