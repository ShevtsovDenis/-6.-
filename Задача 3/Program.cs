using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string start_string = Console.ReadLine();
            //Определяем индекс первой скобки и последней скобки во всей строке. Присваиваем данные значения переменным.//
            int a = start_string.IndexOf("{");
            int b = start_string.LastIndexOf("}");
            //Удаляем все символы между скобками//
            string result = start_string.Remove(a+1, (b-a)-1);
            Console.WriteLine(result);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}
