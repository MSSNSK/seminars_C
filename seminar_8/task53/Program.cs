// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

int[,] GetArray(int rowArray, int columnArray, int minValue, int maxValue)
{
    int[,] result = new int[rowArray, columnArray];

    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnArray; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] SwapFirstAndLastRow (int[,] array)
{
    int lastRowIndex = array.GetLength(0) - 1;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temporary = array[0, i];
        array[0, i] = array[lastRowIndex, i];
        array[lastRowIndex, i] = temporary;
    }
    return array;
}

Console.Write("Enter the number of rows in the array: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the array: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GetArray(row, column, min, max);
PrintArray(myArray);

SwapFirstAndLastRow(myArray);

Console.WriteLine();
PrintArray(myArray);