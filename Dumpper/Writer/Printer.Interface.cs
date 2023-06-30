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
        internal static void Print(MethodInfo[] methods, PropertyInfo[] properties, string name)
        {
            var tree = new Tree(name).Style($"{DumpperColor.Aqua.ToText()}");

            foreach (var property in properties)
                tree.AddNodes(new Markup($"[{DumpperColor.DeepSkyBlue1.ToText()}]{property.Name}[/]"));

            foreach (var method in methods)
            {
                if (method.Name.StartsWith("set_") || method.Name.StartsWith("get_")) continue;
                tree.AddNodes(new Markup($"[{DumpperColor.RoyalBlue1.ToText()}]{method.Name}()[/]"));
            }

            AnsiConsole.Write(tree);
        }
    }
}