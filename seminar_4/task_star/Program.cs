// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки 
// и рисует ее в консоли звездочками.

int FirTree()
{
    Console.Write("Enter the height of the Christmas tree: ");
    int height = int.Parse(Console.ReadLine());
    
    int i, j, k;
    for (i = 1; i <= height; i++)
    {
        for (j = 1; j < height-i+1; j++)
        {
            Console.Write(" ");
        }
        for (k = 1; k <= i; k++)
        {
            Console.Write("*");
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    return (height); 
}    

Console.WriteLine("Merry Christmas & Happy New Year!", FirTree());

