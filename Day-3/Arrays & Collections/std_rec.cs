

class Student
{
    public int Id;
    public string Name;
    public int Marks;
}

class StudentArray
{
    Student[] students = new Student[3];

    public void AddStudents()
    {
        students[0] = new Student { Id = 1,Name = "Mann",Marks = 85 };
        students[1] = new Student { Id = 2, Name = "Ayush", Marks = 90 };
        students[2] = new Student { Id = 3, Name = "Niken", Marks = 78 };
    }

    public void SearchStudent(int id)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
            {
                Console.WriteLine($"Found (Array): {student.Name}");
                return;
            }
        }
        Console.WriteLine("Student not found (Array)");
    }

    public void UpdateStudent(int id, int newMarks)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
            {
                student.Marks = newMarks;
                Console.WriteLine($"Updated Marks (Array): {student.Marks}");
                return;
            }
        }
    }
}


class StudentList
{
    List<Student> students = new List<Student>();

    public void AddStudents()
    {
        students.Add(new Student { Id = 1,Name = "Mann",Marks = 85 });
        students.Add(new Student { Id = 2,Name = "Niken",Marks = 90 });
    }

    public void SearchStudent(int id)
    {
        Student student = students.Find(s => s.Id == id);
        if (student != null)
            Console.WriteLine($"Found (List): {student.Name}");
        else
            Console.WriteLine("Student not found (List)");
    }

    public void UpdateStudent(int id, int newMarks)
    {
        Student student = students.Find(s => s.Id == id);
        if (student != null)
        {
            student.Marks = newMarks;
            Console.WriteLine($"Updated Marks (List): {student.Marks}");
        }
    }
}


class StudentDictionary
{
    Dictionary<int, Student> students = new Dictionary<int, Student>();

    public void AddStudents()
    {
        students.Add(1, new Student { Id = 1,Name = "Ayush",Marks = 85 });
        students.Add(2, new Student { Id = 2,Name = "Mann",Marks = 90 });
    }

    public void SearchStudent(int id)
    {
        if (students.ContainsKey(id))
            Console.WriteLine($"Found (Dictionary): {students[id].Name}");
        else
            Console.WriteLine("Student not found (Dictionary)");
    }

    public void UpdateStudent(int id, int newMarks)
    {
        if (students.ContainsKey(id))
        {
            students[id].Marks = newMarks;
            Console.WriteLine($"Updated Marks (Dictionary): {students[id].Marks}");
        }
    }
}

class program
{
    public static void Main(string[] args)
    {
  
        StudentArray arrayExample = new StudentArray();
        arrayExample.AddStudents();
        arrayExample.SearchStudent(2);
        arrayExample.UpdateStudent(3, 82);

        Console.WriteLine();

  
        StudentList listExample = new StudentList();
        listExample.AddStudents();
        listExample.SearchStudent(1);
        listExample.UpdateStudent(1, 88);

        Console.WriteLine();

   
        StudentDictionary dictionaryExample = new StudentDictionary();
        dictionaryExample.AddStudents();
        dictionaryExample.SearchStudent(2);
        dictionaryExample.UpdateStudent(2, 95);
    

    }
}
