
using System.Collections.Generic;
using Dumpper;

namespace ConsumerApp
{

    internal class DicTypes
    {
        public void Execute()
        {
            var dictonary = new Dictionary<string, string>();
            dictonary.Add("a", "b");
            dictonary.Add("c", "d");
            dictonary.Add("e", "f");
            dictonary.Add("f", "g");
            dictonary.Add("g", "h");
            dictonary.Dump();


            var dict = new Dictionary<int, string>();
            dict.Add(1, "Pritom");
            dict.Add(2, "Purkayasta");
            dict.Add(3, "Sunny");

            dict.Dump();

            var dict2 = new Dictionary<int, string>();
            dict2.Add(1, "Bably");
            dict2.Add(2, "Datta");
            dict2.Add(3, "as");
            dict2.Dump();

            var lists = new List<Dictionary<int, string>>();
            lists.Add(dict);
            lists.Add(dict2);
            lists.Dump();

            var customDictionary = new Dictionary<int, Employee>();
            customDictionary.Add(0, new Employee("Hello", "World"));
            customDictionary.Add(1, new Employee("Hello1", "World1"));
            customDictionary.Add(2, new Employee("Hello2", "World2"));
            customDictionary.Dump();
        }
    }
    record Employee(string FirstName, string LastName);
}
