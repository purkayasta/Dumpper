// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

namespace Dumpper.Writer
{
    internal sealed partial class Printer
    {
        internal static void Print(string[]? arr)
        {
            if (arr is null) return;

            int count = arr.Length;
            Printer.PrintLine($"({count})", "Collection Length:");
            Printer.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                Printer.Print(arr[i]);

                if (i < count - 1)
                    Printer.PrintComma(", ");
            }

            Printer.PrintBracket("]");
            Printer.PrintNewLine();
        }

        internal static void Print(int[]? arr)
        {
            if (arr is null) return;

            int count = arr.Length;
            Printer.PrintLine($"({count})", "Collection Length:");
            Printer.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                Printer.Print(arr[i].ToString());

                if (i < count - 1)
                    Printer.PrintComma(", ");
            }

            Printer.PrintBracket("]");
            Printer.PrintNewLine();
        }

        internal static void Print(double[]? arr)
        {
            if (arr is null) return;

            int count = arr.Length;
            Printer.PrintLine($"({count})", "Collection Length:");
            Printer.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                Printer.Print(arr[i].ToString());

                if (i < count - 1)
                    Printer.PrintComma(", ");
            }

            Printer.PrintBracket("]");
            Printer.PrintNewLine();
        }

        internal static void Print(float[]? arr)
        {
            if (arr is null) return;

            int count = arr.Length;
            Printer.PrintLine($"({count})", "Collection Length:");
            Printer.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                Printer.Print(arr[i].ToString());
                if (i < count - 1)
                    Printer.PrintComma(", ");
            }

            Printer.PrintBracket("]");
            Printer.PrintNewLine();
        }

        internal static void Print(decimal[]? arr)
        {
            if (arr is null) return;

            int count = arr.Length;
            Printer.PrintLine($"({count})", "Collection Length:");
            Printer.PrintBracket("[");
            for (int i = 0; i < count; i++)
            {
                Printer.Print(arr[i].ToString());
                if (i < count - 1)
                    Printer.PrintComma(", ");
            }

            Printer.PrintBracket("]");
            Printer.PrintNewLine();
        }
    }
}