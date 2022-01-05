using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача на использование операторов цикла for:

            Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления
            следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого
            слагаемого выводить текущее значение суммы (в результате будут выведены квадраты
            всех целых чисел от 1 до N).
            */

            Console.WriteLine("Вычисление квадрата положительного целого числа");
            Console.WriteLine();

            Console.Write("Введите положительное целое число: ");
            ushort N = Convert.ToUInt16(Console.ReadLine());
            uint N2 = 0;

            for (uint i = 1; i < 2 * N; i += 2)
            {
                N2 += i;
                Console.WriteLine(N2);
            }
            Console.ReadKey();
        }
    }
}
