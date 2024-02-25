//Ex 2: Scrieti un program care va determina daca un numar negativ citit de la tastatura este divizibil cu 2 si nu este divizibil cu 6

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Add a number x:");
int x = int.Parse(Console.ReadLine());

if (x < 0)
{
    if (x % 2 == 0 && x % 6 != 0)
    {
        Console.WriteLine("The entered number is divisible by 2 and not divisible by 6.");
    }
    else
    {
        Console.WriteLine("The entered number does not meet the specified conditions.");
    }
}else
{
    Console.WriteLine("The entered number is not negative.");
}