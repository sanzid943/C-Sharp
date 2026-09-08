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




// Problem-4

try
{
    Console.Write("enter a number: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("enter divisor: ");
    int div = int.Parse(Console.ReadLine());

    Console.WriteLine(num / div);
    Console.WriteLine();

}

catch (FormatException)
{
    Console.WriteLine("please enter numbers only");
}

catch (DivideByZeroException)
{
    Console.WriteLine("can not divide by zero");
}

catch (Exception)
{
    Console.WriteLine("something went wrong");
}

finally
{
    Console.WriteLine("program finished");
}





// Program-5

Console.Write("enter your age: ");
int age = int.Parse(Console.ReadLine());

if (age < 0)
{
    throw new Exception("age can not be negative");
}

Console.WriteLine("age: " + age);




// Program-6


Console.Write("enter your age: ");
int age = int.Parse(Console.ReadLine());

try
{
if (age < 18)
{
throw new invalidAgeException("age must be 18 or above");
}
Console.WriteLine("you are eligible ");
}
catch (invalidAgeException ex)
{
Console.WriteLine(ex.Message);
}


class invalidAgeException : Exception
{
    public invalidAgeException(string message) : base(message)
    {
    }
}




// Program-7

double balance = 4000;

try
{
    Console.Write("enter your wuthdrawal amount: ");
    double amount = double.Parse(Console.ReadLine());

    if (amount > balance)
    {
        throw new insufficientBalanceException("insuffucient balance");
    }

    Console.WriteLine("withdrawal successful");
    Console.WriteLine("remaining balance: " + (balance-amount));

}

catch (insufficientBalanceException ex)
{
    Console.WriteLine(ex.Message);
}

class insufficientBalanceException: Exception
{
    public insufficientBalanceException(String message) : base(message) { }
}

