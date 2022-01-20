using Dumpper.Printer;

namespace Dumpper.Types.Collections
{
	public static class DecimalTypes
	{
		public static void Dump(this decimal[] arr) => PrimitiveArrayPrinter.Print(arr);
		public static void Dump(this IEnumerable<decimal> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
		public static void Dump(this List<decimal> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
	}
}