using System.Reflection;
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
        Tree tree = new Tree(className).Style("Red");
        foreach (var property in properties) tree.AddNodes(new Markup($"[bold white]{property.Name}[/]"));

        return tree;
    }

    internal static void Print<T>(PropertyInfo[] properties, string className, T instance)
    {
        Tree tree = new Tree(className).Style("Yellow1");
        foreach (var property in properties)
        {
            tree.AddNodes(new Markup($"[bold green1]{property?.Name} [/] : {property?.GetValue(instance, null)}"));
        }

        AnsiConsole.Write(tree);
    }

    internal static void PrintList<T>(PropertyInfo[] classProperties, IEnumerable<T> instances)
    {
        Table table = new Table();

        bool isTableColumnGenerated = false;

        // foreach (var prop in classProperties)
        //     table.AddColumn(new TableColumn($"[green]{prop.Name}[/]").Centered());

        string[] columnValues = new string[classProperties.Length];

        foreach (var instance in instances)
        {
            for (int i = 0; i < classProperties.Length; i++)
            {
                var values = classProperties[i].GetValue(instance);

                if (values is null)
                    columnValues[i] = string.Empty;
                else
                    columnValues[i] = values?.ToString();

                if (!isTableColumnGenerated)
                    table.AddColumn(new TableColumn($"[green]{classProperties[i].Name}[/]").Centered());
            }

            if (!isTableColumnGenerated) isTableColumnGenerated = true;

            table.AddRow(columnValues);

            Array.Clear(columnValues, 0, columnValues.Length);
        }

        AnsiConsole.Write(table);
    }
}