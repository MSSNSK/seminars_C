Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == -num % 2)
{
    Console.WriteLine($"{num} - чётное число!");
}
else
{
    Console.WriteLine($"{num} - нечётное число!");
}