using System;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List1 students = new List1();
            List1 student = new List1();
            Console.WriteLine("Hello World!");
            students.addList("James");
            students.addList("Timmofei");
            students.addList("Benan");
            students.addList("Louis");
            students.PrintList();
            student.addList("Charlie");
            student.PrintList();

        }
    }
}
