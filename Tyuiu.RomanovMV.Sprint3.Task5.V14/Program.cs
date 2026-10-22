
using Tyuiu.RomanovMV.Sprint3.Task5.V14.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            int x = 5; int x1 = 1; int y1 = 3; int x2 = 1; int y2 = 14; double res = ds.GetSumSumSeries(x, x1, y1, x2, y2);
            Console.WriteLine("Старт шага первого цикла = " + x1);
            Console.WriteLine("Конец шага первого цикла = " + y1);
            Console.WriteLine("Старт шага второго цикла = " + x2);
            Console.WriteLine("Конец шага второго цикла = " + y2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("При X равном 5 сумма сумм функции =" + res);

            Console.ReadLine();
        }
    }
}
