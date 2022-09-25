using System.Reflection;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Dumpper.Writer;

internal sealed partial class Printer
{
    internal static void Print<TKey, TValue>(Dictionary<TKey, TValue> instance)
    {
        if (instance is null) return;

        var table = CreateTable(instance);
        
        if (table is null) return;
        
        AnsiConsole.Write(table);
    }

    internal static void PrintList<TKey, TValue>(List<Dictionary<TKey, TValue>> instances)
    {
        if (instances is null) return;

        var totalCount = instances.Count;
        var dictionaryTree = new Tree(totalCount.ToString()).Guide(TreeGuide.Line);

        for (int count = 0; count < totalCount; count++)
        {
            var node = dictionaryTree.AddNode(count.ToString());
            node.AddNode(CreateTable(instances[count]));
        }

        AnsiConsole.Write(dictionaryTree);
    }

    private static IRenderable GenerateColumn(PropertyInfo[] propertyInfos, string className)
    {
        var tree = Writer.Printer.GenerateTree(propertyInfos, className);
        return tree;
    }

    private static bool IsNonStringClass(Type type)
    {
        if (type == null || type == typeof(string) || type == typeof(int))
            return false;

        return typeof(Type).IsClass;
    }

    private static Table? CreateTable<TKey, TValue>(Dictionary<TKey, TValue>? instance)
    {
        var dictionaryTable = new Table();

        if (instance is null) return null;


        dictionaryTable.AddColumn("Key");
        dictionaryTable.AddColumn("Value");

        foreach (var item in instance)
        {
            if (item.Key is null) continue;

            var keyType = IsNonStringClass(typeof(TKey));
            var valueType = IsNonStringClass(typeof(TValue));

            if (keyType && valueType)
            {
                var keyProperties = item.Key.GetType().GetProperties();
                var valueProperties = item.Key.GetType().GetProperties();

                dictionaryTable.AddRow(GenerateColumn(keyProperties, typeof(TKey).Name),
                    GenerateColumn(valueProperties, typeof(TValue).Name));
            }
            else if (keyType)
            {
                var keyProperties = item.Key.GetType().GetProperties();
                dictionaryTable.AddRow(GenerateColumn(keyProperties, typeof(TKey).Name),
                    new Markup(item.Value?.ToString()));
            }
            else if (valueType)
            {
                var valueProperties = item.Value.GetType().GetProperties();
                dictionaryTable.AddRow(new Markup(item.Key?.ToString()),
                    GenerateColumn(valueProperties, typeof(TValue).Name));
            }
            else
            {
                dictionaryTable.AddRow(item.Key.ToString(), item.Value.ToString());
            }
        }

        return dictionaryTable;
    }
}