// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumRec(int n, int result = 0)
{
    if (n != 0)
    {
        result += n % 10 + SumRec(n / 10, result);
    }
    return result;
}

Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = SumRec(num);
Console.WriteLine(sum);


// ВТОРОЙ ВАРИАНТ

// int SumRec(int n, int result = 0)
// {
//     if (n == 0) return 0;
//     return n % 10 + SumRec(n / 10, result);
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int sum = SumRec(num);
// Console.WriteLine(sum);


// ТРЕТИЙ ВАРИАНТ

// int SumRec(int n)
// {
//     return n == 0 ? 0 : n % 10 + SumRec(n / 10);
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int sum = SumRec(num);
// Console.WriteLine(sum);