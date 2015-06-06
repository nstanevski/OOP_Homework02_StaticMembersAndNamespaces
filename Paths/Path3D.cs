using System;
using System.Collections.Generic;
using Point3D;

namespace Paths
{
    class Path3D
    {
        private List<Point3D.Point3D> points;

        public Path3D(List<Point3D.Point3D> points)
        {
            if (points == null)
                points = new List<Point3D.Point3D>();
            this.points = points;
        }

        public Path3D():this(null)
        {

        }

        public List<Point3D.Point3D> Points 
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }
    }
}
