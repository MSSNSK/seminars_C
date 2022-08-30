// // Задача 26: Напишите программу, которая принимает на вход число 
// // и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int QuanNumb(int number)
{
    int count = 0;
    while (number != 0)
    {
        count++;
        number = number / 10;
    } 
    return count;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{QuanNumb(num)}");