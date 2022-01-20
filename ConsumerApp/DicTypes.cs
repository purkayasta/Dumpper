
using Dumpper.Types.Collections;

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

            var dict2 = new Dictionary<int, string>();
            dict2.Add(1, "Bably");
            dict2.Add(2, "Datta");
            dict2.Add(3, "as");



            var lists = new List<Dictionary<int, string>>();
            lists.Add(dict);
            lists.Add(dict2);


            lists.Dump();



        }
    }
}
