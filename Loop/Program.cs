// Problem_1

Console.Write("enter a number: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(num + " x " + (i + 1) + " = " + (num * (i + 1)));
}

Console.WriteLine();
