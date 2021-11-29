namespace Dumpper.Printer
{
    internal class PrimitiveArray
    {
        internal static void Print(string[] arr)
        {
            int count = arr.Length;
            PrimitiveValue.PrintLine($"({count})", "Collection Length:");
            Symbols.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                PrimitiveValue.Print(arr[i]);

                if (i < count - 1)
                    Symbols.PrintComma(", ");
            }
            Symbols.PrintBracket("]");
            Symbols.PrintNewLine();
        }

        internal static void Print(int[] arr)
        {
            int count = arr.Length;
            PrimitiveValue.PrintLine($"({count})", "Collection Length:");
            Symbols.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                PrimitiveValue.Print(arr[i].ToString());

                if (i < count - 1)
                    Symbols.PrintComma(", ");
            }
            Symbols.PrintBracket("]");
            Symbols.PrintNewLine();
        }
    }
}
