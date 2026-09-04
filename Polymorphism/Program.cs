// Example_1

Animal a1 = new Dog();
Animal a2 = new Cat();

a1.makeSound();
a2.makeSound();

class Animal
{
    public virtual void makeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Meow!");
    }
}




// Example_2

calculator calc = new calculator();

Console.WriteLine("Addition of 10 and 20: " + calc.add(10, 20));
Console.WriteLine("Subtraction of 30 and 10: " + calc.subtract(30, 10));
Console.WriteLine("Multiplication of 5 and 6: " + calc.multiply(5, 6));
Console.WriteLine("Division of 20 and 4: " + calc.divide(20, 4));
Console.WriteLine("Modulus of 10 and 3: " + calc.modulus(10, 3));
Console.WriteLine("Addition of 10, 20, and 30: " + calc.add(10, 20, 30));

class calculator
{
    public virtual int add(int a, int b)
    {
        return a + b;
    }

    public virtual int subtract(int a, int b)
    {
        return a - b;
    }

    public virtual int multiply(int a, int b)
    {
        return a * b;
    }

    public virtual int divide(int a, int b)
    {
        return a / b;
    }

    public virtual int modulus(int a, int b)
    {
        return a % b;
    }

    public int add(int a, int b, int c)
    {
        return a + b + c;
    }
}

