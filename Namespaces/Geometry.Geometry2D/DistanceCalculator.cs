using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Geometry2D
{
    static class DistanceCalculator
    {
        public static double CalcDistance3D(Point2D p1, Point2D p2)
        {
            return Math.Sqrt(
                (p1.X - p2.X) * (p1.X - p2.X) +
                (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}
