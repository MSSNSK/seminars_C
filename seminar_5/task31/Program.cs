// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] PositiveAndNegativeSum(int[] array)
{
    int[] res = new int [2];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            res[0] += array[i];
        }
        else
        {
            res[1] += array[i];
        }
    }

    return res;
}

// void PositiveSum(int[] array) - второй вариант (упрощённый) на нахождение суммы через оператор foreach
// {
//     int positiveSum = 0;

//     foreach(int el in array)
//     {
//         positiveSum += el > 0 ? el : 0;  // - тернарный оператор    if (el > 0)
//                                                                 //  {
//                                                                 //     positiveSum += el;
//                                                                 //  }
//                                                                 //  else
//                                                                 //  {
//                                                                 //     positiveSum += 0;
//                                                                 //  }
//     }
//     Console.WriteLine($"{positiveSum}");
// }

int[] myArray = GetArray(10, -100, 100);
int[] result = PositiveAndNegativeSum(myArray);
Console.WriteLine(String.Join(", ", myArray));
Console.WriteLine(String.Join(", ", result));
// PositiveSum(myArray); - вывод к варианту через foreach