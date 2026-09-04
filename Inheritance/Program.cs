// Example_1

Dog dog = new Dog();

dog.eat();
dog.bark();

class Animal
{
    public void eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

