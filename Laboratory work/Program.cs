using System;
using System.Threading;

namespace Exercises
{
    internal class Program
    {
        public static int Calculation_of_list_parameters(ref int prod, out int avg, params int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                prod *= i;
                sum += i;
            }
            avg = sum / array.Length;
            return sum;
        }

        static void Main(string[] args)
        {
            // Упражнение 2
            Console.WriteLine("Упражнение 2");
            Console.Write("Введите количество элеметнов массива: ");
            if (byte.TryParse(Console.ReadLine(), out byte count))
            {
                int[] arr = new int[count];
                bool truth = true;
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Введите {i + 1}-ое число массива: ");
                    if (int.TryParse(Console.ReadLine(), out int temp))
                    {
                        arr[i] = temp;
                    }
                    else
                    {
                        Console.WriteLine("Некоректный ввод");
                        truth = false;
                        break;
                    }
                }
                if (truth)
                {
                    int prod = 1;
                    Console.WriteLine($"Сумма элементов массива = {Calculation_of_list_parameters(ref prod, out int avg, arr)}");
                    Console.WriteLine($"Произведение элементов массива = {prod}");
                    Console.WriteLine($"Среднее арифметическое массива = {avg}");
                }
                else
                {
                    Console.WriteLine($"Неправильно введено число");
                }

            }
            else
            {
                Console.WriteLine("Некоректный ввод");
            }
            Console.ReadKey();
        }
    }
}