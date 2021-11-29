using Dumpper.Printer;

namespace Dumpper.Types.Arrays
{
    public static class StringArray
    {
        public static void Dump(this string[] arr) => PrimitiveArray.Print(arr);
        public static void Dump(this IEnumerable<string> vals) => PrimitiveArray.Print(vals.ToArray());
        public static void Dump(this List<string> vals) => PrimitiveArray.Print(vals.ToArray());
    }
}
