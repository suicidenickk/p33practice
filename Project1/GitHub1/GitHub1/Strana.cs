using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub1
{
    class strana //Создаём класс страны
    {
        static strana[] a = new strana[1000];
        static int n;

        public string nazvanie { get; set; }
        public string formapravleniya { get; set; }
        public float ploshad { get; set; }

        internal void add()
        {
            Console.WriteLine();
            Console.Write("Введите кол-во записей: ");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new strana();
                Console.Write("Название: ");
                a[i].nazvanie = Console.ReadLine();
                Console.Write("Форма правления: ");
                a[i].formapravleniya = Console.ReadLine();
                Console.Write("Площадь: ");
                a[i].ploshad = (Convert.ToSingle(Console.ReadLine()));
                Console.WriteLine();
            }
        }

        internal void print() //Вывод данных
        {
            Console.WriteLine();
            Console.WriteLine("Список стран:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Название:" + a[i].nazvanie);
                Console.WriteLine("Форма правления:" + a[i].formapravleniya);
                Console.WriteLine("Площадь:" + a[i].ploshad);

            }
            Console.WriteLine();
        }
    }
}
