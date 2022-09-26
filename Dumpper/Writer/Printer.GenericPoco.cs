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

    private static Tree GenerateTree(PropertyInfo[] properties, string className)
    {
        Tree tree = new Tree(string.IsNullOrEmpty(className) ? "Default" : className).Style($"{DumpperColor.Aqua.ToText()}");

        foreach (var property in properties)
            tree.AddNodes(new Markup($"[bold {DumpperColor.Red.ToText()}]{property.Name}[/]"));

        return tree;
    }

    private static Tree GenerateTree<T>(T instance, PropertyInfo[] properties, string className)
    {
        Tree tree = new Tree(string.IsNullOrEmpty(className) ? "Default" : className).Style($"{DumpperColor.Aqua.ToText()}");

        foreach (var property in properties)
            tree.AddNodes(new Markup($"[bold {DumpperColor.Purple.ToText()}]{property?.Name} [/] : {property?.GetValue(instance, null)}"));

        return tree;
    }

    internal static void Print<T>(PropertyInfo[] properties, string className, T instance)
    {
        var tree = GenerateTree(instance, properties, className);

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
    
    internal static bool IsPrimitiveCollection<T>(IReflect type, T instance)
    {
        var baseType = type?.UnderlyingSystemType;
        var systemType = baseType?.Name;

        if (baseType is null) return false;
        if (string.IsNullOrEmpty(systemType)) return false;

        if (systemType.Contains("Int"))
        {
            try
            {
                Printer.Print(instance as int[]);
            }
            catch (Exception)
            {
                Printer.PrintLine(instance as string);
            }

            return true;
        }

        if (systemType.Contains("String"))
        {
            try
            {
                Printer.Print(instance as string[]);
            }
            catch (Exception)
            {
                Printer.PrintLine(instance as string);
            }

            return true;
        }

        if (!systemType.Contains("List")) return false;

        var typeArguments = baseType.GetGenericArguments();

        if (typeArguments.Length < 1) return true;

        var convertionType = typeArguments[0];

        if (convertionType.Name.Contains("Int"))
        {
            var converted = instance as List<int>;
            if (converted?.Count > 0) Printer.Print(converted.ToArray());

            return true;
        }

        if (convertionType.Name.Contains("String"))
        {
            var converted = instance as List<string>;
            if (converted?.Count > 0) Printer.Print(converted.ToArray());

            return true;
        }

        return false;
    }

    internal static bool IsItInterface(Type type)
    {
        if (!type.IsInterface) return false;

        var methods = type.GetMethods();
        var properties = type.GetProperties();

        Printer.Print(methods, properties, type.Name);

        return true;
    }
}