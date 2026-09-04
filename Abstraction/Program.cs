// Example_1

Dog dog = new Dog();

dog.makeSound();
dog.eat();

abstract class Animal
{
    public abstract void makeSound();
    public void eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Woof!");
    }
}


