// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ProductionArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 != 0) size++;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) result[size - 1] = array[array.Length / 2];
    return result;
}

Console.Write("Enter the length of the array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the beginning of the range: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the end of the range: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(arraySize, arrayStart, arrayEnd);
int[] changeArray = ProductionArray(newArray);
Console.WriteLine($"Array: {String.Join(" ", newArray)}");
Console.WriteLine($"Result: {String.Join(" ", changeArray)}");