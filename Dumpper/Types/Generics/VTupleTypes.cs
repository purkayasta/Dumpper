using Dumpper.Printer;

namespace Dumpper.Types.Generics
{
    public static class VTupleTypes
    {
        public static void Dump(this ValueTuple tuple)
        {
            TuplePrinter.Print(tuple);
        }


        public static void Dump<T1>(this ValueTuple<T1> tuple)
        {
            TuplePrinter.Print(tuple);
        }

        public static void Dump<T1, T2>(this ValueTuple<T1, T2> tuple)
        {
            TuplePrinter.Print(tuple);
        }
        public static void Dump<T1, T2, T3>(this ValueTuple<T1, T2, T3> tuple)
        {
            TuplePrinter.Print(tuple);
        }
        public static void Dump<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> tuple)
        {
            TuplePrinter.Print(tuple);
        }

        public static void Dump<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> tuple)
        {
            TuplePrinter.Print(tuple);
        }

        public static void Dump<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> tuple)
        {
            TuplePrinter.Print(tuple);
        }

        public static void Dump<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple)
        {
            TuplePrinter.Print(tuple);
        }

        public static void Dump<T1, T2, T3, T4, T5, T6, T7, TRest>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : struct
        {
            TuplePrinter.Print(tuple);
        }
    }
}
