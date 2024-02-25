//Ex 1: Scrieti un program care va calcula valoarea urmatoarei functii pentru

Console.WriteLine("Add a number x:");
double x = double.Parse(Console.ReadLine());

double result = (x <= -2) ? 7 * Math.Pow(x, 2) : (x > 1 / 2) ? 14 * x - 7 : 4 * x - 5;

Console.WriteLine($"Result is: {result}");
