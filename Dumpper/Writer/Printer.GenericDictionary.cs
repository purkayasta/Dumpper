// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System.Reflection;
using Dumpper.Shared;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Dumpper.Writer;

internal sealed partial class Printer
{
    internal static void Print<TKey, TValue>(Dictionary<TKey, TValue> instance)
    {
        if (instance is null || instance.Count < 1) return;

        var table = CreateTable(instance);

        if (table is null) return;

        AnsiConsole.Write(table);
    }

    internal static void PrintList<TKey, TValue>(List<Dictionary<TKey, TValue>> instances)
    {
        if (instances is null || !instances.Any()) return;

        var totalCount = instances.Count;
        var dictionaryTree = new Tree(totalCount.ToString()).Guide(TreeGuide.Line);

        for (int count = 0; count < totalCount; count++)
        {
            var node = dictionaryTree.AddNode(count.ToString());
            var table = CreateTable(instances[count]);
            if (table is not null) node.AddNode(table);
        }

        AnsiConsole.Write(dictionaryTree);
    }

    private static IRenderable GenerateColumn<T>(T instance, PropertyInfo[] propertyInfos, string className)
    {
        var tree = Printer.GenerateTree(instance, propertyInfos, className);
        return tree;
    }

    private static bool IsNonStringClass(Type type)
    {
        if (type == null || type == typeof(string) || type == typeof(int))
            return false;

        return typeof(Type).IsClass;
    }

    private static Table CreateTable<TKey, TValue>(Dictionary<TKey, TValue> instance)
    {
        var dictionaryTable = new Table();

        if (instance is null) return null;
        if (!instance.Keys.Any()) return null;


        dictionaryTable.AddColumn("Key");
        dictionaryTable.AddColumn("Value");

        foreach (var item in instance)
        {
            if (item.Key is null) continue;

            var keyType = IsNonStringClass(typeof(TKey));
            var valueType = IsNonStringClass(typeof(TValue));

            if (keyType && valueType)
            {
                var keyProperties = item.Key?.GetType().GetProperties();
                var valueProperties = item.Value?.GetType().GetProperties();

                if (keyProperties is not null && valueProperties is not null)
                {
                    dictionaryTable.AddRow(
                        GenerateColumn(item.Key, keyProperties, typeof(TKey).Name),
                        GenerateColumn(item.Value, valueProperties, typeof(TValue).Name));
                }
            }
            else if (keyType)
            {
                var keyProperties = item.Key?.GetType().GetProperties();
                if (keyProperties is not null)
                {
                    dictionaryTable.AddRow(
                        GenerateColumn(item.Key, keyProperties, typeof(TKey).Name),
                        new Markup($"[{Utils.RandomColor().ToText()}]{item.Value?.ToString() ?? string.Empty}[/]"));
                }

            }
            else if (valueType)
            {
                var valueProperties = item.Value?.GetType().GetProperties();
                if (valueProperties is not null)
                {
                    dictionaryTable.AddRow(
                        new Markup(item.Key?.ToString() ?? string.Empty),
                        GenerateColumn(item.Value, valueProperties, typeof(TValue).Name));
                }
            }
            else
            {
                dictionaryTable.AddRow(new Markup(item.Key?.ToString() ?? string.Empty), new Markup(item.Value?.ToString() ?? string.Empty));
            }
        }

        return dictionaryTable;
    }
}