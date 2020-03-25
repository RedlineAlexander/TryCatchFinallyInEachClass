using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;

namespace AllTypesOfCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> stackstring = new Stack<string>();
            stackstring.Push("Feel");
            stackstring.Push("My");
            stackstring.Push("Programming");
            foreach(String stacks in stackstring)
            {
                Console.WriteLine(stacks);
            }
            stackstring.Pop().ToString();
            stackstring.Peek().ToString();




            Queue<String> queuestring = new Queue<string>();
            queuestring.Enqueue("Feel");
            queuestring.Enqueue("My");
            queuestring.Enqueue("Quest");
            queuestring.Enqueue("Quest");
            foreach(String questr in queuestring)
            {
                Console.WriteLine(questr);
            }
            queuestring.Peek().ToString();
            queuestring.Dequeue().ToString();


            ArrayList arrayListString = new ArrayList();

            arrayListString.Add("Back");
            arrayListString.Add("Guts");
            arrayListString.Add("Over");
            arrayListString.Add("Fear");
            foreach(string arrain in arrayListString)
            {
                Console.WriteLine(arrain);
            }

            List<String> listString = new List<string>();
            listString.Add("1");
            listString.Add("2");
            listString.Add("3");
            foreach(String list in listString){
                Console.WriteLine(list);
            }
            LinkedList<String> linkedListString = new LinkedList<string>();

            Hashtable hashtablestring = new Hashtable();
            hashtablestring.Add(1, "3");
            hashtablestring.Add(2, "6");
            hashtablestring.Add(3, "9");
            ICollection ickeys = hashtablestring.Keys;
            ICollection icvalues = hashtablestring.Values;
            foreach (int k in ickeys)
            {
                Console.WriteLine(k + ":" + hashtablestring[k]);
            }
            foreach(int v in icvalues)
            {
                Console.WriteLine(v+  ":" + hashtablestring[v]);
            }
            foreach(KeyValuePair<int,string> khvt in hashtablestring)
            {
                Console.WriteLine(hashtablestring.Keys + " " + hashtablestring.Values );
            }

            //Hashtable<String, int> hashtableString = new Hashtable<String, int>();




            Dictionary<String, int> dictionaryString = new Dictionary<string, int>();
            dictionaryString.Add("1", 345);
            dictionaryString.Add("2", 332);
            dictionaryString.Add("3", 342);
            foreach(KeyValuePair<String, int>kvds in dictionaryString)
            {
                Console.WriteLine(kvds.Key+ " " +kvds.Value);
            }

            //SortedList<String, int> sortedListString = new SortedList<String, int>();





            
            Console.WriteLine("Hello World!");
        }
    }
}
