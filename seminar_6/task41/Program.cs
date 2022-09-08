// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// -1, -7, 567, 89, 223 -> 3


int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} element of an array with index {i}: ");
        res[i] = Convert.ToInt32(Console.ReadLine());
    }
    return res;
}

int PositiveNumber(int[] array)
{
    int count = 0;

    foreach (int el in array)
    {
        if (el > 0)
        count++;
    }
    return count;
}

Console.Write("Enter the number of array elements: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] newArray = GetArray(arraySize);
Console.WriteLine($"The introduced array: [{String.Join(", ", newArray)}]");

int result = PositiveNumber(newArray);
Console.WriteLine($"In the array {result} positive number(s).");

if (arraySize == 0) Console.WriteLine("Input error, the array must contain more than 0 elements!");