using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4._8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Введите количество строк в будущей матрице: ");
            int line = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов в будущей матрице: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[line, columns];                             // создать в памяти матрицу заданного размера

            Random r = new Random();                                            
            for (int i = 0; i < line; i++)

            {
                int sum = 0;

                for (int j = 0; j < columns; j++)

                {
                    matrix[i, j] = r.Next(10);                                  // заполнить массив случайными числами

                    sum += matrix[i, j];

                    Console.Write($"{matrix[i, j]} ");                           // вывести полученную матрицу на экран
                }
                Console.WriteLine($" : {sum} ");                                 // вывести суммы всех элементов этой матрицы  
            }                                                                   // на экран отдельной строкой

            Console.ReadLine();

        }
    } 
}
