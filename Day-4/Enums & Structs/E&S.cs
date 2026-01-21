using System;

enum orderStatus
{
    Pending = 1,
    Processing = 2,
    Shipped = 3,
    Delivered = 4,
    Cancelled = 5
}

struct coordinates
{ 
    public int X;
    public int Y;

    public coordinates(int x, int y)
    {
        X = x;
        Y = y;
    }

     public void display()
    {
        Console.WriteLine("The coordinates are:");
        Console.WriteLine("X:" + X); 
        Console.WriteLine("Y:" + Y);
    }
}


struct pointingStruct { 
    public int X;
}

class pointingClass
{ 
    public int X;
}

class program
{ 
     static void Main()
    {
        //Enum
        orderStatus status = orderStatus.Pending;
        Console.WriteLine("Numeric value:"+ (int)status);
        Console.WriteLine("Status:"+ status);

        //Struct
        coordinates points = new coordinates(7, 11);
        points.display();

        //comparision
        pointingStruct ps1 = new pointingStruct { X = 10};
        pointingStruct ps2 = ps1;
        ps2.X = 20;
        Console.WriteLine(ps1.X);

        pointingClass pc1 = new pointingClass { X = 10};
        pointingClass pc2 = pc1;
        pc2.X = 20;
        Console.WriteLine(pc1.X);

    }
}

