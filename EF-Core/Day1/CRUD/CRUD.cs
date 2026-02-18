using Day1.Model;
using EF_Core_Demo.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core_Demo.CRUD
{
    internal class CRUD
    {
        public void StartCRUD(AppDBContext context)
        {

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("STUDENT MENU");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Add Course");
                Console.WriteLine("3.Show All Students");
                Console.WriteLine("4.Show All Courses");
                Console.WriteLine("5.Enroll Student in Course");
                Console.WriteLine("6.Create Batch");
                Console.WriteLine("7.Show Course With Student");
                Console.WriteLine("8.Show Trainer with Batches");
                Console.WriteLine("9.Exit");



                var menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        AddStudent(context);
                        break;
                    case 2:
                        AddCourse(context);
                        break;
                    case 3:
                        ShowAllStudent(context);
                        break;
                    case 4:
                        ShowAllCourse(context);
                        break;
                    case 5:
                        EnrollStudent(context);
                        break;
                    case 6:
                        CreateBatch(context);
                        break;
                    case 7:
                        DisplayCourse(context);
                        break;
                    case 8:
                        DisplayTrainer(context);
                        break;
                    case 9:
                        exit = true;
                        break;
                }
            }


        }
        static void AddStudent(AppDBContext Context)
        {

            Console.WriteLine("Enter Student Name: ");
            var Name = Console.ReadLine();

            Console.WriteLine("Enter Student Email : ");
            var Email = Console.ReadLine();

            var date = DateTime.Now;

            Context.Students.Add(new Student { Name = Name, Email = Email, CreateDate = date });
            Context.SaveChanges();

            Console.WriteLine("Student Added!!");

        }
        static void AddCourse(AppDBContext Context)
        {

            Console.WriteLine("Enter Course Title: ");
            var Coursetitle = Console.ReadLine();

            Console.WriteLine("Enter Fees to Enrolled:");
            var Fees = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Duration In Months:");
            var Duration = int.Parse(Console.ReadLine());

            Context.Courses.Add(new Course { Title = Coursetitle, Fees = Fees, DurationInMonths = Duration });
            Context.SaveChanges();

            Console.WriteLine("Course Added!!");
        }
        static void ShowAllStudent(AppDBContext context)
        {
            var Students = context.Students.ToList();
            foreach (var p in Students)
            {
                Console.WriteLine($"\nName: {p.Name} - Email: {p.Email} - Created Date: {p.CreateDate} ");
                Console.WriteLine(" ");
            }
        }
        static void ShowAllCourse(AppDBContext Context)
        {
            var Course = Context.Courses.ToList();
            foreach (var C in Course)
            {
                Console.WriteLine($"\nTitle: {C.Title} - Fees:{C.Fees} - Course Duration: {C.DurationInMonths} Months ");
                Console.WriteLine(" ");
            }
        }
        static void EnrollStudent(AppDBContext Context)
        {
            Console.WriteLine("Enter Student ID to Enroll:");
            var StudentID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Course ID :");
            var CourseID = int.Parse(Console.ReadLine());

            var course = Context.Courses.FirstOrDefault(x => x.Course_Id == CourseID);
            var student = Context.Students.FirstOrDefault(x => x.Student_Id == StudentID);

            if (course != null)
            {
                student.Courses.Add(course);
                Context.SaveChanges();
            }
            else { Console.WriteLine("not exist"); }
        }
        static void CreateBatch(AppDBContext context)
        {
            Console.WriteLine("Enter Course ID: ");
            int courseId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Trainer ID: ");
            int trainerId = int.Parse(Console.ReadLine());

            var course = context.Courses.Find(courseId);
            var trainer = context.Trainers.Find(trainerId);

            if (course == null)
            {
                Console.WriteLine("Course not found");
                return;
            }

            if (trainer == null)
            {
                Console.WriteLine("Trainer not found");
                return;
            }

            var batch = new Batch
            {
                CourseId = courseId,
                TrainerId = trainerId,
                Course = course,
                Trainer = trainer,
                StartDate = DateTime.Now
            };

            context.Batches.Add(batch);
            context.SaveChanges();

            Console.WriteLine("Batch Created Successfully");
        } 

            
        

        static void DisplayCourse(AppDBContext Context)
        {
            var CourseWithStudents = Context.Courses.SelectMany(x => x.Students, (c, x) => new { c.Title, x.Name });
            foreach (var sc in CourseWithStudents)
            {
                Console.WriteLine($"\nCourse Title: {sc.Title} - Student Name: {sc.Name}");
                Console.WriteLine(" ");
            }
        }
        static void DisplayTrainer(AppDBContext Context)
        {
            var DisplayTrainer = Context.Trainers.SelectMany(x => x.Batches, (t, x) => new {t.Name, x.ID, x.StartDate });
            foreach (var T in DisplayTrainer)
            {
                Console.WriteLine($"\nTrainer Name:{T.Name} - Batch Id: {T.ID} - Batch Start date:{T.StartDate}");
                Console.WriteLine(" ");
            }
        }
    }
}       