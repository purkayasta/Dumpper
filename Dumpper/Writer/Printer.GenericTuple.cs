// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Dumpper.Shared;
using Spectre.Console;

namespace Dumpper.Writer
{
    internal sealed partial class Printer
    {
        internal static void Print<T>(ValueTuple<T> tuple)
        {
            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1>(ValueTuple<T, T1> tuple)
        {
            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2>(ValueTuple<T, T1, T2> tuple)
        {
            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3>(ValueTuple<T, T1, T2, T3> tuple)
        {
            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3, T4>(ValueTuple<T, T1, T2, T3, T4> tuple)
        {
            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3, T4, T5>(ValueTuple<T, T1, T2, T3, T4, T5> tuple)
        {
            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3, T4, T5, T6>(ValueTuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3, T4, T5, T6, TRest>(ValueTuple<T, T1, T2, T3, T4, T5, T6, TRest> tuple)
            where TRest : struct
        {
            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T>(Tuple<T> tuple)
        {
            if (tuple is null) return;

            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1>(Tuple<T, T1> tuple)
        {
            if (tuple is null) return;

            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2>(Tuple<T, T1, T2> tuple)
        {
            if (tuple is null) return;

            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3>(Tuple<T, T1, T2, T3> tuple)
        {
            if (tuple is null) return;

            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3, T4>(Tuple<T, T1, T2, T3, T4> tuple)
        {
            if (tuple is null) return;

            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3, T4, T5>(Tuple<T, T1, T2, T3, T4, T5> tuple)
        {
            if (tuple is null) return;

            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3, T4, T5, T6>(Tuple<T, T1, T2, T3, T4, T5, T6> tuple)
        {
            if (tuple is null) return;

            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        internal static void Print<T, T1, T2, T3, T4, T5, T6, TRest>(Tuple<T, T1, T2, T3, T4, T5, T6, TRest> tuple)
        {
            if (tuple is null) return;

            var tree = GenerateTupleTree(tuple);

            if (tree is null) return;

            AnsiConsole.Write(tree);
        }

        private static Tree? GenerateTupleTree<T>(T tupleInstance)
        {
            var type = typeof(T);
            var properties = type.GetProperties();

            if (properties.Length < 1)
            {
                AnsiConsole.Write(new Markup($"[{DumpperColor.LightGreen}]{tupleInstance}[/]"));
                return null;
            }

            var tree = new Tree(type.Name).Style($"{DumpperColor.LightGreen.ToText()}");

            foreach (var property in properties)
            {
                tree.AddNodes(new Markup(
                    $"[{DumpperColor.Olive.ToText()}]{property?.Name} [/] : {property?.GetValue(tupleInstance, null)}"));
            }

            return tree;
        }
    }
}