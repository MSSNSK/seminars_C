// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }        0 встречается 2 раза 
//                                   1 встречается 1 раз 
//                                   2 встречается 1 раз 
//                                   8 встречается 1 раз 
//                                   9 встречается 3 раза

// 1, 2, 3         1 встречается 3 раза 
// 4, 6, 1         2 встречается 2 раз 
// 2, 1, 6         3 встречается 1 раз 
//                 4 встречается 1 раз 
//                 6 встречается 2 раза

int[,] GetArray(int rowArray, int columnArray)
{
    int[,] result = new int[rowArray, columnArray];

    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnArray; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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

int[] TwoDimensionsToOne(int[,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            temp[k] = array[i, j];
            k++;
        }
    }
    return temp;
}

int[] SortUp(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }                   
        }            
    }
    return array;
}

void Countvalues(int[] inpArray)
{
    int counter = 1;

    for (int i = 0; i < inpArray.Length - 1; i++)
    {
        if (inpArray[i] == inpArray[i + 1])
        {
            counter++;
        }
        else
        {
            Console.WriteLine($"Value {inpArray[i]} - {counter} times in array.");
            counter = 1;
        }
    }
    Console.WriteLine($"Value {inpArray[inpArray.Length - 1]} - {counter} times in array.");
}

Console.Write("Enter the number of rows in the array: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the array: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Source array: ");

int[,] myArray = GetArray(row, column);

PrintArray(myArray);

int[] inputArray = new int[] {1, 9, 9, 0, 2, 8, 0, 9};

Console.WriteLine();
Console.WriteLine("Frequency dictionary: ");
int[] newArray = TwoDimensionsToOne(myArray);

SortUp(newArray);

Countvalues(newArray);
