using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Euclidian3DSpace
{
    class TestPoint3DSaveLoad
    {
        static void Main()
        {
            /*create points*/
            Point3D p1 = new Point3D(2, 3, -1);
            Point3D p2 = new Point3D(2, 3, 0);
            Point3D p3 = new Point3D(4, 6, 14);
            Point3D p4 = new Point3D(9, 4, 7);
            Point3D p5 = new Point3D(2, 3, -1);
            Point3D p6 = new Point3D(22, -16, 6);


            /*calculate distance between points p1 and p2*/
            Console.WriteLine("Distance between points p1 and p2 is: {0}", Distance3D.CalculateDistance(p1, p2));
            Console.WriteLine("Distance between points p2 and p3 is: {0}", Distance3D.CalculateDistance(p2, p3));
            Console.WriteLine("Distance between points p5 and p6 is: {0}", Distance3D.CalculateDistance(p5, p6));
            Console.WriteLine();

            /*add points to path*/
            Path path1 = new Path();
            path1.AddPoint(p1);
            path1.AddPoint(p2);
            path1.AddPoint(p3);
            path1.AddPoint(p4);
            path1.AddPoint(p5);
            path1.AddPoint(p6);

            /*save Path*/
            PathStorage.SaveToFile(path1);

            /*load Path*/
            Path loadedPath = PathStorage.LoadPath();

            /*printing loaded path*/
            Console.WriteLine("path1 points");
            loadedPath.PrintPath();
        }
    }
}
