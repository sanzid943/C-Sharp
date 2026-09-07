// problem_1

HashSet<int> numbers = new HashSet<int>();

numbers.Add(124);
numbers.Add(345);
numbers.Add(765);
numbers.Add(754);

foreach (int i in numbers)
{
    Console.WriteLine(i);
}




// problem_2

HashSet<int> numbers = new HashSet<int>();

Console.Write("enter how many numbers: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    Console.Write("enter the number: ");
    int n = int.Parse(Console.ReadLine());

    numbers.Add(n);
}

Console.WriteLine();
foreach (int n in numbers)
{
    Console.Write(n + "  ");
}

Console.WriteLine();




// Problem_3

HashSet<string> names = new HashSet<string>();

names.Add("rahim");
names.Add("karim");
names.Add("rahim");
names.Add("rafiq");
names.Add("raju");

foreach (string name in names)
{
    Console.WriteLine(name);
}



// problem_4

HashSet<int> numbers = new HashSet<int>();

numbers.Add(235);
numbers.Add(235);
numbers.Add(763);
numbers.Add(645);

Console.Write("enter search item: ");
int n = int.Parse(Console.ReadLine());

if (numbers.Contains(n))
{
    Console.WriteLine("number is already exist");
}

else
{
    numbers.Add(n);
    Console.WriteLine("item not found, it's now added");
}

Console.WriteLine();
Console.WriteLine("the numbers are: ");

foreach (int num in numbers)
{
    Console.WriteLine(num);
}




// Problem_5

HashSet<int> set1 = new HashSet<int>()
{ 23, 46, 78, 25, 79, 34};

HashSet<int> set2 = new HashSet<int>()
{ 22, 57, 79, 58, 77, 79};

set1.UnionWith(set2);

Console.WriteLine("merge set elements are: ");

foreach(var set3 in set1)
{
    Console.Write(set3 + "  ");
}
Console.WriteLine();
