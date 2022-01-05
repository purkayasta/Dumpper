using Dumpper.Printer;
using Spectre.Console;

namespace Dumpper.Types.Collections.Generics
{
    public static class DictionaryTypes
    {
        public static void Dump<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                PrimitiveValuePrinter.PrintLine($"Dictionary is empty 😞", Color.Red1);
                return;
            }
            GenericDictonaryPrinter.Print(dictionary);
        }

        public static void Dump<TKey, TValue>(this List<Dictionary<TKey, TValue>> dictionaries)
        {
            if (dictionaries.Count < 1)
            {
                PrimitiveValuePrinter.PrintLine("Dictionary List is empty 😭", Color.Red1);
            }

            GenericDictonaryPrinter.PrintList(dictionaries);
        }

        public static void Dump<TKey, TValue>(this IEnumerable<Dictionary<TKey, TValue>> dictionaries)
        {
            dictionaries.ToList().Dump();
        }
    }
}
