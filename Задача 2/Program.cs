using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение из слов, разделенных пробелами и без знаков припенания.");
            string start_string = Console.ReadLine();
            string[] string_array = start_string.Split();
            string result_string = "";
            //пишем строку в обратном порядке//
            foreach (char c in start_string)
            {
                result_string = c + result_string;
            }
            //убираем влияние пробелов и регистра в сторках//
            result_string = result_string.ToLower().Replace(" ", "");
            start_string = start_string.ToLower().Replace(" ", "");
            //для визуального контроля//
            Console.WriteLine(result_string);
            Console.WriteLine(start_string);
            //сравниваем получившиеся строки//
            if (start_string == result_string)
            {
                Console.WriteLine("Выражение является полиндромом.");
            }
            else
            {
                Console.WriteLine("Выражение не является полиндромом.");
            }
            Console.ReadKey();
        }
    }
}
