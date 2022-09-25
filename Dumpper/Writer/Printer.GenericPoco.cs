// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System.Reflection;
using Dumpper.Shared;
using Spectre.Console;

namespace Dumpper.Writer;

internal sealed partial class Printer
{
    internal static void Print(PropertyInfo[] properties, string className)
    {
        Tree tree = GenerateTree(properties, className);
        AnsiConsole.Write(tree);
    }
    internal static Tree GenerateTree(PropertyInfo[] properties, string className)
    {
        Tree tree = new Tree(string.IsNullOrEmpty(className) ? "Default" : className).Style($"{DumpperColor.Aqua.ToText()}");

        foreach (var property in properties)
            tree.AddNodes(new Markup($"[bold {DumpperColor.Red.ToText()}]{property.Name}[/]"));

        return tree;
    }
    internal static void Print<T>(PropertyInfo[] properties, string className, T instance)
    {
        Tree tree = new Tree(string.IsNullOrEmpty(className) ? "Default" : className).Style($"{DumpperColor.Aqua.ToText()}");

        foreach (var property in properties)
            tree.AddNodes(new Markup($"[bold {DumpperColor.Purple.ToText()}]{property?.Name} [/] : {property?.GetValue(instance, null)}"));

        AnsiConsole.Write(tree);
    }
    internal static void PrintList<T>(PropertyInfo[] classProperties, IEnumerable<T> instances)
    {
        Table table = new();

        bool isTableColumnGenerated = false;

        string[] columnValues = new string[classProperties.Length];

        foreach (var instance in instances)
        {
            for (int i = 0; i < classProperties.Length; i++)
            {
                var values = classProperties[i].GetValue(instance);

                columnValues[i] = values?.ToString() ?? String.Empty;

                if (!isTableColumnGenerated)
                    table.AddColumn(new TableColumn($"[{DumpperColor.Green.ToText()}]{classProperties[i].Name}[/]").Centered());
            }

            if (!isTableColumnGenerated) isTableColumnGenerated = true;

            table.AddRow(columnValues);

            Array.Clear(columnValues, 0, columnValues.Length);
        }

        AnsiConsole.Write(table);
    }
}