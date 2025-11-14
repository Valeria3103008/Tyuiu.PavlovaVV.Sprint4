using Tyuiu.PavlovaVV.Sprint4.Task7.V9.Lib;
namespace Tyuiu.PavlovaVV.Sprint4.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "864299753";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            int index = 0;


            Console.WriteLine("\nМассив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]}\t");
                    index++;
                }
                Console.WriteLine();

            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int res = ds.Calculate(n, m, str);
            Console.WriteLine("Количество четных чисел: " + res);
            Console.ReadKey();
        }
    }
}
