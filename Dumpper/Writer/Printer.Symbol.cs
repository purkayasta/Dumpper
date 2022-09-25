// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Dumpper.Shared;
using Spectre.Console;

namespace Dumpper.Writer;

internal sealed partial class Printer
{
    internal static void PrintBracket(string bracket, DumpperColor color = DumpperColor.Red) => AnsiConsole.Markup("[{0}]{1}[/]", color.ToText(), Markup.Escape($"{bracket}"));
    internal static void PrintComma(string comma, DumpperColor color = DumpperColor.Lime) => AnsiConsole.Markup("[{0}]{1}[/]", color.ToText(), Markup.Escape(comma));
    internal static void PrintNewLine() => AnsiConsole.WriteLine();
}