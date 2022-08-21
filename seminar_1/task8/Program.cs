Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int current = 1;
while (current < num)
{
    current++;
    if (current % 2 == 0)
    {
        Console.Write($"{current} ");
    }
}