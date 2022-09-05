// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = (new Random().Next(minValue, maxValue));
    }
    return res;
}

int[] BubbleSort(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[i] < array[k])
            {
                temp = array[i];
                array[i] = array[k];
                array[k] = temp;
            }                   
        }            
    }
    return array;
}

Console.Write("Enter the length of the array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] myArray = GetArray(arraySize, -10, 11);
Console.WriteLine(String.Join("; ", myArray));

int[] bubble = BubbleSort(myArray);
Console.WriteLine(String.Join("; ", bubble));
