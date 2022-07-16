/*   
 *   Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
 *   Например, задан массив:
 *   1 4 7 2
 *   5 9 2 3
 *   8 4 2 4
 *   Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

namespace App_6
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

            int[,] array = GetAdd2DArray(param);
            Print2DArray( array );

            GetAverageColumns( array);
            
        }

        // возвращает массив, заполненный случайными числами (10, 20)
        static int[,] GetAdd2DArray(params int[] param)
        {
            int[,] array = new int[param[0], param[1]];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 20);
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
                    Console.Write($" {array[i,j]}  |");
                }
                Console.WriteLine();
            }
        }

        // возвращает среднее арифметическое элементов в каждом столбце
        static void GetAverageColumns( int[,] array)
        {   
                Console.Write($"Cреднее арифметическое элементов в каждом столбце: ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    double sum = 0;
                    
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        sum += array[i, j];
                    }
                    
                    Console.Write(" {0:0.00} |", sum / array.GetLength(0));
                }       
        }
    }
}
