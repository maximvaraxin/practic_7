/*   
 *   Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
 *   m = 3, n = 4.
 *   1 4 8 19
 *   5 -2 33 -2
 *   77 3 8 1
 */

namespace App_1
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

        // возвращает массив, заполненный случайными числами
        static int[,] GetAdd2DArray(params int[] param)
        {
            int[,] array = new int[param[0], param[1]];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 100);
                }
            }

            return array;
        }

        // выводит массив в консоль
        static void Print2DArray(int[,] array)
        {   
            Console.WriteLine($"Выведем массив: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"  {array[i,j]}  |");
                }
                Console.WriteLine();
            }
        }
    }
}