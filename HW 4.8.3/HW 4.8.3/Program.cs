using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4._8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное целое число, для завершения игры нажмите enter: ");
            int numbermax = int.Parse(Console.ReadLine());

            Random r = new Random();

            int numbergame = r.Next(0, numbermax);                              // программа генерирует случайное целое число

            while (true)
            {
                Console.Write("\nВведите число: ");
                var userValue = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userValue))
                {
                    Console.Write($"\nЗагаданное число не угадано.");           // юзер нажал enter
                    break;                                                      // что то делаем и выходим из цикла                                                       
                }

                int number = int.Parse(userValue);

                if (number < numbergame)
                {
                    Console.Write("\nЗагаданное число больше.");
                }

                if (number > numbergame)
                {
                    Console.Write("\nЗагаданное число меньше.");
                }

                if (number == numbergame)
                {
                    Console.Write("\nВы угадали загаданное число.");
                    break;                
                }
            }

            Console.Write($"\nЗагаданное число: {numbergame}");

            Console.ReadKey();
        }
    }
}
