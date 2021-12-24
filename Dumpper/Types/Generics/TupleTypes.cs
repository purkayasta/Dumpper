using Dumpper.Printer;
using Spectre.Console;

namespace Dumpper.Types.Generics
{
	public static class TupleTypes
	{
		public static void Dump<T1>(this Tuple<T1> tuple)
		{
			if (tuple == null)
			{
				PrimitiveValuePrinter.PrintLine($"Tuple is empty 😭", Color.Red1);
				return;
			}

            Console.WriteLine(tuple.Item1);
		}
		public static void Dump<T1, T2>(this Tuple<T1, T2> tuple)
		{
			if (tuple == null)
            {
				PrimitiveValuePrinter.PrintLine($"Tuple is empty 😭", Color.Red1);
				return;
            }
		}
		public static void Dump<T1, T2, T3>(this Tuple<T1, T2, T3> tuple)
		{

		}
		public static void Dump<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> tuple)
		{

		}

		public static void Dump<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> tuple)
		{

		}

		public static void Dump<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> tuple)
		{

		}

		public static void Dump<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
		{

		}

		public static void Dump<T1, T2, T3, T4, T5, T6, T7, TRest>(this Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple)
		{

		}
	}
}
