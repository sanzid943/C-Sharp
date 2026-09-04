// Example_1

student s1 = new student();

s1.Name = "Rakib";
s1.Age = 23;

Console.WriteLine("Student name: " + s1.Name);
Console.WriteLine("Student age: " + s1.Age);

class student
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}



