namespace Dumpper.Printer
{
    internal class PrimitiveArrayPrinter
    {
        internal static void Print(string[] arr)
        {
            int count = arr.Length;
            PrimitiveValuePrinter.PrintLine($"({count})", "Collection Length:");
            SymbolPrinter.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                PrimitiveValuePrinter.Print(arr[i]);

                if (i < count - 1)
                    SymbolPrinter.PrintComma(", ");
            }
            SymbolPrinter.PrintBracket("]");
            SymbolPrinter.PrintNewLine();
        }

        internal static void Print(int[] arr)
        {
            int count = arr.Length;
            PrimitiveValuePrinter.PrintLine($"({count})", "Collection Length:");
            SymbolPrinter.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                PrimitiveValuePrinter.Print(arr[i].ToString());

                if (i < count - 1)
                    SymbolPrinter.PrintComma(", ");
            }
            SymbolPrinter.PrintBracket("]");
            SymbolPrinter.PrintNewLine();
        }
    }
}
