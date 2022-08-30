// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int MultNums(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{MultNums(num)}");