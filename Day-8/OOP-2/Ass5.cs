using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OOP_2
{

    interface IUser
    {
        void userlogin();
    }

    interface IAdminUser :IUser
    {
        void adminlogin();
       
    }


    class User: IUser
    {
        public void userlogin()
        {
            Console.WriteLine("user login through user system");
        }
    }
    class Admin: IAdminUser
    {
        public void userlogin()
        {
            Console.WriteLine("Admin login user  through Admin access");
        }

        public void adminlogin()
        {
            Console.WriteLine("Admin login");
        }
    }
    class Ass5
    {
        static void Main()
        {
           User u = new User();
           Admin ad = new Admin();


            Console.WriteLine("----User system----");
            u.userlogin();
            Console.WriteLine();
            Console.WriteLine("----Admin system---");
            ad.adminlogin();
            ad.userlogin();
            
            

        }
    }
}
