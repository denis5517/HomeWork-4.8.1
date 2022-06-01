using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4._8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину последовательности: ");
            int length = int.Parse(Console.ReadLine());
            int[] set = new int[length];

            for (int i = 0; i < length; i++)

            {
                Console.Write($"Введите {i + 1}-е число: ");

                set[i] = int.Parse(Console.ReadLine());
            }
                   
            int min = set[0];

            for (int i = 0; i < length; i++)

            {
                if (set[i] < min) min = set[i];
            }

            Console.WriteLine($"Наименьшее число из последовательности: {min}");

            Console.ReadLine();
        }
        
    }
}
