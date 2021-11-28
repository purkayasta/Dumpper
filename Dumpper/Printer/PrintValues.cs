using Spectre.Console;

namespace Dumpper.Printer
{
    internal class PrintValues
    {
        internal static void PrintLine(string value) => AnsiConsole.MarkupLine($"[teal] {value} [/]");
        internal static void PrintLine(string value, string header) => AnsiConsole.MarkupLine($"[bold green1] {header}[/]: [purple]{value} [/]");
        internal static void Print(string value) => AnsiConsole.Markup(value);
    }
}
