Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()); первый вариант решения (пока правильный)
// int result = num % 10;
string num = Console.ReadLine(); // второй вариант
string result = num.Remove (0, 2);
Console.WriteLine(result);