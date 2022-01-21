using System.Reflection;
using Spectre.Console;

namespace Dumpper.Printer
{
    internal static class InterfacePrinter
    {
        internal static void Print(MethodInfo[] methods, PropertyInfo[] properties, string name)
        {
            var tree = new Tree(name).Style("aqua");

            foreach (var property in properties) tree.AddNodes(new Markup($"[deepskyblue1]{property.Name}[/]"));

            foreach (var method in methods)
            {
                if (method.Name.StartsWith("set_") || method.Name.StartsWith("get_")) continue;
                tree.AddNodes(new Markup($"[royalblue1]{method.Name}()[/]"));
            }

            AnsiConsole.Write(tree);
        }
    }
}
