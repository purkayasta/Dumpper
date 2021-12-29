using Spectre.Console;

namespace Dumpper.Printer
{
    public class GenericDictonaryPrinter
    {
        internal static void Print<TKey, TValue>(Dictionary<TKey, TValue> instance)
        {
            var table = CreateTable(instance);

            AnsiConsole.Write(table);
        }

        private static Table CreateTable<TKey, TValue>(Dictionary<TKey, TValue> instance)
        {
            var dictonaryTable = new Table();

            dictonaryTable.AddColumn("Key");
            dictonaryTable.AddColumn("Value");

            foreach (var item in instance)
            {
                dictonaryTable.AddRow(item.Key.ToString(), item.Value.ToString());
            }

            return dictonaryTable;
        }

        internal static void PrintList<TKey, TValue>(List<Dictionary<TKey, TValue>> instances)
        {
            var totalCount = instances.Count;
            var dictonaryTree = new Tree(totalCount.ToString()).Guide(TreeGuide.Line);

            for (int count = 0; count < totalCount; count++)
            {
                var node = dictonaryTree.AddNode(count.ToString());
                node.AddNode(CreateTable(instances[count]));
            }

            AnsiConsole.Write(dictonaryTree);
        }

    }
}
