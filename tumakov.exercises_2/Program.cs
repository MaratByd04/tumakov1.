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

            Console.WriteLine("Упражнение 2. Деление одного числа на другое. \n");

            Console.WriteLine("Введите два целых числа.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double resultOfDivision = a / b;
            if (a!=0 && b!=0)
                {
                Console.WriteLine(resultOfDivision);
                }
            Console.WriteLine("")
            


        }
    }
}
