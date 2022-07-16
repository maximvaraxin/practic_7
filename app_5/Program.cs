/*   
 *   Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 *   m = 3, n = 4.
 *   0,5 7 -2 -0,2
 *   1 -3,3 8 -9,9
 *   8 7,8 -7,1 9
 */

namespace App_5
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[] item = new string[2] {"строк","колонок"};
            int[] param = new int[2];

            for (int i = 0; i < 2; i++)
			{
                 Console.Write($"Введите количество {item[i]}: ");
                 param[i] = Convert.ToInt32(Console.ReadLine());
			}

            Print2DArray( GetAdd2DArray(param));
        }

        // возвращает массив, заполненный случайными вещественными числами
        static double[,] GetAdd2DArray(params int[] param)
        {
            double[,] array = new double[param[0], param[1]];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().NextDouble() * 10 - 5;
                }
            }

            return array;
        }

        // выводит массив в консоль
        static void Print2DArray(double[,] array)
        {   
            Console.WriteLine($"Выведем массив: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i,j]:F2} |");
                }
                Console.WriteLine();
            }
        }
    }
}