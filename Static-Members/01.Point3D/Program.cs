using System;
using Point;
class Program
{
    static void Main(string[] args)
    {
        var firstPoint = new Point3D(2, 5, 8);
        var secondPoint = new Point3D(3, 6, 9);
         Console.WriteLine("Starting Point : "+Point3D.startingPoint);
        Console.WriteLine("First Point: "+firstPoint.ToString());
        Distance.CalculateDistance(firstPoint,secondPoint);


    }
}
