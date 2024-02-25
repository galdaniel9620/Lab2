//Scrieti un program care va determina daca un numar este sau nu palindrom.
//23432



Console.WriteLine("Add a number number:");
int number = int.Parse(Console.ReadLine());
int reverse = 0;
int original = number;

while (number > 0)
{
    reverse = reverse * 10 + number %10;
    number /= 10;
}

if (original == reverse)  {
    Console.WriteLine($"{original} is a palindrome number.");
}
else
{
    Console.WriteLine($"{original} is not a palindrome number.");
}
