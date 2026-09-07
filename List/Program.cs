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

List<int> numbers = new List<int>();

numbers.Add(231);
numbers.Add(212);
numbers.Add(123);
numbers.Add(987);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}




// Problem_4

List<int> numbers = new List<int>();

numbers.Add(123);
numbers.Add(232);
numbers.Add(245);
numbers.Add(157);

int sum = 0;

foreach (int i in numbers)
{
    sum += i;
}

Console.WriteLine("Sum: " + sum);




// Problem_5

List<int> numbers = new List<int>()
{ 10, 20, 23, 35, 57, 67, 35, 89, 896};

foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number + " is even");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine(number + " is odd");
        Console.WriteLine();
    }
}




// Problem_6

List<string> names = new List<string>()
{ "rahim", "karim", "tanvir", "raju", "rafiq"};

Console.WriteLine("enter name: ");
string name = Console.ReadLine();

if (names.Contains(name))
{
    Console.WriteLine("name found");
}

else
{
    Console.WriteLine("name not found");
}
Console.WriteLine();




// Problem_7

List<int> numbers = new List<int>()
{ 23, 12, 56, 46, 68, 25, 78};

foreach (var number in numbers)
{
    Console.Write(number + "   ");
}

Console.WriteLine();


numbers.Reverse();
Console.WriteLine();

foreach (var number in numbers)
{
    Console.Write(number + "   ");

}

numbers.Sort();
Console.WriteLine();

foreach (var number in numbers)
{
    Console.Write(number + "   ");
}




// problem_8

List<int> numbers= new List<int>()
{ 23, 56, 24, 17, 89, 67, 54, 45 };

int largest=0;

foreach(int num in numbers)
{
    Console.Write(num + "  ");
}
Console.WriteLine();

foreach(int number in numbers)
{
    if (number > largest)
    {
        largest=number;
    }
}

Console.WriteLine("Largest number is: " + largest);