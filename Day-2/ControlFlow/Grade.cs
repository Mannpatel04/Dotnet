using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());
        char grade;

        if (marks >= 90)
        {
            grade = 'A';
        }
        else if (marks >= 80)
        {
            grade = 'B';
        }
        else if (marks >= 70)
        {
            grade = 'C';
        }
        else if (marks >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        Console.WriteLine($"Grade: {grade}");

        switch (marks)
        {
            case 90:
                {
                    grade = 'A';
                }
                break;
            case 80:
                {
                    grade = 'B';
                }
                break;
            case 70:
                {
                    grade = 'C';
                }
                break;
            case 60:
                {
                    grade = 'D';
                }
                break;
            default:
                {
                   grade = 'F';
                }
                break;
        }
        Console.WriteLine($"Grade from switch: {grade}");


    }
}

