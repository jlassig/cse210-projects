using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();


        Square square = new Square("blue", 10);
        Rectangle rectangle = new Rectangle("orange", 10,5);
        Circle circle = new Circle("yellow", 20);
        shapeList.Add(square);
        shapeList.Add(rectangle);        
        shapeList.Add(circle);

        foreach(Shape shape in shapeList)
        {
            WriteLine($"Color: {shape.GetColor()} -- Area: {shape.GetArea()}");
        }


       






    }
}