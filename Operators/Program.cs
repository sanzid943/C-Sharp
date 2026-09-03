// Problem_1

Console.Write("enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("enter second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("addition: " + (num1 + num2));
Console.WriteLine("subtraction: " + (num1 - num2));
Console.WriteLine("multiplication: " + (num1 * num2));
Console.WriteLine("division: " + (num1 / num2));
Console.WriteLine("modulus: " + (num1 % num2));
Console.WriteLine("exponentiation: " + Math.Pow(num1, num2));
Console.WriteLine("remainder: " + (num1 % num2));



// Problem_2

Console.Write("enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("you are " + (age >= 18 ? "an adult" : "a minor"));



// Problem_3

Console.Write("enter first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("enter second number: ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("enter third number: ");
double num3 = double.Parse(Console.ReadLine());

double average = (num1 + num2 + num3) / 3;

Console.WriteLine();
Console.WriteLine("The average is: " + average);

Console.WriteLine();