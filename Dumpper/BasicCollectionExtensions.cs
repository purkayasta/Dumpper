using Dumpper.Writer;

namespace Dumpper;

public static class BasicCollectionExtensions
{
    #region Decimal Collections

    /// <summary>
    /// Print the decimal array.
    /// </summary>
    /// <param name="arr"></param>
    public static void Dump(this decimal[] arr)
    {
        if (arr.Length < 1) return;
        Printer.Print(arr);
    }

    /// <summary>
    /// Print the decimal enumerable.
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this IEnumerable<decimal> values)
    {
        var result = values.ToArray();
        if (result.Length < 1) return;
        Printer.Print(result);
    }

    /// <summary>
    /// Print the decimal list.
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this List<decimal> values)
    {
        if (values.Count < 1) return;
        Printer.Print(values.ToArray());
    }

    #endregion

    #region Double Collections

    /// <summary>
    /// Print the double's array
    /// </summary>
    /// <param name="arr"></param>
    public static void Dump(this double[] arr)
    {
        if (arr.Length < 1) return;
        Printer.Print(arr);
    }

    /// <summary>
    /// Print the double's enumeration
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this IEnumerable<double> values)
    {
        var result = values.ToArray();
        if (result.Length < 1) return;
        Printer.Print(result);
    }

    /// <summary>
    /// Print the double's list
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this List<double> values)
    {
        if (values.Count < 1) return;
        Printer.Print(values.ToArray());
    }

    #endregion

    #region Float Collections

    /// <summary>
    /// Print the float array
    /// </summary>
    /// <param name="arr"></param>
    public static void Dump(this float[] arr)
    {
        if (arr.Length < 1) return;
        Printer.Print(arr);
    }

    /// <summary>
    /// Print the float enumerable
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this IEnumerable<float> values)
    {
        var result = values.ToArray();
        if (result.Length < 1) return;
        Printer.Print(result);
    }

    /// <summary>
    /// Print the float list
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this List<float> values)
    {
        if (values.Count < 1) return;
        Printer.Print(values.ToArray());
    }

    #endregion

    #region Int Collections

    /// <summary>
    /// Print the array of integers
    /// </summary>
    /// <param name="arr"></param>
    public static void Dump(this int[] arr)
    {
        if (arr.Length < 1) return;
        Printer.Print(arr);
    }

    /// <summary>
    /// Print the Enumerable of integers
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this IEnumerable<int> values)
    {
        var result = values.ToArray();
        if (result.Length < 1) return;
        Printer.Print(result);
    }

    /// <summary>
    /// Print the List of integers
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this List<int> values)
    {
        if (values.Count < 1) return;
        Printer.Print(values.ToArray());
    }

    #endregion

    #region String Collections

    /// <summary>
    /// Print the array of strings
    /// </summary>
    /// <param name="arr"></param>
    public static void Dump(this string[] arr)
    {
        if (arr.Length < 1) return;
        Printer.Print(arr);
    }

    /// <summary>
    /// Print the Enumerable of strings
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this IEnumerable<string> values)
    {
        var result = values.ToArray();
        if (result.Length < 1) return;
        Printer.Print(result);
    }

    /// <summary>
    /// Print the list of strings
    /// </summary>
    /// <param name="values"></param>
    public static void Dump(this List<string> values)
    {
        if (values.Count < 1) return;
        Printer.Print(values);
    }

    #endregion
}