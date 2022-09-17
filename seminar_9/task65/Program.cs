// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void NumbersRec(int m, int n)
{
    Console.Write(m);
    if (m < n)
    {
        Console.Write(", ");
        NumbersRec(++m, n);
    }
}

Console.Write("Enter the number m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NumbersRec(numberM, numberN);

// ВТОРОЙ ВАРИАНТ

// void ShowNumbers(int start, int end, string lineToPrint)
// {
//     if (start == end)
//     {
//         lineToPrint = start.ToString() + lineToPrint;
//         Console.Write($"{lineToPrint}");
//     }
//     else
//     {
//         lineToPrint = ", " + end.ToString() + lineToPrint;
//         ShowNumbers(start, end - 1, lineToPrint);
//     }
// }

// Console.Write("Enter the number m: ");
// int numberM = int.Parse(Console.ReadLine());
// Console.Write("Enter the number n: ");
// int numberN = int.Parse(Console.ReadLine());

// ShowNumbers(numberM, numberN, "");
