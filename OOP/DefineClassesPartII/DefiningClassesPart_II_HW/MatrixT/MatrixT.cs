using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixT
{
    public class Matrix<T> where T:
        struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private const int DefaultSize = 8;
        public int row { get; private set; }
        public int col { get; private set; }
        private T[,] matrix;


        /*Matrix constructors*/
        public Matrix()
        {
            matrix = new T[DefaultSize, DefaultSize];
        }

        public Matrix(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentException("Negative value for row or col is invalid.");
            }
            else 
            {
                this.row = row;
                this.col = col;
                matrix = new T[row, col];
            }
        }

        public Matrix(T[,] matrix) 
        {
            this.matrix = matrix;
            row = matrix.GetLength(0);
            col = matrix.GetLength(1);
        }
        

        /*indxer*/
        public T this[int aRow, int aCol]
        {
            get
            {
                if (row < aRow || col < aCol || aRow < 0 || aCol < 0) throw new ArgumentException("Invalid index");
                else return matrix[aRow, aCol];
            }
            set
            {
                if (row < aRow || col < aCol || aRow < 0 || aCol < 0) throw new ArgumentException("Invalid index");
                else matrix[aRow, aCol] = value;
            }
        }

        /*implement operator +*/
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.row == second.row && first.col == second.col)
            {
                Matrix<T> tmpMatrix = new Matrix<T>(first.row, first.col);
                for (int i = 0; i < first.row; i++)
                {
                    for (int j = 0; j < first.col; j++)
                    {
                        checked
                        {
                            tmpMatrix[i, j] = (dynamic)first[i, j] + second[i, j];
                        }
                    }
                }
                return tmpMatrix;
            }
            else throw new MatrixException("Matrix need to be with same rows and cols.");
        }

        /*implement operator -*/
        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.row == second.row && first.col == second.col)
            {
                Matrix<T> tempArr = new Matrix<T>(first.row, first.col);
                for (int i = 0; i < first.row; i++)
                {
                    for (int j = 0; j < first.col; j++)
                    {
                        checked
                        {
                            tempArr[i, j] = (dynamic)first[i, j] - second[i, j];
                        }
                    }
                }
                return tempArr;
            }
            else throw new MatrixException("Matrix need to be with same rows and cols.");
        }

        /*implement operator "*" */
        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.col == second.col && (first.row > 0 && second.col > 0 && first.col > 0))
            {
                Matrix<T> resultMatrix = new Matrix<T>(first.col, second.col);
                for (int i = 0; i < resultMatrix.row; i++)
                {
                    for (int j = 0; j < resultMatrix.col; j++)
                    {
                        resultMatrix[i, j] = (dynamic)0;
                        for (int k = 0; k < first.col; k++)
                        {
                            checked
                            {
                                resultMatrix[i, j] = resultMatrix[i, j] + (dynamic)first[i, k] * second[k, j];
                            }
                        }
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new MatrixException("Row on the first matrix and col on the second matrix, are with different size, multiplication cannot be done.");
            }
        }

        /*operator true*/
        public static Boolean operator true(Matrix<T> matrix)
        {
            int tmp = 0;
            for (int i = 0; i < matrix.row; i++)
            {
                for (int j = 0; j < matrix.col; j++)
                {
                    if ((dynamic)matrix[i, j] == tmp)
                    {
                        return false;
                        
                    }
                }
            }
            return true;
        }

        /*operator false*/
        public static Boolean operator false(Matrix<T> matrix)
        {
            int zeroChecker = 0;
            for (int i = 0; i < matrix.row; i++)
            {
                for (int j = 0; j < matrix.col; j++)
                {
                    if ((dynamic)matrix[i, j] == zeroChecker)
                    {
                        return false;
                        
                    }
                }
            }
            return true;
        }

        /*to string*/
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    str.Append(matrix[i, j] + " ");
                }
                str.AppendLine();
            }
            return str.ToString();           
        }
    }
}
