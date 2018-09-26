using System;
using System.Collections.Generic;

namespace PARAMS
{    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ints =new Stack<int>();
            Stack <string> strings = new Stack <string>();
            Alotofvalues(ints,1,4,5,6,7);
            Alotofvalues(strings, "Eminem");
        }

        static void Alotofvalues <T> ( Stack<T> lol ,params T[] numbers){
           
           
          foreach (var item in numbers)
          {
              lol.Push(item);
              Console.WriteLine ("Heh: "+item);
          }   
           
        }
        
    }
}
