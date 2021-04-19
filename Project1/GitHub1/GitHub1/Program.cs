using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub1
{
    class Program
    {
        static strana az = new strana(); //Объявляем переменную *strana*

        static void Main(string[] args)
        {
            for (int z = 0; z < 10000; z++)
            { //Создаём меню программы
                Console.WriteLine(" ------------------Practice №1------------------ ");
                Console.WriteLine("|              1. Создать список.               |");
                Console.WriteLine("|              2. Вывести список.               |");
                Console.WriteLine("|              3. Очистить экран                |");
                Console.WriteLine("|              4. Выйти из программы.           |");
                Console.WriteLine(" ----------------------------------------------- ");
                Console.Write("Введите номер операции которую вы хотите выполнить: ");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1: az.add(); break;
                    case 2: az.print(); break;
                    case 3: Console.Clear(); break;
                    case 4: Environment.Exit(0); break;
                    default: Console.WriteLine("Error! Incorrect input!"); break; //Проверка на некорректный ввод данных, т.е при вводе числа >5 получаем ошибку
                }
            }

            Console.ReadKey();
        }
    }
}
