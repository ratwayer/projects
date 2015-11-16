using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(6,7);
            Matrix b = new Matrix(7,6);
            Matrix c;

            Console.WriteLine("Матрица A:");
            a.FillMatrix();
            Console.WriteLine(a);

            Console.WriteLine("Матрица B:");
            b.FillMatrix();
            Console.WriteLine(b);

            if ((a.NumberOfRows == b.NumberOfRows) && (a.NumberOfColumns == b.NumberOfColumns))
            {
                Console.WriteLine("Сумма");
                c = a + b;
                c.ShowMatrix();
                Console.WriteLine("Разность");
                c = a - b;
                c.ShowMatrix();
            }
            else
            {
                Console.WriteLine("Матрицы неодинаковы по размеру.Сложение и вычитание невозможно.\n");
            }

            if (a.NumberOfColumns == b.NumberOfRows)
            {
                Console.WriteLine("Произведение");
                c = a * b;
                c.ShowMatrix();
            }
            else
            {
                Console.WriteLine("Количество столбцов матрицы A не равно количеству строк матрицы B.Умножение невозможно.");
            }
            Console.ReadKey();
        }
    }
}
