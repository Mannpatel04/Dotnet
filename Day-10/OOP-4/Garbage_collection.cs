using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{

    class G_collection
    {
        int id;

        public G_collection(int id)
        {
            this.id = id;
            Console.WriteLine($"Constructor called : Object {id} created");
        }

        ~G_collection()
        {
            Console.WriteLine($"Finalizer called : Object {id} destroyed");
        }
    }
    internal class Garbage_collection
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                G_collection d = new G_collection(i);
            }
            Console.WriteLine("");
            Console.WriteLine("Garbage collection forcefully....");

            GC.Collect();              
            GC.WaitForPendingFinalizers();
            Console.WriteLine("");

            Console.WriteLine("Garbage collected!!");
        }
    }
}
