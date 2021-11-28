using Spectre.Console;

namespace Dumpper.Printer
{
    internal class PrintValues
    {
        internal static void PrintLine(string value) => AnsiConsole.MarkupLine($"[teal] {value} [/]");
        internal static void PrintLine(string value, string header) => AnsiConsole.MarkupLine($"[bold green1] {header}[/]: [purple]{value} [/]");
        internal static void Print(string value) => AnsiConsole.Markup(value);

        internal static void PrintLine(int value) => PrintLine(value.ToString());
        internal static void PrintLine(int value, string header) => PrintLine(value.ToString(), header);
        internal static void Print(int value) => Print(value.ToString());
    }
}
