/*   
 *   Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
 *   что такого элемента нет.
 *   Например, задан массив:
 *   1 4 7 2
 *   5 9 2 3
 *   8 4 2 4
 *   17 -> такого числа в массиве нет
 */

namespace App_6
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[] item = new string[2] {"строк","колонок"};
            int elem = 0;
            int[] param = new int[2];

            for (int i = 0; i < 2; i++)
			{
                 Console.Write($"Введите количество {item[i]}: ");
                 param[i] = Convert.ToInt32(Console.ReadLine());
			}

            Console.Write($"Введите элемент для поиска: ");
            elem = Convert.ToInt32(Console.ReadLine());
            
            int[,] array = GetAdd2DArray(param);
            
            Print2DArray( array );

            Console.WriteLine( GetElement( array, elem ) == -1 ? "Элемент не найден" : $"Индекс элемента: { GetElement( array, elem) }");            
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
                    Console.Write($"  {array[i,j]}  |");
                }
                Console.WriteLine();
            }
        }

        // возвращает индекс числа в массиве
        static int GetElement( int[,] array, int element)
        {   
            int result = -1;
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {   
                for (int j = 0; j < array.GetLength(1); j++)
                {   
                    if( element == array[i,j] )
                    {   
                        result = count;
                        break;
                        
                    } 
                    
                    count++;
                }
                
                if (result != -1)
	            {
                    break;
	            }
            }
            
            return result;
        }
    }
}