
using Tyuiu.RomanovMV.Sprint3.Task3.V11.Lib;


namespace Tyuiu.RomanovMV.Sprint3.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в                    *");
            Console.WriteLine("* строке: 'sqwreq vqwqq q'                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            string str = "sqwreq vqwqq q";
            char str2 = 'q'; char str3 = '7';
            Console.WriteLine($"Строка - '{str}', заменяемый символ - '{str2}', заменяющий символ - '{str3}' ");
            string res = ds.ReplaceCharOnNum(str, str2, str3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Изменённая строка - " + res);

            Console.ReadLine();
        }
    }
}
