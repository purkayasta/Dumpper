// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Dumpper.Writer;

namespace Dumpper;

public static class BasicExtensions
{
    /// <summary>
    /// Print the integer value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this int val) => Dump(val.ToString());

    /// <summary>
    /// Print the integer with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this int val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the float value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this float val) => Dump(val.ToString());

    /// <summary>
    /// Print the float value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this float val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the double value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this double val) => Dump(val.ToString());

    /// <summary>
    /// Print the double value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this double val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the decimal value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this decimal val) => Dump(val.ToString());

    /// <summary>
    /// Print the decimal value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this decimal val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the Guid value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this Guid val) => Dump(val.ToString());

    /// <summary>
    /// Print the guid value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this Guid val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the datetime value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this DateTime val) => Dump(val.ToString());

    /// <summary>
    /// print the datetime value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this DateTime val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the timespan value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this TimeSpan val) => Dump(val.ToString());

    /// <summary>
    /// Print the timespan value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this TimeSpan val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the Timeonly value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this TimeOnly val) => Dump(val.ToString());

    /// <summary>
    /// Print the time only value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this TimeOnly val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the Uri value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this Uri val) => Dump(val.ToString());

    /// <summary>
    /// Print the Uri value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this Uri val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the long value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this long val) => Dump(val.ToString());

    /// <summary>
    /// Print the long value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this long val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the ulong value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this ulong val) => Dump(val.ToString());

    /// <summary>
    /// Print the ulong value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this ulong val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// print the uint value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this uint val) => Dump(val.ToString());

    /// <summary>
    /// print the uint value with own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this uint val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// print the ushort value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this ushort val) => Dump(val.ToString());

    /// <summary>
    /// print the ushort value with own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this ushort val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// print the short value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this short val) => Dump(val.ToString());

    /// <summary>
    /// Print the short value with own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this short val, string headerTxt) => Dump(val.ToString(), headerTxt);

    /// <summary>
    /// Print the string value.
    /// </summary>
    /// <param name="val"></param>
    public static void Dump(this string val)
    {
        if (val is null || val.Length < 1) return;
        Printer.PrintLine(val);
    }

    /// <summary>
    /// Print the string value with your own header text.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="headerTxt"></param>
    public static void Dump(this string val, string headerTxt)
    {
        if (val is null || val.Length < 1) return;
        Printer.PrintLine(val, headerTxt);
    }
}
