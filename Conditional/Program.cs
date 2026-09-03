// Problem_1

Console.Write("enter your marks: ");
int marks = int.Parse(Console.ReadLine());

if (marks >= 40)
{
    Console.WriteLine("you have passed the exam.");
}
else
{
    Console.WriteLine("you have failed the exam.");
}



// Problem_2

Console.Write("enter a number: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine(num + " is an even number.");
}
else
{
    Console.WriteLine(num + " is an odd number.");
}

Console.WriteLine();



// Problem_3

Console.Write("eneter your marks between 0 and 100: ");
int marks = int.Parse(Console.ReadLine());

if (marks >= 80)
{
    Console.WriteLine("you have got A+ grade.");

}
else if (marks >= 70)
{
    Console.WriteLine("you have got A grade.");
}
else if (marks >= 60)
{
    Console.WriteLine("you have got B grade.");
}
else if (marks >= 50)
{
    Console.WriteLine("you have got C grade.");
}
else if (marks >= 40)
{
    Console.WriteLine("you have got D grade.");
}
else
{
    Console.WriteLine("you have failed the exam.");
}

Console.WriteLine();




// Problem_4

Console.Write("enter day of the week (1-7): ");
int day = int.Parse(Console.ReadLine());

switch(day)
{
    case 1:
        Console.WriteLine("Saturday");
        break;
    case 2:
        Console.WriteLine("Sunday");
        break;
    case 3:
        Console.WriteLine("Monday");
        break;
    case 4:
        Console.WriteLine("Tuesday");
        break;
    case 5:
        Console.WriteLine("Wednesday");
        break;
    case 6:
        Console.WriteLine("Thursday");
        break;
    case 7:
        Console.WriteLine("Friday");
        break;
    default:
        Console.WriteLine("Invalid day of the week.");
        break;
}

Console.WriteLine();



// Problem_5

Console.Write("enter your age: ");
int age = int.Parse(Console.ReadLine());

if (age < 13)
{
    Console.WriteLine("you are a child.");

}
else if (age >= 13 && age < 20)
{
    Console.WriteLine("you are a teenager.");
}
else if (age >= 20 && age < 60)
{
    Console.WriteLine("you are an adult.");
}
else
{
    Console.WriteLine("you are a senior citizen.");
}

Console.WriteLine();




// Problem_6

Console.Write("enter first number: ");
float num1 = float.Parse(Console.ReadLine());

Console.Write("enter second number: ");
float num2 = float.Parse(Console.ReadLine());

Console.Write("enter an operator (+, -, *, /): ");
char op = Console.ReadLine()[0];

switch (op)
{
    case '+':
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        break;
    case '-':
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        break;
    case '*':
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        break;
    case '/':
        if (num2 != 0)
        {
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        break;
    default:
        Console.WriteLine("Invalid operator.");
        break;
}

Console.WriteLine();