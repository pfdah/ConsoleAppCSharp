using System;

namespace AcademiaStuff
{
    class Program
    {


        static void Main(string[] args)
        {
            Student s = new Student();
            Console.Write("\nEnter Something Awesome\n");
            string test = Console.ReadLine();
            Console.Write("\n\n");
            Student x = new Student(test);
            //Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }
}
