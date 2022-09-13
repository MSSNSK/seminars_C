// адача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.

// Например, задан массив:                 Наименьший элемент - 1, на выходе получим 
// 1 4 7 2                                 следующий массив:
// 5 9 2 3                                 9 4 2
// 8 4 2 4                                 2 2 6
// 5 2 6 7                                 3 4 7

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

int[] FindMinimum(int[,] array, int[] minArray)
{
    int minimumNumber = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minimumNumber > array[i, j])
            {
                minimumNumber = array[i, j];
                minArray[0] = i;
                minArray[1] = j;
            }
        }
    }
    return minArray;
}

int[,] ChangeArray(int[,] array, int[] deleteArray)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0, l = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != deleteArray[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != deleteArray[1])
                {
                    result[k, l] = array[i, j];
                    l++;
                }
            }
            l = 0;
            k++;
        }
    }
    return result;
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

int[] minimumPosition = new int[2];
minimumPosition = FindMinimum(myArray, minimumPosition);

int[,] resultArray = ChangeArray(myArray, minimumPosition);

Console.WriteLine();
PrintArray(resultArray);