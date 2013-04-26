using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Euclidian3DSpace
{
    class Path
    {
        /*Path list*/       
        public List<Point3D> path = new List<Point3D>();

        /*Add point to path list*/
        public void AddPoint(Point3D aPath)
        {
            path.Add(aPath);
        }

        public List<Point3D> GetPath()
        {
            return path;
        }

        /*Print path*/
        public void PrintPath()
        {
            foreach (var i in path)
            {
                Console.WriteLine("x, y, z ({0},{1},{2})", i.x, i.y, i.z);
            }
        }

    }
}
