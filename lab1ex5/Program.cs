//Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra

Console.WriteLine("Enter the number of elements:");
int x =int.Parse (Console.ReadLine());

int sum = 0;
int count = 0;

if ( x <= 0) return;

for (int i = 0; i < x; i++)
{
    Console.WriteLine($"Enter number {i + 1}:");
    int number = int.Parse(Console.ReadLine());
    if (number % 2 == 0)
    {
        sum += number;
        count++;
    }
}

double averageOfEvenNumbers  = sum / count;

if (count == 0)
{
    Console.WriteLine("No even numbers were entered.");
}
else
{
    Console.WriteLine($"The arithmetic mean of the even numbers is: {averageOfEvenNumbers}");
}