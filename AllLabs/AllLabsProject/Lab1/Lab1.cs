using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    public class Lab1 : ILabs
    {
        public void Demo()
        {
            Console.WriteLine("Задание 1");
            double result = Math.Sqrt(((Math.Pow(2, 2) - Math.Pow(3, 3)) / (Math.Sqrt((Math.Pow(3, 4) - Math.Pow(2, 4))))) + Math.Abs(Math.Pow(3, 5) - Math.Pow(15, 2.5)));
            Console.WriteLine(result);



            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("Задание 2");
            double c;
            int a, b;
            Random rnd = new Random();
            a = rnd.Next(-100, 100);
            b = rnd.Next(-100, 100);
            c = (Math.Pow(a, 2) + Math.Pow(b, 1 / 3)) / (a + b);
            Console.WriteLine(c);


            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Задание 3");
            double e = 5.93576;
            int f = (int)e;
            int g = (int)Math.Round(e);
            int k = (int)Math.Ceiling(e);
            double h = Math.Round(e, 1);
            int j = 5;
            int j1 = j++;
            int m = 5;
            int m1 = ++m;

            Console.WriteLine("int b = (int)a, результат " + f);
            Console.WriteLine("int c = Math.<???>(a) - решение int c = (int)Math.Round(a)");
            Console.WriteLine("int d = Math.<???>(a) - решение  int d = Math.Ceiling(a)");
            Console.WriteLine("double e = Math.<???>(a) решение double e= Math.Round(a, 1);");
            Console.WriteLine("int g = f++  " + j1 + "  int g = ++f  " + m1);





            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Задание 4");
            double l;
            l = rnd.NextDouble() + rnd.Next(-100, 100);
            Console.WriteLine(l);


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Задание 5");
            int n = 5;
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = rnd.Next(10, 50);
                Console.Write(mass[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("ср. арифм. = ");
            Console.WriteLine(Average(mass));

            Console.Write("ст. откл.  = ");
            Console.WriteLine(StDev(mass));

            static double Average(int[] mass)
            {
                double sum = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    sum += mass[i];
                }

                return (sum / mass.Length);
            }

            static double StDev(int[] mass)
            {
                double sum = 0;
                double f = Average(mass);
                for (int i = 0; i < mass.Length; i++)
                {
                    sum += Math.Pow((mass[i] - f), 2);
                }


                return Math.Sqrt(sum / (mass.Length - 1));

            }
        }

        public string Discription()
        {
            return "Задания лабораторной №1";
        }

        public int Id()
        {
            return 1;
        }

        public string Name()
        {
            return "Арифметические опреации. Классы Random и Math";
        }
    }
}
