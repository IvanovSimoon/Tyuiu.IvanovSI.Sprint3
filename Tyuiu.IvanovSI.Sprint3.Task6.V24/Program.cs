using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint3.Task6.V24.Lib;
namespace Tyuiu.IvanovSI.Sprint3.Task6.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #6                                                               *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                      *");
            Console.WriteLine("* от -5 до 5, вычислить значение функции y=(x/cos(x))+1.5.                 *");
            Console.WriteLine("* принадлежащих числовому отрезку [17, 26] количество всех делителей       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");



            int startValue = 17;
            int stopValue = 26;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Кол-во делителей =  " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
