// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int EvenNumbers(int[] array)
{
    int count = 0;
    
    foreach (int el in array)
    {
        if (el % 2 == 0)
        count++;
    }
    return count;
}

Console.Write("Enter the length of the array: ");
int arraySize = int.Parse(Console.ReadLine());

int[] myArray = GetArray(arraySize, 100, 1001);
Console.WriteLine(String.Join(", ", myArray));

int result = EvenNumbers(myArray);
Console.WriteLine($"The number of even numbers in the array: {result}");