
namespace projectA
{
    public class login
    {
        public void log()
        {
            Console.WriteLine("Logging in projectA");
        }
    }

}

namespace projectB
{
    public class login
    {
        public void log()
        {
            Console.WriteLine("Logging in projectB");
        }
    }

}

class program
{
    static void Main(string[] args)
    {
        projectA.login lA = new projectA.login();
        projectB.login lB = new projectB.login();

        lA.log();
        lB.log();

        //Naming conflicts are resolved.


    }

}
