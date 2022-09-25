using Spectre.Console;

namespace Dumpper.Writer;

internal sealed partial class Printer
{
    internal static void PrintBracket(string bracket, string color = "red") => AnsiConsole.Markup("[{0}]{1}[/]", color, Markup.Escape($"{bracket}"));
    internal static void PrintComma(string comma, string color = "lime") => AnsiConsole.Markup("[{0}]{1}[/]", color, Markup.Escape(comma));
    internal static void PrintNewLine() => AnsiConsole.WriteLine();
}