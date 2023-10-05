using System;

namespace Laboratory_work
{
    internal class Program
    {
        public static int Selects_the_largest_number(int first_number, int second_number)
        {
            if (first_number > second_number)
            {
                return first_number;
            }
            return second_number;
        }

        public static void Changes_the_value_of_two_variables(ref string first_variable, ref string second_variable)
        {
            string temp = first_variable;
            first_variable = second_variable;
            second_variable = temp;
        }

        public static void Calculating_the_factorial(ulong factorial_end, out ulong factorial)
        {
            checked
            {
                factorial = 1;
                for (ulong i = 1; i <= factorial_end; i++)
                {
                    factorial *= i;
                }
            }
        }

        public static ulong Recursive_factorial_calculation(ulong number)
        {
            if (number == 1)
            {
                return 1;
            }
            return checked(number * Recursive_factorial_calculation(number - 1));
        }

        public static uint? Calculating_the_Fibonacci_number(ulong number)
        {
            if (number == 0)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            return Calculating_the_Fibonacci_number(number - 1) + Calculating_the_Fibonacci_number(number - 2);
        }

        public static uint Calculation_gratest_common_division(uint number_1, uint number_2)
        {
            while (number_1 % number_2 != 0)
            {
                uint temp = number_2;
                number_2 = number_1 % number_2;
                number_1 = temp;
            }
            return number_2;
        }

        static void Main(string[] args)
        {
            // Упражнение 5.1
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("В это упражнии программа получает на вход 2 числа и возвращает большее из них");
            Console.Write("Ввекдите первое число и нажмите enter: ");
            bool truth_of_first_number = int.TryParse(Console.ReadLine(), out int first_number);
            Console.Write("Ввекдите второе число и нажмите enter: ");
            bool truth_of_second_number = int.TryParse(Console.ReadLine(), out int second_number);
            if (truth_of_first_number && truth_of_second_number)
            {
                Console.WriteLine(Selects_the_largest_number(first_number, second_number));
            }
            else
            {
                Console.WriteLine("Вы неправильно указали числа");
            }
            // Упражнение 5.2
            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("В это упражнении программа местами значения двух передаваемых параметров");
            Console.Write("Ввекдите первый параметр и нажмите enter: ");
            string first_variable = Console.ReadLine();
            Console.Write("Ввекдите второй параметр и нажмите enter: ");
            string second_variable = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(first_variable) || !String.IsNullOrWhiteSpace(second_variable))
            {
                Changes_the_value_of_two_variables(ref first_variable, ref second_variable);
                Console.WriteLine($"{first_variable} {second_variable}");
            }
            else
            {
                Console.WriteLine("Вы ввели пустой параметр");
            }

            // Упражнение 5.3
            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("Эта программа получает на вход число, которое проеобразуется в факториал");
            Console.WriteLine("Введите число, которое нужно превратить в факториал и нажмите enter: ");
            string number = Console.ReadLine();
            if (ulong.TryParse(number, out ulong to_factorial)) { }
            try
            {
                Calculating_the_factorial(to_factorial, out ulong factorial);
                Console.WriteLine($"Факториал заданного числа: {factorial}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Факториал заданного числа слишком большой. Переполнение");
            }

            // Упражнение 5.4
            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Программа вычисляет факториал числа рекурсивно");
            Console.Write("Введите число, факториал которого хотите найти: ");
            bool truth_number_to_factorial = ulong.TryParse(Console.ReadLine(), out ulong number_to_factorial);
            if (truth_number_to_factorial)
            {
                try
                {
                    Console.WriteLine($"Факториал заданного числа: {Recursive_factorial_calculation(number_to_factorial)}");
                }
                catch (StackOverflowException)
                {
                    Console.WriteLine("Слишком большое вводное число. Переполнение");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Факториал слишком большой. Переполнение");
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }

            // Домашнее задание 5.1
            Console.WriteLine("Домашнее задание 5.1");
            Console.WriteLine("Программа вычисляет НОД двух чисел");
            Console.Write("Введите первое число: ");
            bool truth_of_number_1 = uint.TryParse(Console.ReadLine(), out uint number_1);
            Console.Write("Введите первое число: ");
            bool truth_of_number_2 = uint.TryParse(Console.ReadLine(), out uint number_2);
            Console.Write("Введите второе число: ");
            try
            {
                if (truth_of_number_1 && truth_of_number_2)
                {
                    if ((number_1 != 0) & (number_2 != 0))
                    {
                        Console.WriteLine($"НОД этих чисел: {Calculation_gratest_common_division(number_1, number_2)}");
                    }
                    else
                    {
                        Console.WriteLine("Число(а) меньше нуля");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                }
                    
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Переполнение, слишком большое число");
            }

            // Домашнее задание 5.2
            Console.WriteLine("Домашнее задание 5.2");
            Console.WriteLine("Программа рекурсивно вычисляет число Фибоначчи");
            Console.Write("Введите номер числа из ряда Фибоначчи: ");
            if (ulong.TryParse(Console.ReadLine(), out ulong numberr))
            {
                {
                    try
                    {
                        Console.WriteLine(Calculating_the_Fibonacci_number(numberr));
                    }
                    catch (StackOverflowException)
                    {
                        Console.WriteLine("Слишком много операций. Переполнение");
                    }
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
}