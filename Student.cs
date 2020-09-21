using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaStuff
{
    public class Student
    {
        string test = "";
        public Student()
        {
            test = "";
            Console.WriteLine("This is Empty Class");
            Console.Write("-_-\n");
        }
        public Student(string Textt)
        {
            test = Textt;
            Console.WriteLine("This is non-Empty Class");
            Console.WriteLine(test);
            Console.WriteLine("o_o");
        }
    }
}
