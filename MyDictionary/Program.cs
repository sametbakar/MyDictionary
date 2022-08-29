
using System.Collections.Generic;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary=new MyDictionary<int, string>();
            myDictionary.Add(1, "Ali");
            myDictionary.Add(1, "Ayşe");
            myDictionary.Add(3, "Fatma");
            myDictionary.Add(4, "Hüseyin");
            myDictionary.Add(5, "Serdar");
            myDictionary.Add(6, "Hakan");


            myDictionary.Show();
            Console.WriteLine(myDictionary.Count);

        }
    }
}