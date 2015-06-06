using System;
using System.Collections.Generic;
using Point3D;

/* Create a class Path3D to hold a sequence of points in 3D space. 
 * Create a static class Storage with static methods to save and load paths from a text file. 
 * Use a file format of your choice. 
 * Ensure you close correctly all files with the "using" statement.
 */

namespace Paths
{
    class PathsTest
    {
        static void Main()
        {
            List<Point3D.Point3D> pointsList = new List<Point3D.Point3D>();
            pointsList.Add(new Point3D.Point3D(1, 1, 1));
            pointsList.Add(new Point3D.Point3D(2, 3, 4));
            pointsList.Add(new Point3D.Point3D(0.2, 3.1, 4.3));
            pointsList.Add(new Point3D.Point3D(Point3D.Point3D.StartingPoint));

            Path3D path3D = new Path3D(pointsList);

            string storeFile = @"../../path3d.txt";

            Console.WriteLine("Storing path to file: " + storeFile);
            Storage.Save(storeFile, path3D);

            string loadFile = @"../../path3dLoad.txt";
            Console.WriteLine("Loading path from file: " + loadFile);
            Storage.Load(loadFile, path3D);
            foreach (var pnt3D in path3D.Points)
            {
                Console.WriteLine(pnt3D.ToString());
            }
        }
    }
}
