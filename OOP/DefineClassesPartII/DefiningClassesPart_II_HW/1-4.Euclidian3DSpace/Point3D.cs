using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Euclidian3DSpace
{   
    public struct Point3D 
    {
        /*point O*/
        private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);

        /*point coordinats*/
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        /*struct consructor*/
        public Point3D(int x, int y, int z)
            : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /*print point*/
        public override string ToString()
        {
            return string.Format("Point coordinats x, y, z {{0}, {1}, {2}}", x, y, z);
        }

        /*print point O*/
        public static Point3D GetZeroPoint()
        {
            return zeroPoint;
        }
    }
    
}
