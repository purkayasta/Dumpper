using Dumpper.Printer;

namespace Dumpper.Types.Arrays
{
    public static class StringArray
    {
        public static void Dump(this string[] arr) => PrimitiveArrayPrinter.Print(arr);
        public static void Dump(this IEnumerable<string> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
        public static void Dump(this List<string> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
    }
}
