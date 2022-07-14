/*   
 *   Задача 51: Задайте двумерный массив. Найдите сумму главой диагонали массива. 
 *   Например, задан массив:
 *   1 4 7 2
 *   5 9 2 3
 *   8 4 2 4
 *   Сумма элементов главной диагонали: 1+9+2 = 12
 */

namespace App_4
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

            Console.Write($"Сумма элементов главной диагонали: {GetSumMainDiagonal(GetAdd2DArray(param))}");
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
                Console.Write($"Элементы главной диагонали: ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                       if (  i == j )
	                   {
                            Console.Write($"{ array[i,j] } | ");
	                   }
                    }
                }
                Console.WriteLine();
            }
        }

        // возвращает сумму элементов главной диагонали матрицы
        static int GetSumMainDiagonal( int[,] array)
        {   
            int result = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   if ( i == j )
	               {
                       result += array[i,j];
	               }
                }
            }

            return result;
        }
    }
}