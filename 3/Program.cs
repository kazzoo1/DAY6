using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы N (N < 10): ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N >= 10)
        {
            Console.WriteLine("N должно быть меньше 10.");
            return;
        }

        Console.Write("Введите нижнюю границу диапазона a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите верхнюю границу диапазона b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите нижнюю границу промежутка C: ");
        int C = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите верхнюю границу промежутка D: ");
        int D = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[N, N];
        Random rand = new Random();
        long product = 1;
        bool isProductEmpty = true;

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");

                if (matrix[i, j] >= C && matrix[i, j] <= D)
                {
                    product *= matrix[i, j];
                    isProductEmpty = false;
                }
            }
            Console.WriteLine();
        }

        if (isProductEmpty)
        {
            Console.WriteLine("В заданном промежутке нет элементов для вычисления произведения.");
        }
        else
        {
            Console.WriteLine("Произведение чисел в промежутке [C, D]: " + product);
        }

        Console.WriteLine("Сумма элементов каждого столбца:");
        for (int j = 0; j < N; j++)
        {
            int columnSum = 0;
            for (int i = 0; i < N; i++)
            {
                columnSum += matrix[i, j];
            }
            Console.WriteLine("Столбец " + (j + 1) + ": " + columnSum);
        }
    }
}
