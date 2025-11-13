using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.OzdoevaLM.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; // кол-во строк
            int columns = array.Length / rows;   // кол-во столбцов
                                                 
            int minim = 9;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 4; j < columns; j++)
                {
                    if (array[i, j] < minim)
                    {
                        minim = array[i, j];
                    }
                }
            }
            return minim;
        }
    }
}