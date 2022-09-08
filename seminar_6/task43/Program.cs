// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// Можно было написать ещё короче, используя в качестве первичных переменных var,
// но так так как на семинарах это не делали, использовал тип string с дальнейшим преобразованием.


Console.Write("Введите k1: ");
string num1 = Console.ReadLine();
Console.Write("Введите b1: ");
string num2 = Console.ReadLine();
Console.Write("Введите k2: ");
string num3 = Console.ReadLine();
Console.Write("Введите b2: ");
string num4 = Console.ReadLine();

double k1 = Convert.ToDouble(num1);
double b1 = Convert.ToDouble(num2);
double k2 = Convert.ToDouble(num3);
double b2 = Convert.ToDouble(num4);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

if (k1 == k2 && b1 == b2) Console.WriteLine("Directly coincide.");
else if (k1 == k2) Console.WriteLine("The straight lines are parallel.");
else Console.WriteLine($"The intersection point of two lines: ({x}; {y}).");



// ВАРИАНТ РЕЩЕНИЯ ЧЕРЕЗ ФУНКЦИЮ

void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.Write("Прямые не пересекаются");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * b1 - k1 * b2) / (k2 - k1);
        Console.WriteLine($"Точка пересечения прямых ({x}; {y})");
    }
}

Console.Write("Введите b1: ");
double numberB1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double numberK1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double numberB2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double numberK2 = double.Parse(Console.ReadLine());
FindIntersectionPoint(numberB1, numberK1, numberB2, numberK2);