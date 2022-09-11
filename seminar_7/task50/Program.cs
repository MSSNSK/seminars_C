// Задача 50. Напишите программу, которая на вход принимает число и 
// генерирует случайный двумерный массив, и возвращает индексы этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 11);
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

void SearchNumberInArray(int[,] array, int numberRequested)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == numberRequested)
            {
                Console.WriteLine($"Number {numberRequested} has indexes [{i}, {j}]");
                return;
            }
        }
    }
    Console.Write($"Number {numberRequested} there is no array.");
}

Console.Write("Enter the number to search: ");
int numbSearch = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of rows (at least two): ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns (at least two): ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);

SearchNumberInArray(myArray, numbSearch);