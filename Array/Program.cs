// Problem_1

Console.Write("enter array size: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("enter number " + (i + 1) + ": ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("The array elements are: ");

for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine();