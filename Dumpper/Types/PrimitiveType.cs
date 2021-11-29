using Dumpper.Printer;

namespace Dumpper.Types
{
    public static class PrimitiveType
    {
        public static void Dump(this ValueType val) => PrimitiveValue.PrintLine(val?.ToString());
        public static void Dump(this ValueType val, string header) => PrimitiveValue.PrintLine(val?.ToString(), header);
        public static void Dump(this string val) => PrimitiveValue.PrintLine(val);
        public static void Dump(this string val, string startingText) => PrimitiveValue.PrintLine(val, startingText);
    }
}
