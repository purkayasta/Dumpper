using Dumpper.Printer;
using Dumpper.Shared;

namespace Dumpper.PrimitiveTypes
{
    /// <summary>
    /// Author: Pritom Purkayasta
    /// <para>Dumpping string types to the console</para>
    /// </summary>
    public static class StringType
    {
        public static void Dump(this string val) => PrintValues.PrintLine(val);

        public static void Dump(this string val, string startingText) => PrintValues.PrintLine(val, startingText);

        public static void Dump(this string[] arr) => PrimitiveCollectionArray.Print(arr);

        public static void Dump(this IEnumerable<string> vals) => PrimitiveCollectionArray.Print(vals.ToArray());

        public static void Dump(this List<string> vals) => PrimitiveCollectionArray.Print(vals.ToArray());

        public static void Dump<T>(this Dictionary<string, T> stringDictonary) where T : struct
        {

        }
    }
}
