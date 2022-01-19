using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            double b = Convert.ToDouble(Console.ReadLine());

            Linur linur = new Linur(k, b);
            Console.WriteLine(linur.Root());
            Console.ReadKey();

        }
    }
}
