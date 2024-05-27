using System;

class Program
{
    static void Main()
    {
        // Предположим, что массив целых чисел уже задан.
        int[] array = { 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Порядковые номера нечетных элементов массива:");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                // Выводим порядковый номер, который на 1 больше индекса.
                Console.WriteLine(i + 1);
            }
        }
    }
}
