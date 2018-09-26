using System;
namespace DNP
{
    public class DNPStudent : Student
    {
        public DNPStudent(string name)
        : base(name){
            
        }
        
public override void sayHi()
        {
            Console.WriteLine("Eminem");
            base.sayHi();
        }

    }
}
