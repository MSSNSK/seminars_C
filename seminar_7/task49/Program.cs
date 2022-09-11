// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив             Новый массив будет выглядеть 
// вот так:                                выглядел вот так:   
// 1 4 7 2                                 1 4 49 2
// 5 9 2 3                                 5 81 2 9
// 8 4 2 4                                 64 4 4 4

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArrayEvenInPower(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows += 2)
    {
        for (int cols = 0; cols < array.GetLength(1); cols += 2)
        {
            array[rows, cols] *= array[rows, cols];
        }    
    }
}

Console.WriteLine("Enter the number of rows of the array: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of array columns: ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n);
PrintArray(myArray);

ArrayEvenInPower(myArray);
Console.WriteLine();
PrintArray(myArray);
