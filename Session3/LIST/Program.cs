using System;
using System.Collections.Generic;

namespace LIST
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> liste = new List<int>();
        liste.Add(421);
        liste.Add (321);
         liste.Add(2);
        liste.Add (1);
        System.Console.WriteLine(liste.RandomItem());

        }
    }
}
