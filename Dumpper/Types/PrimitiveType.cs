using Dumpper.Printer;

namespace Dumpper.Types
{
    public static class PrimitiveType
    {
        public static void Dump(this int val) => Dump(val.ToString());
        public static void Dump(this int val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this float val) => Dump(val.ToString());
        public static void Dump(this float val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this double val) => Dump(val.ToString());
        public static void Dump(this double val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this decimal val) => Dump(val.ToString());
        public static void Dump(this decimal val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this Guid val) => Dump(val.ToString());
        public static void Dump(this Guid val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this DateTime val) => Dump(val.ToString());
        public static void Dump(this DateTime val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this TimeSpan val) => Dump(val.ToString());
        public static void Dump(this TimeSpan val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this TimeOnly val) => Dump(val.ToString());
        public static void Dump(this TimeOnly val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this Uri val) => Dump(val.ToString());
        public static void Dump(this Uri val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this long val) => Dump(val.ToString());
        public static void Dump(this long val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this ulong val) => Dump(val.ToString());
        public static void Dump(this ulong val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this uint val) => Dump(val.ToString());
        public static void Dump(this uint val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this ushort val) => Dump(val.ToString());
        public static void Dump(this ushort val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this short val) => Dump(val.ToString());
        public static void Dump(this short val, string headerTxt) => Dump(val.ToString(), headerTxt);

        public static void Dump(this string val) => PrimitiveValuePrinter.PrintLine(val);
        public static void Dump(this string val, string startingText) => PrimitiveValuePrinter.PrintLine(val, startingText);
    }
}
