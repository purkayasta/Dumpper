using Dumpper.Printer;

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

        public static void Dump(this string[] arr)
        {
            int count = arr.Length;
            PrintValues.PrintLine($"({count})", "Array Length:");
            PrintSymbols.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                PrintValues.Print(arr[i]);

                if (i < count - 1)
                    PrintSymbols.PrintComma(", ");
            }
            PrintSymbols.PrintBracket("]");
            PrintSymbols.PrintNewLine();
        }

        public static void Dump(this IEnumerable<string> vals)
        {
            vals.ToList().Dump();
        }

        public static void Dump(this List<string> vals)
        {
            int count = vals.Count;
            PrintValues.PrintLine($"({count})", "Collection Length");
            PrintSymbols.PrintBracket("{");
            for (int i = 0; i < count; i++)
            {
                PrintValues.Print(vals[i]);

                if (i < count - 1)
                    PrintSymbols.PrintComma(", ");
            }
            PrintSymbols.PrintBracket("}");
            PrintSymbols.PrintNewLine();
        }

        public static void Dump<T>(this Dictionary<string, T> stringDictonary) where T : struct
        {

        }
    }
}
