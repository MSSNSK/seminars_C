// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNums(int number)
{
    int result = 0;
    while (number != 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"The sum of digits in a number {num} -> {SumNums(num)}");