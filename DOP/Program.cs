using System;

class Program
{
    static void SpiralFill(int size, int[,] matrix)
    {
        int num = 1;
        int startColumn = 0, endColumn = size - 1;
        int startRow = 0, endRow = size - 1;

        while (startColumn <= endColumn && startRow <= endRow)
        {
            for (int i = startColumn; i <= endColumn; i++)
            {
                matrix[startRow, i] = num++;
            }
            startRow++;

            for (int i = startRow; i <= endRow; i++)
            {
                matrix[i, endColumn] = num++;
            }
            endColumn--;

            for (int i = endColumn; i >= startColumn; i--)
            {
                matrix[endRow, i] = num++;
            }
            endRow--;

            for (int i = endRow; i >= startRow; i--)
            {
                matrix[i, startColumn] = num++;
            }
            startColumn++;
        }
    }

    static void Main()
    {
        const int size = 7;
        int[,] matrix = new int[size, size];

        SpiralFill(size, matrix);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }
    }
}
