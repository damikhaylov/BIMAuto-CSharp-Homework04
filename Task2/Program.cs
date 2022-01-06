using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача на использование операторов цикла с постусловием:

            Осуществить ввод последовательности целых чисел и сравнить, что больше, количество
            положительных или количество отрицательных. Последовательность потенциально
            не ограничена, окончанием последовательности служит число 0.
            */

            Console.WriteLine("Сравнение количества введённых положительных и отрицательных чисел");
            Console.WriteLine();

            int N;
            uint countNPos = 0;
            uint countNNeg = 0;

            do
            {
                Console.Write("Введите целое число (0 - для завершения): ");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                    countNPos++;
                if (N < 0)
                    countNNeg++;
            } while (N != 0);

            if (countNPos == 0 && countNNeg == 0)
                Console.WriteLine("Не введено ни одного значимого числа");
            else if (countNPos > countNNeg)
                Console.WriteLine("Введено больше положительных чисел, чем отрицательных");
            else if (countNPos < countNNeg)
                Console.WriteLine("Введено больше отрицательных чисел, чем положительных");
            else
                Console.WriteLine("Введено равное количество положительных и отрицательных чисел");

            Console.ReadKey();
        }
    }
}
