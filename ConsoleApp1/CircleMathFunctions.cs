using System;

class MathFunctionCircleArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Circle Radius: ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double area = pi * (radius * radius);
        double circumference = 2 * pi * radius;

        Console.WriteLine("Area = " + area);
        Console.WriteLine("Circle Radius: ");
        Console.WriteLine("Circumference = " + circumference);
        Console.ReadKey();
      
    }
}

