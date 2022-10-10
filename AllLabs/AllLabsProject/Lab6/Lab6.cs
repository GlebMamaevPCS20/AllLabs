using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class Lab6 : ILabs
    {
        public void Demo()
        {
            ProceduraTXT.Procedura();
            string path1 = @"C:\Users\glebm\OneDrive\Рабочий стол\C#";
            ProceduraTXT.FilesList(path1);
        }

        public string Description()
        {
            return "Задания лабораторной №6";
        }

        public int Id()
        {
            return 6;
        }

        public string Name()
        {
            return "Рекурсивные функции";
        }
    }
}
