// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;    
}

Console.Write("Enter the side a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the side b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the side c: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (Triangle(num1, num2, num3)) Console.Write("It may exist.");
else Console.Write("Cannot exist.");