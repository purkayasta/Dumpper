using Spectre.Console;

namespace Dumpper.Printer
{
    internal class PrimitiveValue
    {
        internal static void PrintLine(string? value) => AnsiConsole.MarkupLine($"[teal] { (!string.IsNullOrEmpty(value) ? value : "null")} [/]");
        internal static void PrintLine(string? value, string header) => AnsiConsole.MarkupLine($"[bold green1] {header}[/]: [purple]{ (!string.IsNullOrEmpty(value) ? value : "null")} [/]");
        internal static void Print(string? value) => AnsiConsole.Markup(string.IsNullOrEmpty(value) ? "null" : value);
    }
}
