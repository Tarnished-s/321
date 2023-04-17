using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть три числа");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            float c = Convert.ToSingle(Console.ReadLine());
            float m = Max(a, b, c);
            Console.WriteLine("максимальне число:  " + m);
            Console.ReadKey();
        }
        static float Max(float x, float y, float z)
        {
            if (x > y && x > z)
            {
                return x;
            }
            else if (y > x && y > z)
            {
                return y;
            }
            else
            {
                return z;
            }

        }
    }
}
