
using Tyuiu.RomanovMV.Sprint3.Task7.V16.Lib;


namespace Tyuiu.RomanovMV.Sprint3.Task7.V16
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            int s1 = -5; int s2 = 5; int len = ds.GetMassFunction(s1, s2).Length;
            double[] Array = new double[len];
            Array = ds.GetMassFunction(s1, s2);


            Console.WriteLine("Старт шага цикла = " + s1);
            Console.WriteLine("Конец шага цикла = " + s2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+--------------+");
            Console.WriteLine("|    X     |     f(x)     |");
            Console.WriteLine("+----------+--------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |   {1, 6:f2}     |", s1, Array[i]);
                s1++;
            }
            Console.WriteLine("+----------+--------------+");
            Console.ReadKey();
        }
    }
}
