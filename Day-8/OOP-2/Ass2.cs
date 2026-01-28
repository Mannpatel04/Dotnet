using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    class AppConfig
    {
        private string AppName;
        private string Version;
        private DateTime CreateDate;


        public string appname
        {
            get { return AppName; }
        }

        public String version
        {
            get { return Version; }

        }

        public DateTime createdate
        {
           get { return CreateDate; }
        }


        public AppConfig(string appname,  string version, DateTime createdate) { 
            AppName = appname;  
            Version = version;
            CreateDate = createdate;
        }
           
    }
    class Ass2
    {
        static void Main()
        {
            AppConfig ac = new AppConfig("Temperature Monitor", "1.0",DateTime.Now);
            Console.WriteLine(ac.appname);
            Console.WriteLine(ac.version);
            Console.WriteLine(ac.createdate);

        }
    }
}
