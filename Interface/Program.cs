// Example_1

Dog dog = new Dog();
dog.makeSound();

interface IAnimal
{
    void makeSound();
}

class Dog : IAnimal
{
    public void makeSound()
    {
        Console.WriteLine("Woof!");
    }
}





// Example_2

IPayment payment = new Bkash();
payment.pay();

IPayment payment2 = new Card();
payment2.pay();

interface IPayment
{
    void pay();
}

class Bkash : IPayment
{
    public void pay()
    {
        Console.WriteLine("Payment done via Bkash");
    }
}

class Card : IPayment
{
    public void pay()
    {
        Console.WriteLine("Payment done via Card");
    }
}

