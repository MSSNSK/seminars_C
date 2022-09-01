// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowNum(int number, int power)
{
    int result = number;
    power--;
    while (power > 0)
    {
        result = result * number;
        power--;
    }
    return result;
}

Console.WriteLine("Enter a number (natural): ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the degree of the number (natural number): ");
int pow = int.Parse(Console.ReadLine());

if(pow > 0)
{
    int result = PowNum(num, pow);
    Console.WriteLine($"{num}, {pow} -> {result} ({num}^{pow})");
}
else
{
    Console.WriteLine($"Number {pow} is not natural!");
}