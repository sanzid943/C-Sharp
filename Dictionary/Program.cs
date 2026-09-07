// Problem_1

Dictionary<string, string> studentGrades = new Dictionary<string, string>();

Console.Write("how many students? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    Console.Write("enter student ID: " + (i + 1) + ": ");
    string studentId = Console.ReadLine();

    Console.Write("enter name of student " + (i + 1) + ": ");
    string name = Console.ReadLine();


    studentGrades.Add(studentId, name);
}

Console.WriteLine("\nStudent list: ");

foreach (var student in studentGrades)
{
    Console.WriteLine("Student ID: " + student.Key + ", Name: " + student.Value);
}

Console.WriteLine();




// Problem_2

Dictionary<int, string> students = new Dictionary<int, string>();

students.Add(11, "karim");
students.Add(12, "rafi");
students.Add(13, "raju");
students.Add(14, "kalam");

foreach (var student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine();

students.Remove(14);

foreach (var student in students)
{
    Console.WriteLine("ID: " + student.Key);
    Console.WriteLine("Name: " + student.Value);
}





// Problem_3

using System.Globalization;

Dictionary<int, int> marks = new Dictionary<int, int>();

marks.Add(101, 67);
marks.Add(102, 78);
marks.Add(103, 87);
marks.Add(104, 90);

foreach (var student in marks)
{
    Console.WriteLine("ID: " + student.Key);
    Console.WriteLine("Marks: " + student.Value);
}

Console.WriteLine();
Console.WriteLine("enter ID: ");
int id = int.Parse(Console.ReadLine());
Console.WriteLine();

if (marks.ContainsKey(id))
{
    Console.WriteLine("your number is: " + marks[id]);
}
else
{
    Console.WriteLine("student not found");
}





// Problem_4

Dictionary<int, string> names= new Dictionary<int, string>();

names.Add(101, "kalam");
names.Add(102, "rajib");
names.Add(103, "rakib");

foreach (var name in names)
{
    Console.WriteLine(name);
}

names[102] = "rafi";

Console.WriteLine();
Console.WriteLine("update value: ");

foreach (var name in names)
{
    Console.WriteLine(name);
}