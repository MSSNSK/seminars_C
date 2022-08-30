// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());

int sqr1 = (x1 - x2) * (x1 - x2);
int sqr2 = (y1 - y2) * (y1 - y2);

double res = Math.Sqrt(sqr1 + sqr2); //Math.Sqrt - всегда возвращает значение в double(дробное число)

Console.WriteLine($"{res:f2}"); // :f2 - округление до количества символов после запятой в doudle