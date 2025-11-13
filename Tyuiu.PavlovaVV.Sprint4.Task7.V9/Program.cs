using Tyuiu.PavlovaVV.Sprint4.Task7.V9.Lib;
namespace Tyuiu.PavlovaVV.Sprint4.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 3;
            string str = "864299753";
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            int index = 0;
            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }


            int result = ds.Calculate(rows, columns, str);

            Console.WriteLine($"\nКоличество четных чисел: {result}");


            Console.WriteLine("\nАнализ четности:");
            foreach (char c in str)
            {
                int num = int.Parse(c.ToString());
                string parity = (num % 2 == 0) ? "четное" : "нечетное";
                Console.WriteLine($"{num} - {parity}");
            }

            Console.ReadKey();
        }
    }
}
