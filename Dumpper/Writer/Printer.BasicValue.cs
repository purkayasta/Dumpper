// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Dumpper.Shared;
using Spectre.Console;

namespace Dumpper.Writer
{
    internal sealed partial class Printer
    {
        internal static void PrintLine(string? value)
            => AnsiConsole.MarkupLine($"[{Utils.RandomColor().ToText()}] {(!string.IsNullOrEmpty(value) ? value : "null")} [/]");

        internal static void PrintLine(string? value, DumpperColor color)
            => AnsiConsole.MarkupLine($"[{color.ToText()}] {(!string.IsNullOrEmpty(value) ? value : "null")} [/]");

        internal static void PrintLine(string? value, string header)
            => AnsiConsole.MarkupLine($"[bold {Utils.RandomColor().ToText()}] {header}[/]: [{DumpperColor.Purple.ToText()}]{(!string.IsNullOrEmpty(value) ? value : "null")} [/]");

        internal static void PrintLine(string? value, string header, DumpperColor color)
            => AnsiConsole.MarkupLine($"[bold {color.ToText()}] {header}[/]: [{DumpperColor.Purple.ToText()}]{(!string.IsNullOrEmpty(value) ? value : "null")} [/]");

        internal static void Print(string? value)
            => AnsiConsole.Markup($"[bold {Utils.RandomColor().ToText()}] {(string.IsNullOrEmpty(value) ? "null" : value)} [/]");

        internal static void Print(string? value, DumpperColor color)
            => AnsiConsole.Markup(string.IsNullOrEmpty(value) ? $"[{color.ToText()}] null [/]" : $"[{color.ToText()}] {value} [/]");
    }
}