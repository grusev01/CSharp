using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_4.Euclidian3DSpace
{
    static class PathStorage
    {
        /*save Path to file*/
        public static void SaveToFile(Path aPath)
        {
            using (StreamWriter writer = new StreamWriter(@"../../paths.txt"))
            {
                foreach (var i in aPath.GetPath())
                {
                    writer.WriteLine(String.Format("({0},{1},{2})", i.x, i.y, i.z));
                    writer.Flush();
                }
            }
        }

        /*load Path from file */
        public static Path LoadPath()
        {
            Path loaddedPath = new Path();

            try
            {
                using (StreamReader read = new StreamReader(@"../../paths.txt"))
                {
                    while (read.Peek() >= 0)
                    {
                        string str = read.ReadLine();
                        string[] splittedLine = str.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loaddedPath.AddPoint(new Point3D(int.Parse(splittedLine[0]), int.Parse(splittedLine[1]), int.Parse(splittedLine[2])));
                    }
                   
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (OutOfMemoryException om)
            {
                Console.WriteLine(om.Message);
            }
            return loaddedPath;
        }

    }
}
