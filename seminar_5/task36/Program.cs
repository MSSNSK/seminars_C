// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int SumElOddIndex(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Enter the length of the array: ");
int arraySize = int.Parse(Console.ReadLine());

int[] myArray = GetArray(arraySize, -100, 101);
Console.WriteLine(String.Join(", ", myArray));

int result = SumElOddIndex(myArray);
Console.WriteLine($"Sum of elements with odd indices: {result}");
