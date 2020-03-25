using System;
using System.Collections.Generic;

namespace DictionaryUsingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько сотрудников надо добавить");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Dictionary<int, string> mydicti = TryCatchFinallyInEachClass.NewUserInfo.mydict(i);

                ICollection<int> ikeys = mydicti.Keys;
                Console.WriteLine("База данных у нас содержит");
                foreach(int j in ikeys)   
                {
                    Console.WriteLine($"ID -> {0} Value -> {1} {j} {mydicti[j]} ");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод");
            }
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
