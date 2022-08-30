// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int current = 1;
while (current <= num)                           // - первый вариант решения
{
    Console.Write($"{current * current}, ");
    current++;
}
Console.WriteLine();

for (int i=1; i<=num; i++)                       // - второй вариант решения
{
    Console.Write($"{i*i}, ");
}
 Console.WriteLine();