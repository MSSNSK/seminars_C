// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

// Второй вариант (оптимизированный)

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Copyarray(int[] array)
{
    int[] copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

Console.Write("Enter the length of the array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the beginning of the range: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the end of the range: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());

int[] newArray = GetArray(arraySize, arrayStart, arrayEnd);

Console.WriteLine($"Array: [{String.Join(", ", newArray)}]");
Console.WriteLine($"A copy of the array: [{String.Join(", ", Copyarray(newArray))}]");