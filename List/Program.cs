// Problem_1

List<string> names = new List<string>();

names.Add("rahim");
names.Add("karim");
names.Add("rafi");

foreach (string name in names)
{
    Console.WriteLine(name);
}





// Problem_2

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





// Problem_3

List<int> numbers= new List<int>();

numbers.Add(231);
numbers.Add(212);
numbers.Add(123);
numbers.Add(987);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

