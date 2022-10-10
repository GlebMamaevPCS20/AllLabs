using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class Lab2 : ILabs
    {
        public void Demo()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число от 1 до 7");
            int num = 0;
            while (true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out num);
                if ((res == true) && (num >= 1) && (num <= 7))
                {
                    break;
                }


            }
            string day = "";
            if (num == 1)
                day = "Понедельник";
            else if (num == 2)
                day = "Вторник";
            else if (num == 3)
                day = "Среда";

            else if (num == 4)
                day = "Четверг";

            else if (num == 5)
                day = "Пятница";

            else if (num == 6)
                day = "Суббота";

            else if (num == 7)
                day = "Воскресенье";
            Console.WriteLine(day);

            switch (num)
            {
                case 1:
                    day = "Понедельник";
                    break;
                case 2:
                    day = "Вторник";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Пятница";
                    break;
                case 6:
                    day = "Суббота";
                    break;
                case 7:
                    day = "Воскресенье";
                    break;
            }
            Console.WriteLine(num);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите первое число");
            int number;
            while (true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out number);
                if (res == true)
                    break;
            }
            int a = number;

            Console.WriteLine("Введите действие");
            string act;

            while (true)
            {
                act = Console.ReadLine();
                if ((act == "+") || (act == "/") || (act == "*") || (act == "-"))
                {

                    break;
                }
            }

            Console.WriteLine("Введите второе число");
            while (true)
            {
                string str1 = Console.ReadLine();
                bool res = int.TryParse(str1, out number);
                if (res == true)
                    break;
            }
            int b = number;

            int result = 0;
            switch (act)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            Console.WriteLine($"{a} {act} {b} = {result}");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Задание 4");
            string str2 = "232abab  4 an2424n 545 n aba 44 ab3";
            string newStr = "";
            string current = "";
            bool ischar = true;
            for (int i = 0; i < str2.Length; i++)
            {
                if (int.TryParse(str2[i].ToString(), out int value) == true)
                {
                    if (ischar == false)
                        current += value.ToString();
                    else
                    {
                        current = value.ToString();
                    }
                    if (i == str2.Length - 1)
                    {
                        newStr += current;
                    }
                    ischar = false;
                }
                else
                {
                    if (ischar == false)
                    {
                        newStr += current + " ";
                        ischar = true;
                    }
                    else
                    {
                        ischar = true;
                    }
                }

            }
            Console.WriteLine(newStr);
            Console.WriteLine();
            Console.WriteLine();

            MaxOrMin(true, newStr);
            MaxOrMin(false, newStr);

            Console.WriteLine();
            Console.WriteLine();

            Summ(newStr);

            Console.WriteLine();
            Console.WriteLine();

            Column(newStr);



            static int MaxOrMin(bool x, string str)
            {
                int max = 0;
                int min = 0;
                int maxCount = 0;
                int minCount = 0;
                string buffer = "";
                int num;
                if (x == true)
                {
                    for (int i = 0; i <= str.Length - 1; i++)
                    {
                        if (str[i] != ' ')
                        {
                            buffer += str[i];

                        }
                        else
                        {
                            int.TryParse(buffer, out num);
                            buffer = "";
                            if (maxCount == 0)
                            {
                                max = num;
                                maxCount = 1;
                            }
                            if (max < num)
                            {
                                max = num;
                            }

                        }
                        if (i == str.Length - 1)
                        {
                            int.TryParse(buffer, out num);
                            buffer = "";
                            if (maxCount == 0)
                            {
                                max = num;
                                maxCount = 1;
                            }
                            if (max < num)
                            {
                                max = num;
                            }
                        }
                    }
                    Console.WriteLine("максимальное в строке = " + max);
                    return max;
                }
                else
                {
                    for (int i = 0; i <= str.Length - 1; i++)
                    {
                        if (str[i] != ' ')
                        {
                            buffer += str[i];
                        }
                        else
                        {

                            int.TryParse(buffer, out num);
                            buffer = "";
                            if (minCount == 0)
                            {
                                min = num;
                                minCount = 1;
                            }
                            if (min > num)
                            {
                                min = num;
                            }
                        }
                        if (i == str.Length - 1)
                        {
                            int.TryParse(buffer, out num);

                            buffer = "";
                            if (minCount == 0)
                            {
                                min = num;
                                minCount = 1;
                            }
                            if (min > num)
                            {
                                min = num;
                            }
                        }
                    }
                    Console.WriteLine("минимальное в строке = " + min);
                    return min;

                }
            }

            static int Summ(string str)
            {
                int num;
                string buffer = "";
                int summ = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        int.TryParse(buffer, out num);
                        summ += num;
                        buffer = "";
                    }
                    else
                    {
                        buffer += str[i];
                        if (i == str.Length - 1)
                        {
                            int.TryParse(buffer, out num);
                            summ += num;
                        }
                    }
                }
                Console.WriteLine("сумма всех чисел = " + summ);
                return summ;
            }

            static void Column(string str)
            {
                string buffer = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        Console.WriteLine(buffer);
                        Console.WriteLine();
                        buffer = "";
                    }
                    else
                    {
                        buffer += str[i];
                        if (i == str.Length - 1)
                        {
                            Console.WriteLine(buffer);
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        public string Description()
        {
            return "Задания лабораторной №2";
        }

        public int Id()
        {
            return 2;
        }

        public string Name()
        {
            return "Условия. Операторы сравнения";
        }
    }
}
