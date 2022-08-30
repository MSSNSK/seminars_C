Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int current = -num;
while (current <= num)
{
    Console.Write($"{current} ");
    current++;
}