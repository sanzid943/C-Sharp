// Problem_1

Console.Write("enter a number: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(num + " x " + (i + 1) + " = " + (num * (i + 1)));
}

Console.WriteLine();



// Problem_2

Console.Write("enter a number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.Write(i + " ");
}

Console.WriteLine();



// Problem_3

Console.Write("enter a number: ");
int number = int.Parse(Console.ReadLine());

int i = 1;
while (i < number)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine();




// Problem_4

string password;

do
{
    Console.Write("enter password: ");
    password = Console.ReadLine();

} while (password != "admin123");

Console.WriteLine("Access granted.");



// Problem_5

Console.Write("how many numbers do you want to enter: ");
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("enter number " + (i + 1) + ": ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();

foreach (int number in numbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();
