using Tyuiu.OzdoevaLM.Sprint4.Task5.V20.Lib;
namespace Tyuiu.OzdoevaLM.Sprint4.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Оздоева Лейла Магомедовна | ИИПб-25-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Двумерные массивы. (гинератор случайнных чисел)                     *");
            Console.WriteLine("* Задание #5                                                                *");
            Console.WriteLine("* Вариант #20                                                               *");
            Console.WriteLine("* Выполнила: Оздоева Лейла Магомедовна | ИИПб-25-1                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный          *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 3. Найти сумму положительных   *");
            Console.WriteLine("* элементов                                                                 *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите кол-во строк и столбцов через enter");

            int rows = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, length];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = rnd.Next(-7, 3);
                }

            }

            Console.WriteLine("Ваш массив = ");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine($"Сумма положительных элементов = {res}");

            Console.ReadKey();
        }
    }
}