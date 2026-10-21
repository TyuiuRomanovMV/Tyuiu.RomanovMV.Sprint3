
using System.Numerics;
using Tyuiu.RomanovMV.Sprint3.Task4.V10.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            /* */
            Console.Title = "Спринт #3 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=(sin(x)-x)/x. При х = 0 пропустить значение Полученные        *");
            Console.WriteLine("* значения перемножать.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            
            int x1 = -5; int x2 = 5; double res = ds.Calculate(x1, x2);
            Console.WriteLine("Старт шага = " + x1);
            Console.WriteLine("Конец шага = " + x2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Изменённая строка - " + res);

            Console.ReadLine();
        }
    }
}
