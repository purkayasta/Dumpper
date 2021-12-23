using System.Collections;
using Dumpper.Printer;

namespace Dumpper.Types.Generics
{
	public static class ClassTypes
	{
		public static void Dump<T>(this T instance) where T : class
		{
			var className = typeof(T).Name;

			if (instance == null)
			{
				instance = (T)Activator.CreateInstance(typeof(T));
				GenericClassPrinter<T>.Print(instance.GetType().GetProperties(), className);
				PrimitiveValuePrinter.PrintLine($"Empty instances {className}");

				return;
			}

			var properties = instance.GetType().GetProperties();

			GenericClassPrinter<T>.Print(properties, className, instance);
		}

		public static void Dump<T>(this List<T> instances) where T : class
		{
			if (instances.Count < 1)
			{
				PrimitiveValuePrinter.PrintLine("No Value Found");
				return;
			}

			var types = instances[0].GetType();

			bool isDict = types.GetGenericTypeDefinition() == typeof(Dictionary<,>);
			bool isTuples = types.GetGenericTypeDefinition() == typeof(Tuple<,>);
			bool isHashMaps = types.GetGenericTypeDefinition() == typeof(Hashtable);

			if (isDict)
			{
				System.Console.WriteLine("It is dictonary type");
			}

			if (isTuples)
			{
				System.Console.WriteLine("It is a tuple type");
			}

			if (isHashMaps)
			{
				System.Console.WriteLine("It is a hash map");
			}

			var properties = types.GetProperties();

			GenericClassPrinter<T>.PrintList(properties, instances);
		}
	}
}
