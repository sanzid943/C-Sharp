// Problem_1

List<string> names = new List<string>();

Console.Write("how many students? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("enter name of student " + (i + 1) + ": ");
    names.Add(Console.ReadLine());
}

Console.WriteLine("the names of the students are:");

foreach (string name in names)
{
    Console.WriteLine(name);
}