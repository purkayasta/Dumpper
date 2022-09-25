﻿using System.Reflection;
using Dumpper.Shared;
using Spectre.Console;

namespace Dumpper.Writer;

internal sealed partial class Printer
{
    internal static void Print(MethodInfo[] methods, PropertyInfo[] properties, string name)
    {
        var tree = new Tree(name).Style(DumpperColor.Aqua.ToText());

        foreach (var property in properties) tree.AddNodes(new Markup($"[deepskyblue1]{property.Name}[/]"));

        foreach (var method in methods)
        {
            if (method.Name.StartsWith("set_") || method.Name.StartsWith("get_")) continue;
            tree.AddNodes(new Markup($"[royalblue1]{method.Name}()[/]"));
        }

        AnsiConsole.Write(tree);
    }
}