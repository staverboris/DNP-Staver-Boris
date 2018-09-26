using System;
namespace DNP
{
    public class Student
    {
        private string name;

        

        public Student(string name)
        {
            this.name = name;
        }

        public virtual void sayHi()
        {
            Console.WriteLine("Hi Im a student");
        }
    }
}