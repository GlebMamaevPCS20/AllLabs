using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class Lab5 : ILabs
    {
        public void Demo()
        {
            MatrixInfo.PrintMatrixInfo(5);
        }

        public string Description()
        {
            return "Задания лабораторной №5";
        }

        public int Id()
        {
            return 5;
        }

        public string Name()
        {
            return "Двумерные массивы";
        }
    }
}
