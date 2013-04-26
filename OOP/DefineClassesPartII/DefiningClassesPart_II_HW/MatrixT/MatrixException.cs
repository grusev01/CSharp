using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixT
{
    class MatrixException: SystemException
    {
        public MatrixException() {}
        public MatrixException(string messege) : base(messege) {}
        public MatrixException(string messege, Exception innerException) : base(messege, innerException) { }
    }
}
