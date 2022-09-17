// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowNumber(int a, int b)
{
    if (b != 1) a *= PowNumber(a, --b);
    return a;
}

Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the degree of number: ");
int pow = Convert.ToInt32(Console.ReadLine());

if (pow == 0) Console.WriteLine(1);
else if ((pow == 1) || (num == 1 || num == 0)) Console.WriteLine(num);
else Console.WriteLine(PowNumber(num, pow));

// ВТОРОЙ ВАРИАНТ

// int Power(int a, int b)
// {
//     if (a == 0)
//         return 1;

//     if (b == 0)
//         return 1;

//     return a * Power(a, b - 1);
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the degree of number: ");
// int pow = Convert.ToInt32(Console.ReadLine());

// int powNum = Power(num, pow);
// Console.WriteLine(powNum);