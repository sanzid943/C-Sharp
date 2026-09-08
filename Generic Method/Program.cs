// Problem-1

class Box<T>
{
    private T Value;

    public void setValue(T value)
    {
        this.Value = value;
    }
    public T getValue()
    {
        return Value;
    }
}


class Program
{
    static void Main()
    {
        Box<int> box = new Box<int>();
        box.setValue(42);

        Console.WriteLine("ID: " + box.getValue());

        Box<string> box1 = new Box<string>();
        box1.setValue("zid");

        Console.WriteLine("name: " + box1.getValue());
    }
}



// Problem-2

class Program
{
    static void print<T>(T value)
    {
        Console.WriteLine(value);
    }

    static void Main()
    {
        print<int>(120);
        print<string>("sakib");
        print<double>(3.67);
        print<char>('A');
        print<bool>(true);

    }
}




// Problem-3


class Program
{
    static void Print<T>(T a, T b, T c)
    {
        Console.Write(a + "  ");
        Console.Write(b + "  ");
        Console.Write(c + "  ");
        Console.WriteLine();
    }
    static void Main()
    {
        Print<int>(10, 39, 46);
        Print<string>("sajid", "das", "raju");
        Print<double>(13.5, 68.8, 35.78);
    }
}




// Program-4

Box<int> box = new Box<int>();
Console.WriteLine(box.Value = 1266);

class Box<T> where T : struct
{
    public T Value;
}




// Program-5


Factory<student> factory = new Factory<student>();

student s = factory.create();

class student
{
    public student()
    {
        Console.WriteLine("student created");
    }
}



class Factory<T> where T : new()
{
    public T create()
    {
        return new T();
    }
}



