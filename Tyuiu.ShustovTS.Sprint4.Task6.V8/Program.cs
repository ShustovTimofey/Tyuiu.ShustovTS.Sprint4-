using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShustovTS.Sprint4.Task6.V8.Lib;
namespace Tyuiu.ShustovTS.Sprint4.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] dishes = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            Console.Title = "Спринт #4 | Выполнил: Шустов Т.С. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Шустов Тимофей Сергеевич | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных:                                            *");
            Console.WriteLine("* ['Пицца', 'Борщ', 'Пельмени', 'Омлет', 'Салат', 'Суп', 'Роллы'].        *");
            Console.WriteLine("* Используя класс Array, выведите элементы массива,                       *");
            Console.WriteLine("* длина которых больше 4 символов.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив: {");
            for (int i = 0; i < dishes.Length; i++)
            {
                Console.Write(dishes[i]);
                if (i != dishes.Length - 1) { Console.Write(", "); }
            }
            Console.WriteLine("}");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] res = ds.Calculate(dishes);
            Console.WriteLine($"Элементы массива, длина которых больше 4:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);
                if (i != res.Length - 1) { Console.Write(", "); }
            }
            Console.ReadKey();
        }
    }
}
