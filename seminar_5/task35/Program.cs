// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ElementsCount(int[] arr)
{
    int counter = 0;
    foreach (var item in arr)
    {
        if (item >= 10 && item <= 99)
            counter++;
    }
    return counter;
}

int[] myArray = GetArray(123, -100, 100);
Console.WriteLine(String.Join(", ", myArray));

int result = ElementsCount(myArray);
Console.WriteLine($"Number of numbers from the range: {result}");

// Второй вариант (другой группы)

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// bool FindNumber(int[] array, int num)
// {
//     foreach (int el in array)
//     {
//         if (el == num)
//         return true;
//     }
//     return false;
// }

// Console.Write("Enter the length of the array: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the beginning of the range: ");
// int arrayStart = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the end of the range: ");
// int arrayEnd = Convert.ToInt32(Console.ReadLine());
// int[] newArray = GetArray(arraySize, arrayStart, arrayEnd);

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Array: {String.Join(", ", newArray)}");

// if (FindNumber(newArray, number))
// Console.WriteLine("Yes");
// else
// Console.WriteLine("Not");