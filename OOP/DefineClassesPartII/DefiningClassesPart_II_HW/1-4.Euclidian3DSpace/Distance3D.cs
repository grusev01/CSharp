using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Euclidian3DSpace
{
    public static class Distance3D
    {
        /* calculate the distance */
        public static double CalculateDistance(Point3D start, Point3D end)
        {
            return Math.Sqrt(Math.Abs(((end.x - start.x) * (end.x - start.x)) + ((end.y - start.y) * (end.y - start.y)) + ((end.z - start.z) * (end.z - start.z))));
        }
    }
}
