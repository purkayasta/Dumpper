// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

namespace Dumpper.Writer
{
    internal sealed partial class Printer
    {
        internal static void Print(string[] arr)
        {
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

        internal static void Print(int[] arr)
        {
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

        internal static void Print(double[] arr)
        {
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

        internal static void Print(float[] arr)
        {
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

        internal static void Print(decimal[] arr)
        {
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