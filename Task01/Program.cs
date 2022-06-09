// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

int[,] ChangeFirstLastRows(int[,] arr)
{
    int a = arr.GetLength(0);
    int b = arr.GetLength(1);
    int c = 0;
    for (int j = 0; j < b; j++)
    {
        c = arr[0, j];
        c = arr[a - 1, j];
        arr[a - 1, j] = arr[0, j];
        arr[0, j] = c;
    }
    return arr;
}

int[,] myArray = new int[7, 7];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
ChangeFirstLastRows(myArray);
PrintArray(myArray);
