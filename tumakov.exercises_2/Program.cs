using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov.exercises_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1.Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени.\n");

            Console.WriteLine("Введите свое имя.");
            string userName = Console.ReadLine();
            Console.WriteLine("Добро пожаловать, " +  userName);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nУпражнение 2.2. Деление одного числа на другое. \n");

            Console.WriteLine("Введите два целых числа.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double resultOfDivision = num1 / num2;
            if (num1!=0 && num2!=0)
                {
                Console.WriteLine(resultOfDivision);
                }
            Console.ReadKey(); 
            Console.Clear();

            Console.WriteLine("Домашнее заадние 2.1. Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.");

            Console.WriteLine("Введите любую букву русского или английского алфавита.");
            var letter = char.ToLower(Console.ReadKey().KeyChar);
            for (var i = 1; i <= 1; i++)
            {
                if (letter == 'z')
                {
                    letter = 'a';
                    Console.WriteLine("\nАлфавит кончился, перебор начат заново\n" + letter);

                }
                else if (letter == 'я')
                {
                    letter = 'а';
                    Console.WriteLine("\nАлфавит кончился, перебор начат заново\n" + letter);
                }
                else
                {
                    letter = (char)(letter + 1);
                    Console.WriteLine($"\n{letter}");
                }
            }
                Console.ReadKey();
                Console.Clear();

            Console.WriteLine("\nДомашнее задание 2.2. Решение квадратного уравнения. \n");

            Console.WriteLine("Введите первый коэффициент.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэффициент.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэффициент.");
            int c = int.Parse(Console.ReadLine());
            
            int D = b * b - 4 * c * a;
            if (D>0)
            {
                Console.WriteLine((-b + Math.Sqrt(D))/a*2);
                Console.WriteLine((-b -  Math.Sqrt(D))/a*2);
            }
            else if (D == 0)
            {
                Console.WriteLine(-b/a*2);
            }
            else
            {
                Console.WriteLine("Данное уравнение не имеет корней.");
            }
            Console.ReadKey ();
            Console.Clear();
                        










        }
    }
}
