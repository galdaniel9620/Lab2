// Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura

Console.WriteLine("Add a number:");
int num = int.Parse(Console.ReadLine());
long factorial = 1;

if (num > 0)
{
    for (int i = num; i > 0; i--)
    {
        factorial *= i;
    }
    Console.WriteLine($"Factorial is: {factorial}");
}
else
{
    Console.WriteLine("Add a pozitiv number");
}

