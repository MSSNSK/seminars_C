// 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите первое число: ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) // (амперсанд) & - проверяет все возможные условия, 
                                   //                  даже если ондно не удовлетворяет
                                   // && - проверяет условия последовательно, 
                                   // до первого отрицания или полного удовлетворения
                                   // || - или
{
    Console.WriteLine("Кратно");
}
else
{ 
   Console.WriteLine("Не кратно");
}