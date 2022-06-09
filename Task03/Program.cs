// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumRow(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int minSum = 0;
    int row = 0;
    for (int j = 0; j < y; j++) minSum = minSum + array[0, j];
    for (int i = 1; i < x; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < y; j++) rowSum = rowSum + array[i, j];
        if (rowSum < minSum)
        {
            minSum = rowSum;
            row = i;
        }
    }
    Console.WriteLine($"Minimal sum: {minSum}");
    Console.WriteLine($"Row: {row}");
}

int[,] arr = new int[5, 7];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
MinSumRow(arr);
