// Problem_1

//Dictionary<string, string> studentGrades = new Dictionary<string, string>();

//Console.Write("how many students? ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{

//    Console.Write("enter student ID: "+(i + 1)+": ");
//    string studentId = Console.ReadLine();

//    Console.Write("enter name of student " + (i + 1) + ": ");
//    string name = Console.ReadLine();


//    studentGrades.Add(studentId, name);
//}

//Console.WriteLine("\nStudent list: ");

//foreach (var student in studentGrades)
//{
//    Console.WriteLine("Student ID: " + student.Key + ", Name: " + student.Value);
//}

//Console.WriteLine();




// Problem_2

//Dictionary<int, string> students= new Dictionary<int, string>();

//students.Add(11, "karim");
//students.Add(12, "rafi");
//students.Add(13, "raju");
//students.Add(14, "kalam");

//foreach (var student in students)
//{
//    Console.WriteLine(student);
//}

//Console.WriteLine();

//students.Remove(14);

//foreach(var student in students)
//{
//    Console.WriteLine("ID: " + student.Key);
//    Console.WriteLine("Name: " + student.Value);
//}





// Problem_3

Dictionary<int, int> students= new Dictionary<int, int>();

students.Add(101, 67);
students.Add(102, 78);
students.Add(103, 87);
students.Add(104, 90);

foreach (var student in students)
{
    Console.WriteLine("ID: " + student.Key);
    Console.WriteLine("Marks: " + student.Value);
}