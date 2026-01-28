using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{

    interface INotification
    {
        void EmailNotification();
        void SMSNitofication();
    }

    class Mobile : INotification
    {
        public void EmailNotification()
        {
            Console.WriteLine("Notifiation of Email");
        }

        public void SMSNitofication()
        {
            Console.WriteLine("SMS Notification");
        }

    }

    class Ass3
    {
        static void Main()
        {
            Mobile mb = new Mobile();
            mb.EmailNotification();
            mb.SMSNitofication();
        }
    }
}
