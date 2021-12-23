

using Dumpper.Types;

namespace ConsumerApp
{
    enum huda
    {
        test,
        tes2
    };

    internal class CommonTypeTest
    {
        internal void Execute()
        {
            int a = 12;
            double b = 12.12;
            decimal c = 12.32m;
            uint d = 12;
            char e = 'a';
            float f = 0.1f;
            bool g = true;

            string? nullable = string.Empty;
            int? nullable2 = null;
            bool? nullable3 = null;
            string ab = "Hello World From Pritom";

            //a.Dump();
            //b.Dump();
            //c.Dump();
            //d.Dump();
            //e.Dump();
            //f.Dump();
            //g.Dump("Header");
            //nullable2?.Dump("Nullable Header");
            //nullable3?.Dump();
            //huda.test.Dump();

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            //int[] vs = list.ToArray();
            //string[] strArray = new string[5] { "asd", string.Empty, "23", "", "rgdf" };

            //vs.Dump();
            //list.Dump();
            //strArray.Dump();
            ab.Dump();
        }
    }
}
