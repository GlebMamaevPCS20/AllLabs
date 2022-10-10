using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class MatrixInfo
    {
        private void Mass(int n)
        {
            _n = n;
        }
        private static int _n;
        public int N { get; set; } = _n;
        private static int[,] _mass = new int[_n, _n];

        public static void PrintMatrixInfo(int n)
        {
            _mass = CreateMatrix(n);
            PrintMatrix(_mass);
            Console.WriteLine();
            AllSummMatrix(_mass);
            Console.WriteLine();
            MatrixDiagonals(_mass);

        }
        public static int[,] CreateMatrix(int n)
        {
            int[,] mass = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(0, 101);

                }

            }
            return mass;
        }
        public static void PrintMatrix(int[,] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(0, 101);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
        public static void AllSummMatrix(int[,] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    summ += mass[i, j];
                }
            }
            Console.WriteLine("Сумма всех элементов = " + summ);
        }
        public static void MatrixDiagonals(int[,] mass)
        {
            Console.WriteLine("Элементы главной диагонали");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[i, i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Элементы побочной диагонали");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[i, mass.GetLength(0) - i - 1] + "\t");
            }
        }
    }
}
