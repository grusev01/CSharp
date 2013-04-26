using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixT
{
    class TestMatrixTClass
    {
        static void Main()
        { 
            double[,] first = { { 4, 6, 8  }, { 12, 10, 1}, { 15, 41, 22} };
            double[,] second = { { 1, 7, 4}, { 76, 13, 11 }, { 5, 4, 1 } };

            /*create matrix1 and matrix2*/
            Matrix<double> matrix1 = new Matrix<double>(first);
            Matrix<double> matrix2 = new Matrix<double>(second);
            

            if (matrix1)
            {
                Console.WriteLine("No zero in matrix");
            }
            else Console.WriteLine("There is one or more zeros");

            Console.WriteLine();

            Console.WriteLine("Sum or matrix1 and matrix2");
            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine("Subtract or matrix2 from matrix1");
            Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine("Multipying marix1 and matrix2");
            Console.WriteLine(matrix1 * matrix2);


        }
    }
}
