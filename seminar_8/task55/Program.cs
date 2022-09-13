// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки 
// на столбцы. В случае, если это невозможно, программа должна 
// вывести сообщение для пользователя.

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

int[,] SwapRowsAndColumns(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];

    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                tempArray[j, i] = array[i, j];
            }
        }
        return tempArray;
    }
    else
    {
     Console.WriteLine("It is impossible to replace the rows with columns!");
     return array;
    }
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

Console.WriteLine();
int[,] changetArray = SwapRowsAndColumns(myArray);
PrintArray(changetArray);