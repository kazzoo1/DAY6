using System;

class Program
{
    static void Main()
    {
        // Создаем и заполняем массив случайными числами от -100 до 100
        int[] numbers = new int[100];
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(-100, 101);
        }

        // Печатаем отрицательные числа
        Console.WriteLine("Отрицательные числа:");
        foreach (int number in numbers)
        {
            if (number < 0)
            {
                Console.Write(number + " ");
            }
        }

        // Печатаем неотрицательные числа
        Console.WriteLine("\nНеотрицательные числа:");
        foreach (int number in numbers)
        {
            if (number >= 0)
            {
                Console.Write(number + " ");
            }
        }
    }
}
