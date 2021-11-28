using Dumpper.Printer;

namespace Dumpper.Shared
{
    internal class PrimitiveCollectionArray
    {
        internal static void Print(string[] arr)
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

        internal static void Print(int[] arr)
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
    }
}
