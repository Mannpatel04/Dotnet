using System;
namespace ValueVsReference
{
    class Person{
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 10;
            Person myPerson = new Person { Name = "Alice" };

            Console.WriteLine("BEFORE");
            Console.WriteLine($"Value Type (int): {myNumber}");
            Console.WriteLine($"Reference Type (Person Name): {myPerson.Name}");

            ModifyValue(myNumber);
            ModifyReference(myPerson);
           
            Console.WriteLine("AFTER");
            Console.WriteLine($"Value Type (int): {myNumber}");
        }

        static void ModifyValue(int x){
            x = 50;
        }

        static void ModifyReference(Person p){
            p.Name = "Bob";
        }
    }
}