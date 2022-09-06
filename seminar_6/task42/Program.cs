// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string Binary(int num)
{
    string binaryNum = String.Empty;
    while (num > 0)
    {
        if(num % 2 == 1) binaryNum += "1";
        else binaryNum += "0";
        num /= 2;
    }
    return binaryNum;
}

string ReverseBinary(string stringNum)
{
    string temp = String.Empty;

    for (int i = stringNum.Length -1; i >= 0; i--)
    {
        temp += stringNum[i];
    }
    return temp;
}

Console.Write("Enter a decimal number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ReverseBinary(Binary(number)));

