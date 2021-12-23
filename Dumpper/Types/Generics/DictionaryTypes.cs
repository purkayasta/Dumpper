using Dumpper.Printer;
using Spectre.Console;

namespace Dumpper.Types.Generics
{
	public static class DictionaryTypes
	{
		public static void Dump<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				PrimitiveValuePrinter.PrintLine($"Dictonary is empty 😞");
				return;
			}
			GenericDictonaryPrinter.Print(dictionary);
		}

		public static void Dump<TKey, TValue>(this List<Dictionary<TKey, TValue>> dictionaries)
		{
			if (dictionaries.Count < 1)
			{
				PrimitiveValuePrinter.PrintLine("Dictonary List is empty 😭");
			}

			GenericDictonaryPrinter.PrintList(dictionaries);
		}
	}
}
