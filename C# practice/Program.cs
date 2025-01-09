Console.WriteLine("generic lists in C#");

List<string> studentList = new List<string>();

for (int i = 0; i < 2; i++)
{
    studentList.Add(Console.ReadLine());
}

for (int i = 0; i < studentList.Count; i++)
{
    Console.WriteLine("The element at index " + i + " is " + studentList[i]);
}

