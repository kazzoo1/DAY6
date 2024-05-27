using System;

class Program
{
    // Рекурсивная функция для вычисления факториала числа
    static long Factorial(int n)
    {
        // Базовый случай
        if (n <= 1) return 1;
        // Рекурсивный случай
        return n * Factorial(n - 1);
    }

    // Функция для вычисления f(n)
    static double CalculateFunction(int n)
    {
        return 1.0 / Factorial(n + 1);
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите целое неотрицательное число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                throw new ArgumentException("Число должно быть неотрицательным.");
            }

            double result = CalculateFunction(n);
            Console.WriteLine($"f({n}) = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено не числовое значение.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
