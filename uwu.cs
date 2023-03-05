using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Banan
{
    internal class uwu
    {
        private double pi = 3.14;
        public void Run()
        {
            
            Console.Write("Введите радиус окружности: ");
            double R = Convert.ToInt32(Console.ReadLine());
            double S = pi * R * R;
            Console.WriteLine("Результат: S = " + (S));
        }
    }
}
