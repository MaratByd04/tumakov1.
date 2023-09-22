using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Exercises_3
{
    internal class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("\nДомашнее задание 2.2. Решение квадратного уравнения. \n");

            Console.WriteLine("Введите первый коэффициент.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэффициент.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэффициент.");
            int c = int.Parse(Console.ReadLine());

            int D = b * b - 4 * c * a;
            if (D > 0)
            {
                Console.WriteLine((-b + Math.Sqrt(D)) / a * 2);
                Console.WriteLine((-b - Math.Sqrt(D)) / a * 2);
            }
            else if (D == 0)
            {
                Console.WriteLine(-b / a * 2);
            }
            else
            {
                Console.WriteLine("Данное уравнение не имеет корней.");
            }
            Console.ReadKey();
            Console.Clear();


        }
    }
}
