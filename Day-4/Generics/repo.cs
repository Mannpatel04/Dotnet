
using System;
using System.Collections.Generic;


class Repository<T>
{
     List<T> data = new List<T>();

    public void add(T item)
    {
       data.Add(item);
    }

    public List<T> GetAll()
    {
     return data;
    }
}

class student
{
    public int id;
    public string name;
}


class program
{
    static void Main()
    {
        Repository<student> studentrepo = new Repository<student>();

        studentrepo.add(new student
        {
            id = 1,
            name = "Mann"
        });
        studentrepo.add(new student
        {
            id = 2,
            name = "Ayush"
        });

        foreach (student s in studentrepo.GetAll())
        {
            Console.WriteLine(s.id + " - " + s.name);
        }

    }
}

