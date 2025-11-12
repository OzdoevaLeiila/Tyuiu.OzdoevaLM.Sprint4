using Tyuiu.OzdoevaLM.Sprint4.Task1.V29.Lib;
namespace Tyuiu.OzdoevaLM.Sprint4.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Оздоева Лейла Магомедовна | ИИПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Оздоева Лейла Магомедовна | ИИПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9. Подсчитать сумму         *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество элементов массивa: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] mass = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Массив = ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(mass[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mass);

            Console.WriteLine("Сумма нечетных элементов в массиве = " + res);

            Console.ReadKey();
        }
    }
}