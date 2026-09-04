// Example_1


student s1 = new student();

s1.age = 23;
s1.name = "Rakib";
s1.id = 12;

Console.WriteLine("Student name: " + s1.name);
Console.WriteLine("Student age: " + s1.age);
Console.WriteLine("Student id: " + s1.id);

class student
{
    public int id;
    public string name;
    public int age;

}




// Example_2


addition obj = new addition();

obj.add(10, 20);
obj.add(30, 40);
obj.add(50, 60);

Console.WriteLine("The sum of 10 and 20 is: " + obj.add(10, 20));
Console.WriteLine("The sum of 30 and 40 is: " + obj.add(30, 40));
Console.WriteLine("The sum of 50 and 60 is: " + obj.add(50, 60));

class addition
{
    public int add(int a, int b)
    {
        return a + b;
    }
}