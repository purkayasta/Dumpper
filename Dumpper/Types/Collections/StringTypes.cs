using Dumpper.Printer;

namespace Dumpper.Types.Collections
{
	public static class StringTypes
	{
		public static void Dump(this string[] arr) => PrimitiveArrayPrinter.Print(arr);
	}
}
