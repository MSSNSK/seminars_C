// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return res;
}

double MaxNumber(double[] array)
{
    double max = 0;

    for (int i = 0; i < array.Length; i++)
    {
       if (max < array[i]) max = array[i];
    }
    return max; 
}

double MinNumber(double[] array)
{
    double min = 0;

    for (int i = 0; i < array.Length; i++)
    {
       if (min > array[i]) min = array[i];
    }
    return min; 
}

Console.Write("Enter the length of the array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

double[] myArray = GetArray(arraySize, -100, 101);
Console.WriteLine(String.Join("; ", myArray));

double maxNumb = MaxNumber(myArray);
Console.WriteLine($"Maximum number: {maxNumb}");
double minNumb = MinNumber(myArray);
Console.WriteLine($"Minimum number: {minNumb}");

double numberDiff = maxNumb - minNumb;
Console.WriteLine($"The difference between the maximum and minimum elements of the array: {numberDiff}");