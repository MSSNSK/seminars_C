// Задача 29: Напишите программу, которая задаёт массив из N элементов, 
// заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]


int [] Array(int number, int initial, int fin)
{   
    int [] arr = new int [number];
    for(int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(initial, fin);
    }
    return arr;
}

Console.WriteLine("Enter the number of array elements: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the initial element of the array: ");
int init = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the final element of the array: ");
int final = int.Parse(Console.ReadLine());

int number = num;
int initial = init;
int fin = final;

if (final < init)
{
    Console.WriteLine("Input error, the initial element is larger than the final one!");
}
else if (num == 0)
{
    Console.WriteLine("Input error, the array must contain more than 0 elements!");
}
else
{
    Console.WriteLine(String.Join(", ", Array(number, initial, fin)));
}


// РАНЕЕ СДАННЫЕ ВАРИАНТЫ

// int [] Array()
// {   
//     Console.WriteLine("Enter the number of array elements: ");
//     int num = int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the initial element of the array: ");
//     int init = int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the final element of the array: ");
//     int final = int.Parse(Console.ReadLine());

//     int [] arr = new int [num];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr [i] = new Random().Next(init, final);
//     }
//     return arr;
// }

// Console.WriteLine(String.Join(", ", Array()));


// ВТОРОЙ ВАРИАНТ, НО В ДАННОМ СЛУЧАЕ БЛОК ВВОДА ПЕРЕМЕННЫХ ПРИШЛОСЬ ВЫНЕСТИ ПЕРЕД БЛОКОМ ФУНКЦИИ, ИНАЧЕ НЕ ОТРАБАТЫВАЛЫ ПРОВЕРКА УСЛОВИЙ НА НЕКОРРЕКТНЫЙ ВВОД. 
// А ПРИ РАЗМЕЩЕНИИ БЛОКА ВВОДА ПЕРЕМЕННЫХ НИЖЕ БЛОКА ФУНКЦИИ, НЕ ОТРАБАТЫВАЛА САМА ФУНКЦИЯ.  


// Console.WriteLine("Enter the number of array elements: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the initial element of the array: ");
// int init = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the final element of the array: ");
// int final = int.Parse(Console.ReadLine());

// int [] Array()
// {   
//     int [] arr = new int [num];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr [i] = new Random().Next(init, final);
//     }
//     return arr;
// }

// if (final < init)
// {
//     Console.WriteLine("Input error, the initial element is larger than the final one!");
// }
// else if (num == 0)
// {
//     Console.WriteLine("Input error, the array must contain more than 0 elements!");
// }
// else
// {
//     Console.WriteLine(String.Join(", ", Array()));
// }