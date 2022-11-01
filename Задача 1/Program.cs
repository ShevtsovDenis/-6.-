using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение из слов, разделенных пробелами и без знаков припенания.");
            string start_string = Console.ReadLine();
            //преобразуем строку в массив//
            string[] string_array = start_string.Split();
            //присваиваем переменной значение первого слова в массиве
            string max = string_array[0];
            //находим самое длинное слово//
            foreach (string s in string_array)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении - {0}",max);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}
