using System.Reflection;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Dumpper.Printer
{
	public class GenericDictonaryPrinter
	{
		internal static void Print<TKey, TValue>(Dictionary<TKey, TValue> instance)
		{
			var table = CreateTable(instance);

			AnsiConsole.Write(table);
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

		private static IRenderable GenerateColumn(PropertyInfo[] propertyInfos, string className)
		{
			var tree = GenericClassPrinter.GenerateTree(propertyInfos, className);
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
			var dictonaryTable = new Table();

			dictonaryTable.AddColumn("Key");
			dictonaryTable.AddColumn("Value");

			foreach (var item in instance)
			{
				var keyType = IsNonStringClass(typeof(TKey));
				var valueType = IsNonStringClass(typeof(TValue));

				if (keyType && valueType)
				{
					var keyProperties = item.Key.GetType().GetProperties();
					var valueProperties = item.Key.GetType().GetProperties();

					dictonaryTable.AddRow(GenerateColumn(keyProperties, typeof(TKey).Name), GenerateColumn(valueProperties, typeof(TValue).Name));
				}
				else if (keyType)
				{
					var keyProperties = item.Key.GetType().GetProperties();
					dictonaryTable.AddRow(GenerateColumn(keyProperties, typeof(TKey).Name), new Markup(item.Value.ToString()));
				}
				else if (valueType)
				{
					var valueProperties = item.Value.GetType().GetProperties();
					dictonaryTable.AddRow(new Markup(item.Key.ToString()), GenerateColumn(valueProperties, typeof(TValue).Name));
				}
				else
				{
					dictonaryTable.AddRow(item.Key.ToString(), item.Value.ToString());
				}
			}

			return dictonaryTable;
		}
	}
}
