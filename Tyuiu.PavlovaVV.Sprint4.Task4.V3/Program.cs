using Tyuiu.PavlovaVV.Sprint4.Task4.V3.Lib;
namespace Tyuiu.PavlovaVV.Sprint4.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matr = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i}.{j} элемент массива: ");
                    matr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine("Массив: \n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matr[i, j] + "  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(matr);

            Console.WriteLine("Сумма нечетных элементов массива: " + res);

            Console.ReadKey();
        }
    }
}
