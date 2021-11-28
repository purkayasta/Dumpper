using Dumpper.Printer;
using Dumpper.Shared;

namespace Dumpper.PrimitiveTypes
{
    public static class IntType
    {
        public static void Dump(this int val) => PrintValues.PrintLine(val);
        public static void Dump(this int val, string startingText) => PrintValues.PrintLine(val, startingText);
        public static void Dump(this int[] arr) => PrimitiveCollectionArray.Print(arr);
        public static void Dump(this IEnumerable<int> vals) => PrimitiveCollectionArray.Print(vals.ToArray());
        public static void Dump(this List<int> vals) => PrimitiveCollectionArray.Print(vals.ToArray());
    }
}
