using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalObjects
{
    class Matrix
    {
        private int[,] matrix;
        private int numberOfRows, numberOfColumns;

        public Matrix(int numberOfRows, int numberOfColumns)
        {
            if (numberOfRows < 1 || numberOfRows>10000)
                numberOfRows = 2;
            if (numberOfColumns < 1 || numberOfColumns > 10000)
                numberOfColumns = 2;

            this.numberOfRows = numberOfRows;
            this.numberOfColumns = numberOfColumns;
            matrix = new int[numberOfRows, numberOfColumns];
        }

        public int this[int indexI, int indexJ]
        {
            set { matrix[indexI, indexJ] = value; }
            get { return matrix[indexI, indexJ]; }
        }

        public int NumberOfRows
        {
            get { return numberOfRows; }
        }

        public int NumberOfColumns
        {
            get { return numberOfColumns; }
        }

        public void FillMatrix()
        {
            Random randomNumber = new Random();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    matrix[i, j] = randomNumber.Next(10);
                }
            }
            Console.WriteLine("\n");
        }

        public virtual void ShowMatrix()
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a.numberOfRows, a.NumberOfColumns);

            for (int i = 0; i < a.numberOfRows; i++)
            {
                for (int j = 0; j < a.NumberOfColumns; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a.numberOfRows, a.NumberOfColumns);

            for (int i = 0; i < a.numberOfRows; i++)
            {
                for (int j = 0; j < a.NumberOfColumns; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }
            return c;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            
            Matrix c = new Matrix(a.numberOfRows, b.NumberOfColumns);
            
            for (int i = 0; i < a.numberOfRows; i++)
            {
                for (int j = 0; j < b.numberOfColumns; j++)
                {
                    for (int k = 0; k < b.numberOfRows; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }    
            }
            return c;
        }

        public override string ToString()
        {
            string s = null ;
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    s += Convert.ToString(matrix[i, j]) + " ";
                    
                }
                s += "\n\n";
            }
            return s;
        }
    }
}