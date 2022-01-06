using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача на использование операторов цикла c предусловием:

            Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено
            максимально возможное количество квадратов со стороной C (без наложений). 
            Найти количество квадратов, размещенных на прямоугольнике.
            Операции умножения и деления не использовать.
            */

            Console.Write("Определение количества квадратов со стороной C, ");
            Console.WriteLine("которые можно разместить на прямоугольнике AxB");
            Console.WriteLine();

            Console.Write("Введите размер стороны прямоугольника A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер стороны прямоугольника B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер стороны квадрата С: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if (A <= 0 || B <= 0 || C <= 0)
            {
                Console.WriteLine("Одно или несколько из введённых значений не являются "
                                  + "положительными числами");
            }
            else
            {
                uint squaresCount = 0; //искомое количество квадратов на прямоугольнике
                double filledA = C; //длина заполненной квадратами части прямоугольника вдоль стороны A
                double filledB = C; //длина заполненной квадратами части прямоугольника вдоль стороны B

                while (filledB <= B)
                {
                    while (filledA <= A)
                    {
                        filledA += C;
                        squaresCount++;
                    }
                    filledB += C;
                    filledA = C; //сброс размера заполненной области для следующего ряда квадратов
                }

                Console.WriteLine("Количество квадратов, которое можно расположить "
                                  + "на прямоугольнике: {0}", squaresCount);
            }
            Console.ReadKey();
        }
    }
}
