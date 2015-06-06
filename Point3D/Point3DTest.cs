using System;

/*
 * Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
 * Create appropriate constructors. Override ToString() to enable printing a 3D point.
 * Add a private static read-only field in the Point3D class to hold the start 
 * of the coordinate system – the point StartingPoint {0, 0, 0}. 
 * Add a static property to return the starting point.
 */

namespace Point3D
{
    class Point3DTest
    {
        static void Main()
        {
            Point3D p1 = new Point3D(1.3, 2.444, 3.5);
            Console.WriteLine("p1: " + p1);
            Point3D p2 = new Point3D();
            Console.WriteLine("p2: " + p2);
            //copy constructor:
            Point3D p3 = new Point3D(p1);
            Console.WriteLine("p3: " + p3);
            Console.WriteLine("Starting point: " + Point3D.StartingPoint);
        }
    }

}
