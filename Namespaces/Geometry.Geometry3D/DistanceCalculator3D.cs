using System;


namespace Geometry.Geometry3D
{
    public static class DistanceCalculator3D
    {
        public static double CalcDistance3D(Point3D p1, Point3D p2)
        {
            return Math.Sqrt(
                (p1.X - p2.X) * (p1.X - p2.X) +
                (p1.Y - p2.Y) * (p1.Y - p2.Y) +
                (p1.Z - p2.Z) * (p1.Z - p2.Z));
        }
    }
}
