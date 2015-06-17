using System;
using Point;
static class Distance
{
    public static void CalculateDistance(Point3D firstPoint, Point3D secondPoint)
    {
        double distance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2) + Math.Pow(firstPoint.Z - secondPoint.Z, 2));
        Console.WriteLine("Distance between two 3D points is: "+distance);
    }
}
