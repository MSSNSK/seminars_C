// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// 
// Например, задан массив:
// 1 4 7 2                         Сумма элементов главной 
// 5 9 2 3                         диагонали: 1+9+2 = 12
// 8 4 2 4

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
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void diagonalArrayElementsSum(int[,] array)
{
    int summ = 0;

    for (int diagonalPosition = 0; diagonalPosition < array.GetLength(0); diagonalPosition++)
    {
        summ = summ + array[diagonalPosition, diagonalPosition];
    }
    Console.WriteLine($"The sum of the diagonal elements of the array is equal {summ}");
}

Console.WriteLine("Enter the number of rows of the array: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of array columns: ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n);
PrintArray(myArray);

Console.WriteLine();

diagonalArrayElementsSum(myArray);
Console.WriteLine();
