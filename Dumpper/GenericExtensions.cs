// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System.Reflection;
using Dumpper.Writer;

namespace Dumpper;

public static class GenericExtensions
{
    #region Generic Poco Extensions

    /// <summary>
    /// Print the value of this type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    public static void Dump<T>(this T instance) where T : class
    {
        var type = instance?.GetType() ?? typeof(T);

        var className = type?.Name;

        if (instance is null)
        {
            if (type is null) return;

            if (IsItInterface(type)) return;

            instance = (T)Activator.CreateInstance(type);
            Printer.Print(type.GetProperties(), className ?? string.Empty);

            Printer.PrintLine($"Empty instances {className}");
            return;
        }


        if (IsPrimitiveCollection(type, instance))
            return;

        var properties = type.GetProperties();
        Printer.Print(properties, className, instance);
    }

    /// <summary>
    /// Print the list of values of this types
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instances"></param>
    public static void Dump<T>(this List<T> instances) where T : class
    {
        if (instances is null || instances.Count < 1) return;

        var type = instances[0].GetType();

        foreach (var item in instances) if (!IsPrimitiveCollection(type, item)) break;

        var properties = type.GetProperties();
        Printer.PrintList(properties, instances);
    }

    private static bool IsPrimitiveCollection<T>(IReflect type, T instance)
    {
        var baseType = type?.UnderlyingSystemType;
        var systemType = baseType?.Name;

        if (baseType is null) return false;
        if (string.IsNullOrEmpty(systemType)) return false;

        if (systemType.Contains("Int"))
        {
            try
            {
                Printer.Print(instance as int[]);
            }
            catch (Exception)
            {
                Printer.PrintLine(instance as string);
            }

            return true;
        }

        if (systemType.Contains("String"))
        {
            try
            {
                Printer.Print(instance as string[]);
            }
            catch (Exception)
            {
                Printer.PrintLine(instance as string);
            }

            return true;
        }

        if (!systemType.Contains("List")) return false;

        var typeArguments = baseType.GetGenericArguments();

        if (typeArguments.Length < 1) return true;

        var convertionType = typeArguments[0];

        if (convertionType.Name.Contains("Int"))
        {
            var converted = instance as List<int>;
            if (converted?.Count > 0) Printer.Print(converted.ToArray());

            return true;
        }

        if (convertionType.Name.Contains("String"))
        {
            var converted = instance as List<string>;
            if (converted?.Count > 0) Printer.Print(converted.ToArray());

            return true;
        }

        return false;
    }

    private static bool IsItInterface(Type type)
    {
        if (!type.IsInterface) return false;

        var methods = type.GetMethods();
        var properties = type.GetProperties();

        Printer.Print(methods, properties, type.Name);

        return true;
    }

    #endregion

    #region Generic Dictionary Extensions

    /// <summary>
    /// Print the dictionary
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary"></param>
    public static void Dump<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
    {
        if (dictionary is null || dictionary.Count < 1) return;

        Printer.Print(dictionary);
    }

    /// <summary>
    /// Print the dictionary list
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionaries"></param>
    public static void Dump<TKey, TValue>(this List<Dictionary<TKey, TValue>> dictionaries)
    {
        if (dictionaries is null || dictionaries.Count < 1) return;

        Printer.PrintList(dictionaries);
    }

    /// <summary>
    /// Print the enumerable of dictionaries
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionaries"></param>
    public static void Dump<TKey, TValue>(this IEnumerable<Dictionary<TKey, TValue>> dictionaries)
    {
        if (dictionaries is null) return;

        var results = dictionaries.ToList();

        if (results.Count < 1) return;
        Printer.PrintList(results);
    }

    #endregion

    #region Tuple Extensions

    /// <summary>
    /// Print the Tuple
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <param name="tuple"></param>
    public static void Dump<T1>(this Tuple<T1> tuple)
    {
        if (tuple is null) return;
        Printer.Print(tuple);
    }

    /// <summary>
    /// Print the Tuple
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="tuple"></param>
    public static void Dump<T1, T2>(this Tuple<T1, T2> tuple)
    {
        if (tuple is null) return;
        Printer.Print(tuple);
    }

    /// <summary>
    /// Print the tuple
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <param name="tuple"></param>
    public static void Dump<T1, T2, T3>(this Tuple<T1, T2, T3> tuple)
    {
        if (tuple is null) return;
        Printer.Print(tuple);
    }

    /// <summary>
    /// Print the tuples
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <param name="tuple"></param>
    public static void Dump<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> tuple)
    {
        if (tuple is null) return;
        Printer.Print(tuple);
    }

    /// <summary>
    /// Print the tuples
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <param name="tuple"></param>
    public static void Dump<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> tuple)
    {
        if (tuple is null) return;
        Printer.Print(tuple);
    }

    /// <summary>
    /// Print the tuples
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    /// <param name="tuple"></param>
    public static void Dump<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        if (tuple is null) return;
        Printer.Print(tuple);
    }

    /// <summary>
    /// Print the tuples
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    /// <typeparam name="T7"></typeparam>
    /// <param name="tuple"></param>
    public static void Dump<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        if (tuple is null) return;
        Printer.Print(tuple);
    }

    /// <summary>
    /// Print the tuples
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    /// <typeparam name="T7"></typeparam>
    /// <typeparam name="TRest"></typeparam>
    /// <param name="tuple"></param>
    public static void Dump<T1, T2, T3, T4, T5, T6, T7, TRest>(this Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple)
    {
        if (tuple is null) return;
        Printer.Print(tuple);
    }

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    public static void Dump(this ValueTuple tuple) => Printer.Print(tuple);

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <typeparam name="T1"></typeparam>
    public static void Dump<T1>(this ValueTuple<T1> tuple) => Printer.Print(tuple);

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public static void Dump<T1, T2>(this ValueTuple<T1, T2> tuple) => Printer.Print(tuple);

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public static void Dump<T1, T2, T3>(this ValueTuple<T1, T2, T3> tuple) => Printer.Print(tuple);

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public static void Dump<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> tuple) => Printer.Print(tuple);

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    public static void Dump<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> tuple) => Printer.Print(tuple);

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    public static void Dump<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> tuple) =>
        Printer.Print(tuple);

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    /// <typeparam name="T7"></typeparam>
    public static void Dump<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple) =>
        Printer.Print(tuple);

    /// <summary>
    /// Print the value tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    /// <typeparam name="T7"></typeparam>
    /// <typeparam name="TRest"></typeparam>
    public static void Dump<T1, T2, T3, T4, T5, T6, T7, TRest>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple)
        where TRest : struct => Printer.Print(tuple);

    #endregion
}