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
                Console.WriteLine(" ");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Add Course");
                Console.WriteLine("3.Add Trainer");
                Console.WriteLine("4.Create Batch");
                Console.WriteLine(" ");

                Console.WriteLine("5.Show All Students");
                Console.WriteLine("6.Show All Courses");
                Console.WriteLine("7.Show Course With Student");
                Console.WriteLine("8.Show Trainer with Batches");
                Console.WriteLine("9.Enroll Student in Course");
                Console.WriteLine(" ");
                
               
                Console.WriteLine("10.Update Student");
                Console.WriteLine("11.Update Course");
                Console.WriteLine("12.Update Trainer");
                Console.WriteLine(" ");

                Console.WriteLine("13.Delete Student");
                Console.WriteLine("14.Delete Course");
                Console.WriteLine("15.Delete Trainer");
                Console.WriteLine(" ");

                Console.WriteLine("16.Eager Loading");
                Console.WriteLine("17.Lazy Loading");
                Console.WriteLine("18.Explicit Loading");
                Console.WriteLine(" ");

                Console.WriteLine("19.Show N+1 Problem");
                Console.WriteLine("20.Fix N+1 Problem");
                Console.WriteLine("");

                Console.WriteLine("21.Preformation of Detached");
                Console.WriteLine("22.Preformation of AsNoTracking");
                Console.WriteLine("23.Update The Attached Data");
                Console.WriteLine(" ");

                Console.WriteLine("24.Exit");
                Console.WriteLine(" ");



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
                        AddTrainer(context);
                        break;
                    case 4:
                        CreateBatch(context);
                        break;
                    case 6:
                        ShowAllStudent(context);
                        break;
                    case 7:
                        DisplayCourse(context);
                        break;
                    case 8:
                      DisplayTrainer(context);
                        break;
                    case 9:
                        EnrollStudent(context);
                        break;
                    case 10:
                       UpdateStudent(context);
                        break;
                    case 11:
                        UpdateCourse(context);
                        break;
                    case 12:
                        UpdateTrainer(context);
                        break;
                    case 13:
                        DeleteStudent(context);
                        break;
                    case 14:
                        DeleteCourse(context);
                        break;
                    case 15:
                        DeleteTrainer(context);
                        break;
                    case 16:
                        EagerLoading(context);
                        break;
                    case 17:
                        LazyLoading(context);
                        break;
                    case 18:
                        ExplicitLoading(context);
                        break;
                    case 19:
                        ShowNPlusOne(context);
                        break;
                    case 20:
                        FixNPlusOneUsingInclude(context);
                        break;
                    case 21:
                        PerformationOfDetached(context); 
                        break;
                    case 22:
                        PerformAsNoTracking(context);
                        break;
                    case 23:
                        UpdateAttachedData(context); 
                        break;
                    case 24:
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
        static void AddTrainer(AppDBContext Context)
        {
            Console.WriteLine("Enter Trainer Name:");
            var TrainerName = Console.ReadLine();

            Console.WriteLine("Enter Trainer Name:");
            var TrainerExperience = int.Parse(Console.ReadLine());

            Context.Trainers.Add(new Trainer {Name = TrainerName, Experience_Years = TrainerExperience});
            Context.SaveChanges();

            Console.WriteLine("\nTrainer Added");
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

         
            

            var DisplayTrainer = Context.Trainers.SelectMany(x => x.Batches, (t, x) => new {t.Name, x.ID, x.StartDate, t.Experience_Years});
            foreach (var T in DisplayTrainer)
            {
                Console.WriteLine($"\nTrainer Name:{T.Name} - Batch Id: {T.ID} - Experience In Years - {T.Experience_Years} - Batch Start date:{T.StartDate} ");
                Console.WriteLine(" ");
            }
        }
        static void UpdateStudent(AppDBContext Context)
        {
            Console.WriteLine("Add student ID to Update:");
            var StudentToUpdate = int.Parse(Console.ReadLine());    

            var WhichIdToUpdate = Context.Students.FirstOrDefault(x=> x.Student_Id ==  StudentToUpdate);

            Console.WriteLine("1.Update Name:");
            Console.WriteLine("2.Update Email:");

            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Updated Name:");
                    WhichIdToUpdate.Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter Updated Email:");
                    WhichIdToUpdate.Email = Console.ReadLine();
                    break;
                default:
                    WhichIdToUpdate.CreateDate = DateTime.Now;
                    break;
            }
            Console.WriteLine("\n update Successfully");
            Console.WriteLine(" ");

            Console.WriteLine("State before Changes:" + Context.Entry(WhichIdToUpdate).State);
            Context.SaveChanges();
            Console.WriteLine("\nState After Changes:" + Context.Entry(WhichIdToUpdate).State);
            Console.WriteLine(" ");

        }
        static void UpdateCourse(AppDBContext Context)
        {
            Console.WriteLine("Enter Course Id To Update:");
            var CourseToUpdate = int.Parse(Console.ReadLine());

            var WhichCourseToUpdate = Context.Courses.FirstOrDefault(x=> x.Course_Id == CourseToUpdate);

            Console.WriteLine("1.Update Title:");
            Console.WriteLine("2.Update Fees:");
            Console.WriteLine("3.Update Email:");

            var option = int.Parse(Console.ReadLine());


            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter New Title':");
                    WhichCourseToUpdate.Title = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter Fess You Want to Update: ");
                    WhichCourseToUpdate.Fees = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter New Duration of Course In Months");
                    WhichCourseToUpdate.DurationInMonths = int.Parse(Console.ReadLine());
                    break;
            }
 
            Console.WriteLine("State before Changes:"+ Context.Entry(WhichCourseToUpdate).State);
            Context.SaveChanges();
            Console.WriteLine("State After Changes:" + Context.Entry(WhichCourseToUpdate).State);


            

        }
        static void UpdateTrainer(AppDBContext Context)
        {
            Console.WriteLine("Enter Traine Id To Update:");
            var TrainerToUpdate = int.Parse(Console.ReadLine());

            var WhichTrainerToUpdate = Context.Trainers.FirstOrDefault(x=> x.Trainer_ID == TrainerToUpdate);

            Console.WriteLine("1.Update Trainer Name:");
            Console.WriteLine("2.Update years of Experience:");

            var option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter New Name:");
                    WhichTrainerToUpdate.Name = Console.ReadLine();
                   break;
                case 2:
                    Console.WriteLine("Enter New Experience:");
                    WhichTrainerToUpdate.Experience_Years = int.Parse(Console.ReadLine());
                    break;    
            }
            Console.WriteLine("State before Changes:" + Context.Entry(WhichTrainerToUpdate).State);
            Context.SaveChanges();
            Console.WriteLine("State After Changes:" + Context.Entry(WhichTrainerToUpdate).State);


        }
        static void DeleteStudent(AppDBContext Context)
        {
            Console.WriteLine("Enter Student Id to Delete:");
            var StudentToDelete = int.Parse(Console.ReadLine());

            var WhichStudentToDelete = Context.Students.FirstOrDefault(x=> x.Student_Id == StudentToDelete);

            Context.Students.Remove(WhichStudentToDelete);

            Console.WriteLine("State before Changes:" + Context.Entry(WhichStudentToDelete).State);
            Context.SaveChanges();
            Console.WriteLine("State After Changes:" + Context.Entry(WhichStudentToDelete).State);


        }
        static void DeleteCourse(AppDBContext Context)
        {
            Console.WriteLine("Enter Course Id to Delete:");
            var CourseToDelete = int.Parse(Console.ReadLine());

            var WhichCourseToDelete = Context.Students.FirstOrDefault(x => x.Student_Id == CourseToDelete);

            Context.Students.Remove(WhichCourseToDelete);

            Console.WriteLine("State before Changes:" + Context.Entry(WhichCourseToDelete).State);
            Context.SaveChanges();
            Console.WriteLine("State After Changes:" + Context.Entry(WhichCourseToDelete).State);
        }
        static void DeleteTrainer(AppDBContext Context)
        {
            Console.WriteLine("Enter Trainer Id to Delete:");
            var TrainerToDelete = int.Parse(Console.ReadLine());

            var WhichTrainerToDelete = Context.Students.FirstOrDefault(x => x.Student_Id == TrainerToDelete);

            Context.Students.Remove(WhichTrainerToDelete);

            Console.WriteLine("State before Changes:" + Context.Entry(WhichTrainerToDelete).State);
            Context.SaveChanges();
            Console.WriteLine("State After Changes:" + Context.Entry(WhichTrainerToDelete).State);
        }
        static void EagerLoading(AppDBContext Context)
        {
            var studentCourse = Context.Students.Include(x => x.Courses).ThenInclude(x => x.Batches).ToList();

            foreach (var sc in studentCourse)
            {
                Console.WriteLine($"\nStudent Name: {sc.Name}");
                if (sc.Courses.Count != 0)
                {
                    foreach (var c in sc.Courses)
                    {
                        Console.WriteLine($"\nCourse Title:{c.Title} ");

                        if (c.Batches != null)
                        {
                            foreach (var  b in c.Batches)
                            {
                                Console.WriteLine($"\nBatch ID:{b.ID} - Batch Start Date:{b.StartDate}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Batch!!");
                        }

                    }
   
                }
                else
                {
                    Console.WriteLine("No Course!!");
                }
               
            }
        }
        static void ExplicitLoading(AppDBContext Context)
        {
            Console.WriteLine("Enter Student Id:");
            int studentId = int.Parse(Console.ReadLine());

            var student = Context.Students.FirstOrDefault(x => x.Student_Id == studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
           
            Context.Entry(student).Collection(s => s.Courses).Load();

            Console.WriteLine($"\nStudent Name: {student.Name}");

            foreach (var course in student.Courses)
            {
                Console.WriteLine($"Course: {course.Title}");

                Context.Entry(course).Collection(c => c.Batches).Load();

                foreach (var batch in course.Batches)
                {
                    Console.WriteLine($"Batch Id: {batch.ID} - Start Date: {batch.StartDate}");
                }
            }
        }
        static void LazyLoading(AppDBContext Context)
        {
            var studentsCourse = Context.Students.ToList();
            foreach (var s in studentsCourse)
            {
                Console.WriteLine($"Student: {s.Name}");

                foreach (var c in s.Courses)
                {
                    Console.WriteLine($"Course: {c.Title}");
                }
            }
        }
        static void ShowNPlusOne(AppDBContext Context)
        {
            var students = Context.Students.ToList(); 

            foreach (var s in students)
            {
                Console.WriteLine($"Student: {s.Name}");

                foreach (var c in s.Courses)
                {
                    Console.WriteLine($"Course: {c.Title}");
                }
            }
        }
        static void FixNPlusOneUsingInclude(AppDBContext Context)
        {
            var students = Context.Students
                                  .Include(s => s.Courses)
                                  .ToList();   

            foreach (var s in students)
            {
                Console.WriteLine($"Student: {s.Name}");

                foreach (var c in s.Courses)
                {
                    Console.WriteLine($"Course: {c.Title}");
                }
            }
        }
       static void PerformationOfDetached(AppDBContext context)
        {
            var student = context.Students.FirstOrDefault();
            Console.WriteLine($"Student Name Before Updation: {student.Name}");

            context.Entry(student).State = EntityState.Detached;

            Console.Write("Enter student's new name: ");
            student.Name = Console.ReadLine();
            context.SaveChanges();

            student = context.Students.FirstOrDefault();
            Console.WriteLine($"Student Name After Updation: {student.Name}");

        }
       static void PerformAsNoTracking(AppDBContext context)
        {
            Console.WriteLine("AsNoTracking...");
            var students = context.Students.AsNoTracking();

            var student1 = students.FirstOrDefault();
            var student2 = students.FirstOrDefault(s => s.Student_Id == 2);
            Console.WriteLine($"Student 1 Name Before Updation: {student1.Name}");
            Console.WriteLine($"Student 2 Name Before Updation: {student2.Name}");


            Console.Write("Enter new Name For Student 1: ");
            student1.Name = Console.ReadLine();
            Console.Write("Enter new Name For Student 2: ");
            student2.Name = Console.ReadLine();

            context.SaveChanges();

            student1 = context.Students.FirstOrDefault();
            student2 = context.Students.FirstOrDefault(s => s.Student_Id == 2);
            Console.WriteLine($"Student 1 Name After Updation: {student1.Name}");
            Console.WriteLine($"Student 2 Name After Updation: {student2.Name}");
        }
       static void UpdateAttachedData(AppDBContext context)
        {
            var student = context.Students.AsNoTracking().FirstOrDefault();

            Console.WriteLine($"Student Name Before Updation: {student.Name}");


            Console.Write("Enter new Name For Student: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Before: " + context.Entry(student).State);
            context.Attach(student);
       

            Console.WriteLine("After: " + context.Entry(student).State);
            context.SaveChanges();

            var student1 = context.Students.FirstOrDefault();
            Console.WriteLine($"Student 1 Name After Updation: {student1.Name}");
        }
    }
}       