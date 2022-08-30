// 16. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
if (num * num == num1 || num1 * num1 == num) 
{
    Console.WriteLine("Да");
}
else
{ 
   Console.WriteLine("Нет");
}