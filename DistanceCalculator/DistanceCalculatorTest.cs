using System;
using Point3D;

/*
 * Write a static class DistanceCalculator with a static method to calculate the distance 
 * between two points in the 3D space. Search in Internet how to calculate distance 
 * in the 3D Euclidian space.
 */

namespace DistanceCalculator
{
    class DistanceCalculatorTest
    {
        static void Main()
        {
            Point3D.Point3D p1 = new Point3D.Point3D(1, 1, 1);
            Point3D.Point3D p2 = new Point3D.Point3D();
            double dist = DistanceCalculator.CalcDistance3D(p1, p2);
            Console.WriteLine("Distance between point {0} and point {1} is {2:f8}", 
                p1.ToString(), p2.ToString(), dist);
        }
    }
}
