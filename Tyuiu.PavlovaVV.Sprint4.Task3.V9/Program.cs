using Tyuiu.PavlovaVV.Sprint4.Task3.V9.Lib;
namespace Tyuiu.PavlovaVV.Sprint4.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 9, 6, 4, 5, 3 },
                                           { 7, 4, 7, 5, 3 },
                                           { 8, 5, 9, 9, 3 },
                                           { 7, 8, 7, 9, 3 },
                                           { 3, 7, 3, 7, 7 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Сумма элементов во втором столбце массива: " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}

