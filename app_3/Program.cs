/*   
 *   Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
 *   Например, изначально массив выглядел вот так:
 *   1 4 7 2
 *   5 9 2 3
 *   8 4 2 4
 */

namespace App_3
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

            Print2DArray(GetAdd2DArray(param), true);

            Print2DArray(ReplaseElement(GetAdd2DArray(param)));
        }

        // возвращает массив, заполненный случайными числами
        static int[,] GetAdd2DArray(params int[] param)
        {
            int[,] array = new int[param[0], param[1]];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i + j;
                }
            }

            return array;
        }

        // выводит массив в консоль
        static void Print2DArray(int[,] array, bool enableLogging = false)
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
            
            if (enableLogging)
            {
                Console.Write($"Необходимо заменить элементы с индексами: ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                       if ( i % 2 == 0 && j % 2 == 0)
	                   {
                            Console.Write($"{i},{j} | ");
	                   }
                    }
                }
                Console.WriteLine();
            }
        }

        // заменяет элементы на их квадраты(если оба индекса чётные)
        static int[,] ReplaseElement( int[,] array)
        {   
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   if ( i % 2 == 0 && j % 2 == 0)
	               {
                        array[i,j] = array[i,j] * array[i,j];
	               }
                }
            }

            return array;
        }
    }
}