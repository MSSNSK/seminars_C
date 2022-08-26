// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите положительное целое число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

while (count <= num)                                  // - первый вариант решения
{
    Console.Write($"{count * count * count}, ");
    count++;
}
Console.WriteLine();

for (int i=1; i<=num; i++)                              // - второй вариант решения
{
    Console.Write($"{i*i*i}, ");
}
 Console.WriteLine();