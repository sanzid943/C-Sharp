// Problem_1

Dictionary<string, string> studentGrades = new Dictionary<string, string>();

Console.Write("how many students? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    Console.Write("enter student ID: "+(i + 1)+": ");
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