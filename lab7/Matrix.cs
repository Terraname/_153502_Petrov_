using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp7_1
{
    public class Matrix
    {
        int[,] matrix = new int[2, 2];
        //public int[][] Matr = new int[2][];
        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }
        public Matrix(int x11, int x12, int x21, int x22)
        {
            this.matrix[0, 0] = x11;
            this.matrix[0, 1] = x12;
            this.matrix[1, 0] = x21;
            this.matrix[1, 1] = x22;
        }
        public int this[int x, int y]
        {
            get { return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }
        public int Get(int x, int y)
        {
            return this.matrix[x, y];
        }
        public void Set(int x, int y, int value)
        {
            this.matrix[x, y] = value;
        }
        public int Value()
        {
            return (this.matrix[0, 0] * this.matrix[1, 1] - this.matrix[0, 1] * this.matrix[1, 0]);
        }
        public void Reverse()
        {
            int a = this[0, 1];
            this[0, 1] = this[1, 0];
            this[1, 0] = a;

            a = this.Value();
            this[0, 0] = this[0, 0] / a;
            this[0, 1] = this[0, 1] / a;
            this[1, 0] = this[1, 0] / a;
            this[1, 1] = this[1, 1] / a;
            
        }

        public string toString()
        {
            string s = new string("\n");
            s += new string("|");
            s += new string(this[0, 0].ToString()); s += new string("\t");
            s += new string(this[0, 1].ToString()); s += new string("|\n|");
            s += new string(this[1, 0].ToString()); s += new string("\t");
            s += new string(this[1, 1].ToString()); s += new string("|\n");

            return s;
        }
        public static Matrix operator+(Matrix M1, Matrix M2)
        {
            Matrix M = new Matrix(M1.Get(0, 0) + M2.Get(0, 0),
                M1.Get(0, 1) + M2.Get(0, 1),
                M1.Get(1, 0) + M2.Get(1, 0),
                M1.Get(1, 1) + M2.Get(1, 1));
            return M;
        }
        public static Matrix operator-(Matrix M1, Matrix M2)
        {
            Matrix M = new Matrix(M1.Get(0, 0) - M2.Get(0, 0),
                M1.Get(0, 1) - M2.Get(0, 1),
                M1.Get(1, 0) - M2.Get(1, 0),
                M1.Get(1, 1) - M2.Get(1, 1));
            return M;
        }
        public static Matrix operator *(Matrix M, int n)
        {
            if (n == 0)
            { throw new ArgumentException("Devision by 0 "); }
            else
            {
                Matrix M1 = new Matrix(M[0, 0] * n, M[0, 1] * n, M[1, 0] * n, M[1, 1] * n);
                return M1;
            }
        }
        public static Matrix operator *(Matrix M1, Matrix M2)
        {
            Matrix M = new Matrix(M1[0, 0] * M2[0, 0] + M1[0,1] * M2[1,0],
                M1[0, 0] * M2[0, 1] + M1[0, 1] * M2[1, 1],
                M1[1, 0] * M2[0, 0] + M1[1, 1] * M2[1, 0],
                M1[1, 0] * M2[0, 1] + M1[1, 1] * M2[1, 1]);
            return M;
        }
        public static Matrix operator /(Matrix M, int n)
        {
            if (n == 0)
            { throw new ArgumentException("Devision by 0 "); }
            else
            {
                Matrix M1 = new Matrix(M[0, 0] / n, M[0, 1] / n, M[1, 0] / n, M[1, 1] / n);
                return M1;
            }
        }
      public static bool operator ==(Matrix M1, Matrix M2) 
        {
            if (M1[0, 0] != M2[0, 0] || M1[0, 1] != M2[0, 1] || M1[1, 0] != M2[1, 0] || M1[1, 1] != M2[1, 1])
                return false;
            return true;
        }
        public static bool operator !=(Matrix M1, Matrix M2)
        {
            if (M1[0, 0] != M2[0, 0] || M1[0, 1] != M2[0, 1] || M1[1, 0] != M2[1, 0] || M1[1, 1] != M2[1, 1])
                return true;
            return false;
        }

        public static implicit operator bool(Matrix M)
        {
            if(M.Value() == 0)
                return false;
            return true;
        }

        public static explicit operator int(Matrix M) => M.Value();

        public static explicit operator Matrix(int n) => new Matrix(n, 0, 0, n);

        public static Matrix operator++(Matrix M)
        {
            M = M + (Matrix)1;
            return M;
        }

        public static Matrix operator --(Matrix M)
        {
            M = M - (Matrix)1;
            return M;
        }

        /*public static explicit operator int(Matrix M)
        { return M.Value(); }*/
        /*public static explicit operator Matrix(int n)
        { return new Matrix(n, 0, 0, n); }*/

        /*public static Matrix operator /(Matrix M1, Matrix M2)
        {
            if (M2.Value() == 0)
            { throw new ArgumentException("Devision by matrix with 0 Determinant"); }
            else
            {
                return M1 * M2.Reverse();
            }
        }*/
    }
}
