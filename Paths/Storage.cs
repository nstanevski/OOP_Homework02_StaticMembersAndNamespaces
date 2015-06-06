using System;
using System.Collections.Generic;
using System.IO;
using Point3D;

namespace Paths
{
    static class Storage
    {
        public static void Save(string filePath, Path3D path)
        {
            if (path == null)
                return;
            using (var writer = new StreamWriter(filePath))
            {
                string line;
                foreach (Point3D.Point3D pnt3d in path.Points)
                {
                    line = string.Format("{0} {1} {2}", pnt3d.X, pnt3d.Y, pnt3d.Z);
                    writer.WriteLine(line);
                }
            }
        }

        public static void Load(string filePath, Path3D path)
        {
            if (path == null)
                path = new Path3D();
            path.Points.Clear();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                double x=0.0, y=0.0, z=0.0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] items = line.Split();
                    try{
                        x = double.Parse(items[0]);
                        y = double.Parse(items[1]);
                        z = double.Parse(items[2]);
                    }catch(Exception ex){
                        Console.WriteLine("Error while parsing input file");
                        Console.Error.WriteLine(ex.Message);
                    }
                    Point3D.Point3D pnt3d = new Point3D.Point3D(x, y, z);
                    path.Points.Add(pnt3d);
                }
            } 
        }
    }
}
