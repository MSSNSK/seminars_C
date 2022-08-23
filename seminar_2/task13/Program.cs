// Задача 13: Напишите программу, которая выводит третью цифру (слева направо) 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 6

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100) 
{
    Console.WriteLine("Третьей цифры нет.");
}
else if (num >= 100)
{
int num1 = num / 100;
int res = num1 % 10;
Console.WriteLine($"{num} -> {res}");
}