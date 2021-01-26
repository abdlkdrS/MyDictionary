using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Customer1");
            Console.WriteLine(myDictionary.Length);
            myDictionary.Add("Customer2");
            Console.WriteLine(myDictionary.Length);
            myDictionary.Add("Customer3");
            Console.WriteLine(myDictionary.Length);

            foreach (var item in myDictionary.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
