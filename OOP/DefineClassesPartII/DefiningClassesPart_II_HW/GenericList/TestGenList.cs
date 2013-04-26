using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class TestGenList
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();

            /*add elements to list*/
            list.AddElement(5);
            list.AddElement(9);
            list.AddElement(34);
            list.AddElement(12);
            list.AddElement(34);
            list.AddElement(7);
            list.AddElement(9);

            Console.WriteLine(list.ToString());
            Console.WriteLine();

            /*insert elements*/
            list.InserElement(2, 10);
            list.InserElement(3, 111);
            list.InserElement(4, 222);

            Console.WriteLine(list.ToString());
            Console.WriteLine();

            /*indexer*/
            list[5] = 107;

            /*min max*/
            Console.WriteLine("Min is: {0}", list.Min());
            Console.WriteLine("Max is: {0}", list.Max());

            list.Clear();
            Console.WriteLine(list.ToString());
            
        }
    }
}
