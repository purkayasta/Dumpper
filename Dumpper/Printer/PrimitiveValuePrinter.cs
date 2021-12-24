using Dumpper.Shared;
using Spectre.Console;

namespace Dumpper.Printer
{
	internal class PrimitiveValuePrinter
	{
		internal static void PrintLine(string value) => AnsiConsole.MarkupLine($"[teal] { (!string.IsNullOrEmpty(value) ? value : "null")} [/]");
		internal static void PrintLine(string value, Color color) => AnsiConsole.MarkupLine($"[{color}] { (!string.IsNullOrEmpty(value) ? value : "null")} [/]");
		
        internal static void PrintLine(string value, string header) => AnsiConsole.MarkupLine($"[bold green1] {header}[/]: [purple]{ (!string.IsNullOrEmpty(value) ? value : "null")} [/]");
		internal static void PrintLine(string value, string header, Color color) => AnsiConsole.MarkupLine($"[bold {color}] {header}[/]: [purple]{ (!string.IsNullOrEmpty(value) ? value : "null")} [/]");
		
        internal static void Print(string value) => AnsiConsole.Markup(string.IsNullOrEmpty(value) ? "null" : value);
		internal static void Print(string value, Color color) => AnsiConsole.Markup(string.IsNullOrEmpty(value) ? $"[{color}] null [/]" : $"[{color}] {value} [/]");
	}
}
