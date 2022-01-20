using Dumpper.Printer;

namespace Dumpper.Types.Collections
{
	public static class FloatTypes
	{
		public static void Dump(this float[] arr) => PrimitiveArrayPrinter.Print(arr);
		public static void Dump(this IEnumerable<float> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
		public static void Dump(this List<float> vals) => PrimitiveArrayPrinter.Print(vals.ToArray());
	}
}