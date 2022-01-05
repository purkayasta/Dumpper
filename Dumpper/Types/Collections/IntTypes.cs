using Dumpper.Printer;

namespace Dumpper.Types.Collections
{
    public static class IntTypes
    {
        public static void Dump(this int[] arr) => PrimitiveArrayPrinter.Print(arr);
        //public static void Dump(this IEnumerable<int> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
        //public static void Dump(this List<int> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
    }
}
