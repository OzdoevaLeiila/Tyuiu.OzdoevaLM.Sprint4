using Tyuiu.OzdoevaLM.Sprint4.Task7.V19.Lib;
namespace Tyuiu.OzdoevaLM.Sprint4.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Оздоева Лейла Магомедовна | ИИПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Оздоева Лейла Магомедовна | ИИПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дана строка из одноразрядных цифр 90817264. Преобразуйте ее в матрицу    *");
            Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[4, 2];
            string str = "90817264";

            int index = 0;
            Console.WriteLine("\nМассив");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++, index++)
                {
                    Console.Write($"{str[index]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество нечётных элементов в матрице = " + ds.Calculate(4, 2, str));
            Console.ReadKey();
        }
    }
}