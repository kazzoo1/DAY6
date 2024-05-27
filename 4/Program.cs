using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив для хранения зарплаты 18 человек за каждый месяц года
        int employees = 18, months = 12;
        int[,] salaries = new int[employees, months];
        Random rand = new Random();

        // Заполняем массив случайными значениями зарплаты от 50000 до 200000 для примера
        for (int i = 0; i < employees; i++)
        {
            for (int j = 0; j < months; j++)
            {
                salaries[i, j] = rand.Next(50000, 200001); // В диапазоне от 50 000 до 200 000
            }
        }

        // Вычисляем годовой доход первого человека
        int annualIncome = 0;
        for (int i = 0; i < months; i++)
        {
            annualIncome += salaries[0, i];
        }

        Console.WriteLine("Введите заданное число для сравнения с годовым доходом первого человека:");
        int specifiedNumber = Convert.ToInt32(Console.ReadLine());

        // Проверяем, верно ли, что годовой доход первого человека больше заданного числа
        if (annualIncome > specifiedNumber)
        {
            Console.WriteLine($"Годовой доход первого человека ({annualIncome}) больше заданного числа ({specifiedNumber}).");
        }
        else
        {
            Console.WriteLine($"Годовой доход первого человека ({annualIncome}) не больше заданного числа ({specifiedNumber}).");
        }
    }
}
