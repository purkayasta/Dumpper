using Dumpper.Shared;
using Spectre.Console;

namespace Dumpper.Printer
{
    internal class TuplePrinter
    {
        internal static void Print<T>(T instance)
        {
            var type = typeof(T);
            var properties = type.GetProperties();
            
            if (properties.Length < 1)
            {
                PrintValueTuple(instance);
                return;
            }

            var tree = new Tree(type.Name).Style(DumpperColor.LightGreen.ToString());
            foreach (var property in properties)
            {
                tree.AddNodes(new Markup($"[{DumpperColor.Olive}]{property?.Name} [/] : {property?.GetValue(instance, null)}"));
            }
            AnsiConsole.Write(tree);
        }
        private static void PrintValueTuple<T>(T tuples)
        {
            Console.WriteLine(tuples);
        }
        
    }
}
