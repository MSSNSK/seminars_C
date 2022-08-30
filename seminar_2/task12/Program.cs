// 12. Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int num3 = num1 % num2;
if (num3 == 0)
{
    Console.WriteLine("Кратно");
}
else
{ 
   Console.WriteLine($"Не кратно, остаток {num3}");
}