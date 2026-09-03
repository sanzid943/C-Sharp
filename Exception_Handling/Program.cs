// Problem_1

try
{
    Console.Write("enter a number: ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("number: " + num);
}

catch (FormatException)
{
    Console.WriteLine();
    Console.WriteLine("Invalid input. Please enter a valid number.");
}




// Problem_2

try
{
    console.write("enter first number: ");
    int num1 = int.parse(console.readline());

    console.write("enter second number: ");
    int num2 = int.parse(console.readline());

    int result = num1 / num2;
    console.writeline("the result of " + num1 + " divided by " + num2 + " is: " + result);

}

catch (dividebyzeroexception)
{
    console.writeline();
    console.writeline("error: division by zero is not allowed.");
}

catch (formatexception)
{
    console.writeline();
    console.writeline("invalid input. please enter valid numbers.");
}




// Problem_3

try
{
    int[] num = { 10, 20, 30, 31, 32, };
    Console.WriteLine(num[8]);

}

catch (IndexOutOfRangeException)
{
    Console.WriteLine("invalid array index");
}