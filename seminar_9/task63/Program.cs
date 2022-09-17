// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void ShowNumbers(int digit, string lineToPrint)
{
    if (digit == 1)
    {
        lineToPrint = digit.ToString() + lineToPrint;
        Console.Write($"{lineToPrint}");
    }
    else
    {
        lineToPrint = ", " + digit.ToString() + lineToPrint;
        ShowNumbers(digit - 1, lineToPrint);
    }
}

Console.Write("Enter the number> 1: ");
int digit = int.Parse(Console.ReadLine());

if (digit < 1)
{
    Console.WriteLine("It was necessary to enter the number> 1!");
}
else
{
    ShowNumbers(digit, "");
}

// ВТОРОЙ ВАРИАНТ

// void NumbersRec(int n, int current = 1)
// {
//     Console.Write(current);
//     if (current < n)
//     {
//         Console.Write(", ");
//         NumbersRec(n, ++current);
//     }
// }

// Console.Write("Enter the number n: ");
// int number = Convert.ToInt32(Console.ReadLine());
// NumbersRec(number);