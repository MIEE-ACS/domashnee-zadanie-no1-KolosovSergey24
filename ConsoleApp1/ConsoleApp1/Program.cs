using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double S, D, L;

            //Проверяем на ошибку:
            try
            {
                //Вводим данные:
                Console.Write("Введите площадь S круга: ");
                S = double.Parse(Console.ReadLine());

                //Считаем:
                D = Math.Sqrt(4 * S / Math.PI);
                L = Math.PI * D;

                //Выводим данные:
                Console.WriteLine($"Диаметр D равен: {Math.Round(D, 3)} \nДлина L равна: {Math.Round(L, 3)}");
                Console.ReadKey();
            }
            catch
            {
                //Выводим в случае ошибки:
                Console.WriteLine("Внимание! Данные введены не правильно!");
                Console.ReadKey();
            }
        }
    }
}
