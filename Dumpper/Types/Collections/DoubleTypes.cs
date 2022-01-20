using Dumpper.Printer;

namespace Dumpper.Types.Collections
{
	public static class DoubleTypes
	{
		public static void Dump(this double[] arr) => PrimitiveArrayPrinter.Print(arr);
		public static void Dump(this IEnumerable<double> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
		public static void Dump(this List<double> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
	}
}