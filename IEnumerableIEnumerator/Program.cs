using System;
using System.Collections.Generic;
using System.Collections;

namespace IEnumerableIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach(Week day in week)
            {
                Console.WriteLine(day);
            }


            int[] enumerators = new int [] { 2, 4, 6, 8, 10 };
            IEnumerator ie = enumerators.GetEnumerator();
            while (ie.MoveNext())
            {
                int item = (int)ie.Current;
                Console.WriteLine(item);

            }
            ie.Reset();
            Console.ReadLine();



            Console.WriteLine("Hello World!");
        }
    }
}
