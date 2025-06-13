//Task1


/*using System;
class Program
{
    static void Main(string[] args)
    {

        Book book1 = new Book("Atomic Habits", "James Clear", 2018);


        Console.WriteLine(book1.GetInfo());


        if (book1.IsPublishedRecently())
        {
            Console.WriteLine("This book was published recently.");
        }
        else
        {
            Console.WriteLine("This book is not published recently.");
        }
    }
}


public class Book
{
    public string Title { get; set; }
    public string Author   { get; set; }
    public int Year  { get; set; }

    public Book (string  title, string author, int year)
    {
        Title = title;
        Author = author;
        Year =  year;
    }

    public string  GetInfo()
    {
        return   $"Title: {Title}, Author: {Author}, Year: {Year}";
    }


    public bool  IsPublishedRecently()
    {
        return  Year  >  2010;
    }
}


*/







//Task2

/*
using System;

public class Circle
{

    private double radius;


    private const double PI = 3.14159;


    public Circle(double radius)
    {
        this.radius = radius;
    }


    public Circle()
    {
        radius = 0.0;
    }


    public void SetRadius(double radius)
    {
        this.radius = radius;
    }


    public double GetRadius()
    {
        return radius;
    }


    public double GetArea()
    {
        return PI * radius * radius;
    }


    public double GetDiameter()
    {
        return radius * 2;
    }


    public double GetCircumference()
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {

        Console.Write("Doiraning radiusini kiriting: ");
        double userRadius = double.Parse(Console.ReadLine());

        Circle circle = new Circle(userRadius);

        Console.WriteLine($"Radius: {circle.GetRadius()}");
        Console.WriteLine($"Yuza : {circle.GetArea()}");
        Console.WriteLine($"Diametr: {circle.GetDiameter()}");
        Console.WriteLine($"Perimetri : {circle.GetCircumference()}");

    }
}

*/






//Task3

/*
class program
{
    static void main()
    {
        Date date = new Date();


        Console.Write("Kunni kiriting >> ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Oyni kiirting >> ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Yilni kiriting >> ");
        int year = int.Parse(Console.ReadLine());
        date.SetDate(day, month, year);

        Console.WriteLine("Natija >> " + date);

    }
   

}




public class Date
{
    private int day;
    private int month;
    private int year;

    public Date() { }
    public Date(int day) => this.day = day;
    public Date(int day, int month)
    {
        this.day = day;
        this.month = month;
    }

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public void SetDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int GetDay() => day;
    public int GetMonth() => month;
    public int GetYear() => year;

    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year}";
    }
}

*/





//Task4


