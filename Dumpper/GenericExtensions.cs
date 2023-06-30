// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System.Reflection;
using Dumpper.Writer;

namespace Dumpper
{
    public static class GenericClassExtensions
    {
        #region Generic Poco Extensions

        /// <summary>
        /// Print the instance value.
        /// </summary>
        /// <typeparam name="T?"></typeparam>
        /// <param name="instance"></param>
        public static void Dump<T>(this T? instance) where T : class
        {
            var type = instance?.GetType() ?? typeof(T);

            var className = type?.Name;

            if (instance is null)
            {
                if (type is null) return;

                if (Printer.IsItInterface(type)) return;

                instance = (T?)Activator.CreateInstance(type);
                Printer.Print(type.GetProperties(), className ?? string.Empty);

                Printer.PrintLine($"Empty instances {className}");
                return;
            }


            if (Printer.IsPrimitiveCollection(type!, instance))
                return;

            var properties = type!.GetProperties();
            Printer.Print(properties, className!, instance);
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

            foreach (var item in instances)
            {
                if (!Printer.IsPrimitiveCollection(type, item))
                    break;
            }

            var properties = type.GetProperties();
            Printer.PrintList(properties, instances);
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

    public static class GenericStructExtension
    {
        /// <summary>
        /// Print the struct value.
        /// </summary>
        /// <param name="instance"></param>
        /// <typeparam name="T"></typeparam>
        public static void Dump<T>(this T instance) where T : struct
        {
            var type = typeof(T);
            var className = type.Name;

            if (Printer.IsItEnum(type, instance)) return;

            var properties = type.GetProperties();
            Printer.Print(properties, className, instance);
        }

        /// <summary>
        /// Print the list of structs
        /// </summary>
        /// <param name="instances"></param>
        /// <typeparam name="T"></typeparam>
        public static void Dump<T>(this List<T> instances) where T : struct
        {
            if (instances.Count < 1) return;

            var type = instances[0].GetType();

            foreach (var item in instances)
            {
                if (!Printer.IsPrimitiveCollection(type, item))
                    break;
            }

            var properties = type.GetProperties();
            Printer.PrintList(properties, instances);
        }

        /// <summary>
        /// Print the Enumerable of structs.
        /// </summary>
        /// <param name="instances"></param>
        /// <typeparam name="T"></typeparam>
        public static void Dump<T>(this IEnumerable<T> instances) where T : struct
        {
            var resultingInstance = instances.ToList();

            if (resultingInstance.Count < 1) return;

            var type = resultingInstance[0].GetType();

            foreach (var item in resultingInstance)
            {
                if (!Printer.IsPrimitiveCollection(type, item))
                    break;
            }

            var properties = type.GetProperties();
            Printer.PrintList(properties, resultingInstance);
        }
    }
}