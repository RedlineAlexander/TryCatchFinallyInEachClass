using System;

namespace TryCatchFinallyInEachClass
{
    class Program
    {

        int v = 2;
        decimal v1 = 6m;
        long l1 = 6l;
        double d1 = 3.5;
        string vrow = "Back in me";
        char c1 = 'd';
        ushort vui = 34;
        uint uit = 32;

         public int CheckAnyTypeForNullOrEmptyValues()
        {
            if(v == null)
            {

            }
            if(v1 == null)
            {

                
            }
            if (l1 == null)
            {

            }
            if(d1 == null)
            {

            }
            if(vrow == null)
            {

            }
            if(c1 == null)
            {

            }
            if(vui == null)
            {

            }
            if(uit == null)
            {

            }

            return 0;
        }
         public static void ToConsole()

        {
            Console.WriteLine();
           // ConsoleColor.DarkGreen();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
