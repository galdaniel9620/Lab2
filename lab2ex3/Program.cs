//Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura.

Console.WriteLine("Add a number x:");
int x = int.Parse(Console.ReadLine());
int count = 0;

while (x != 0) {
    x = x / 10; 
    count++;
}

string str = (count > 1) ? $"Number has {count} digits" : $"Number has {count} digit";

Console.WriteLine(str);   