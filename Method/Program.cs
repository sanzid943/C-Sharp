// Problem_1

static int add(int a, int b)
{
    return a + b;
}

Console.Write("enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("enter second number: ");
int num2 = int.Parse(Console.ReadLine());

int sum = add(num1, num2);
Console.WriteLine("The sum is: " + sum);

Console.WriteLine();




// Problem_2

static void getNameAndAge(out string name, out int age)
{
    Console.Write("enter your name: ");
    name = Console.ReadLine();

    Console.Write("enter your age: ");
    age = int.Parse(Console.ReadLine());
}

string name;
int age;

getNameAndAge(out name, out age);

Console.WriteLine();
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);

Console.WriteLine();


