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
        public  void StartCRUD(AppDBContext context)
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

                    case 9:
                        exit = true;
                        break;
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
                //Console.WriteLine("Enter Student to Enroll:");
                //var name = Console.ReadLine();

                var StudentADD = Context.Students.Find(1);
                var ToCourse = Context.courses.Find(1);
                StudentADD.courses.Add(ToCourse);


            }
            static void CreateBatch(AppDBContext Context)
            {

            }
            static void DisplayCourse(AppDBContext Context)
            {

            }
            static void DisplayTrainer(AppDBContext Context)
            {

            }

        }
    }
}
     
    











