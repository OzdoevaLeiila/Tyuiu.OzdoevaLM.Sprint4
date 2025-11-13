using Tyuiu.OzdoevaLM.Sprint4.Task3V4.Lib;
namespace Tyuiu.OzdoevaLM.Sprint4.Task3V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Оздоева Лейла Магомедовна | ИИПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Оздоева Лейла Магомедовна | ИИПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти минимальный элемент в последнем столбце массива                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");

            int[,] mas2 = new int[5, 5] {  { 6, 5, 4, 1, 5 },
                                           { 8, 2, 3, 4, 2 },
                                           { 3, 7, 7, 1, 3 },
                                           { 3, 4, 8, 1, 3 },
                                           { 4, 3, 5, 5, 2 } };

            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;
            Console.WriteLine("Массив = ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 4; j < columns; j++)
                {
                    Console.WriteLine($"{mas2[i, j]} \t");
                }


                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas2);

            Console.WriteLine("Минимальный элемент в последнем столбце массива = " + res);
            Console.ReadKey();
        }
    }
}