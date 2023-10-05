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

        public static string String_conversion(string str, int m)
        {
            if (m != 0)
            {
                string temp = str;
                for (int i = 0; i < (m - 1); i++)
                {
                    str += temp;
                }
                return str;
            }
            else
            {
                return "";
            }
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

            // Упражнение 3
            Console.WriteLine("Упражнение 3");
            Console.WriteLine("Эта программа рисует число в виде # и или выходит если набрано exit или закрыть");
            Console.WriteLine("Введите число от 0 до 9 или закрыть или exit и нажмите enter: ");
            string enterd_number = Console.ReadLine().ToLower();
            if (byte.TryParse(enterd_number, out byte number))
            {
                if ((number >= 0) & (number <= 9))
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (i == 2)
                        {
                            Console.WriteLine("  " + String_conversion(number.ToString(), 12));
                        }
                        if (i == 4)
                        {
                            Console.WriteLine(String_conversion(number.ToString(), 12));
                        }
                        else
                        {
                            Console.WriteLine($"{String_conversion(" ", (6 - i))}{number}      {number}");
                        }
                    }
                }
                else if ((enterd_number.Equals("exit")) || (enterd_number.Equals("выход")))
                {
                    Console.WriteLine("Работа завершена");
                }
                else if ((number < 0) || (number > 9))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(String_conversion(" ", 100));
                    Thread.Sleep(3000);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.ReadKey();
        }
    }
}