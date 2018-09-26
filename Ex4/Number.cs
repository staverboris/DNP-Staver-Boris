using System.Collections.Generic;
namespace DNP.Ex4

{
    public class Number
    {
        public static void Main(string[] args)
{
    var number= new List<int>();
    for(int i=0;i<100;i++)
    {
        number.Add(i);
    }
    for (int i=0;i<number.Count;i++)
    {
        if(i%2==0)
        {
            System.Console.WriteLine("Even numbers are:" + number[i]);
        }
    }
}
    }
}