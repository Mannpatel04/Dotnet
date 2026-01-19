
string myName = "Mann Badreshiya";
DateTime currentDate = DateTime.Now;
String machineName = Environment.MachineName;

Console.WriteLine($"Name:{myName}");
Console.WriteLine($"Date:{currentDate}");
Console.WriteLine($"Machine Name:{machineName}");

Console.WriteLine("Please enter a message:");
int userInput = Convert.ToInt32(Console.readLine());
Console.WriteLine($" You entered:{userInput}");