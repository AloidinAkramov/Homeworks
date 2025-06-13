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
