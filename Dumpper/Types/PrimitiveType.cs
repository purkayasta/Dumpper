using Dumpper.Printer;

namespace Dumpper.Types
{
    public static class PrimitiveType
    {
        public static void Dump(this ValueType val) => PrimitiveValuePrinter.PrintLine(val?.ToString());
        public static void Dump(this ValueType val, string header) => PrimitiveValuePrinter.PrintLine(val?.ToString(), header);
        public static void Dump(this string val) => PrimitiveValuePrinter.PrintLine(val);
        public static void Dump(this string val, string startingText) => PrimitiveValuePrinter.PrintLine(val, startingText);
    }
}
