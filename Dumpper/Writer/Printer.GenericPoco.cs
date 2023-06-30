// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System.Reflection;
using Dumpper.Shared;
using Spectre.Console;

namespace Dumpper.Writer
{
    internal sealed partial class Printer
    {
        internal static void Print(PropertyInfo[] properties, string className)
        {
            Tree tree = GenerateTree(properties, className);
            AnsiConsole.Write(tree);
        }

        internal static void Print<T>(PropertyInfo[] properties, string className, T instance)
        {
            var tree = GenerateTree(instance, properties, className);

            AnsiConsole.Write(tree);
        }

        #region Collection


        internal static Table GenerateList(PropertyInfo[] classProperties, IEnumerable<object> instances)
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
            return table;
        }

        internal static Table GenerateList<T>(PropertyInfo[] classProperties, IEnumerable<T> instances)
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
            return table;
        }

        internal static void PrintList<T>(PropertyInfo[] classProperties, IEnumerable<T> instances)
        {
            var table = GenerateList<T>(classProperties, instances);

            AnsiConsole.Write(table);
        }


        internal static bool IsPrimitiveCollection<T>(IReflect type, T? instance)
        {
            ArgumentNullException.ThrowIfNull(instance);

            var baseType = type?.UnderlyingSystemType;
            var systemType = baseType?.Name;

            if (baseType is null) return false;
            if (string.IsNullOrEmpty(systemType)) return false;

            if (systemType.Contains("Int"))
            {
                try
                {
                    Print(instance as int[]);
                }
                catch (Exception)
                {
                    PrintLine(instance as string);
                }

                return true;
            }

            if (systemType.Contains("String"))
            {
                try
                {
                    Print(instance as string[]);
                }
                catch (Exception)
                {
                    PrintLine(instance as string);
                }

                return true;
            }

            if (!systemType.Contains("List")) return false;

            var typeArguments = baseType.GetGenericArguments();

            if (typeArguments.Length < 1) return true;

            var dataType = typeArguments[0];

            if (dataType.Name.Contains("Int"))
            {
                var converted = instance as List<int>;
                if (converted?.Count > 0) Print(converted.ToArray());

                return true;
            }

            if (dataType.Name.Contains("String"))
            {
                var converted = instance as List<string>;
                if (converted?.Count > 0) Print(converted.ToArray());

                return true;
            }

            return false;
        }

        #endregion

        internal static bool IsItInterface(Type type)
        {
            if (!type.IsInterface) return false;

            var methods = type.GetMethods();
            var properties = type.GetProperties();

            Print(methods, properties, type.Name);

            return true;
        }

        #region Tree

        private static Tree GenerateTree(PropertyInfo[] properties, string className)
        {
            Tree tree =
                new Tree(string.IsNullOrEmpty(className) ? "Default" : className).Style($"{DumpperColor.Aqua.ToText()}");

            foreach (var property in properties)
                tree.AddNodes(new Markup($"[bold {DumpperColor.Red.ToText()}]{property.Name}[/]"));

            return tree;
        }


        private static Tree GenerateTree<T>(T instance, PropertyInfo[] properties, string className)
        {
            Tree tree
                = new Tree(string.IsNullOrEmpty(className) ? "Default" : className).Style($"{DumpperColor.Aqua.ToText()}");

            foreach (var property in properties)
            {
                if (property.PropertyType.FullName!.Contains("System"))
                {
                    if (property.PropertyType.FullName.Contains("Collection"))
                    {
                        var value = property.GetValue(instance, null);

                        if (value is null) continue;

                        var props = Activator.CreateInstance(property.PropertyType)!.GetType().GetProperties().LastOrDefault();

                        if (props is null) continue;

                        var branchTree
                            = new Tree(string.IsNullOrEmpty(property.Name) ? "Default" : property.Name).Style($"{DumpperColor.Aqua.ToText()}");

                        branchTree.AddNode(
                            renderable: GenerateList(props!.PropertyType.GetProperties(), (IEnumerable<object>)value));

                        tree.AddNode(branchTree);
                    }
                    else
                    {
                        var value = property.GetValue(instance, null);
                        tree!.AddNode(new Markup($"[bold {DumpperColor.Purple.ToText()}]{property.Name} [/] : {value}"));
                    }
                }
                else
                {
                    var newInstance = Activator.CreateInstance(property.PropertyType);
                    tree.AddNode(
                        renderable: GenerateTree(newInstance, property.PropertyType.GetProperties(), property.Name));
                }
            }

            return tree;
        }

        #endregion
    }
}