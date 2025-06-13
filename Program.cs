using System;
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


