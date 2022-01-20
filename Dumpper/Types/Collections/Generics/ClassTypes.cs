using Dumpper.Printer;

namespace Dumpper.Types.Collections
{
    public static class ClassTypes
    {
        public static void Dump<T>(this T instance) where T : class
        {
            var className = typeof(T).Name;

            if (instance == null)
            {
                instance = (T)Activator.CreateInstance(typeof(T));
                GenericClassPrinter.Print(instance.GetType().GetProperties(), className);
                PrimitiveValuePrinter.PrintLine($"Empty instances {className}");
                return;
            }
            var type = instance.GetType();

            if (CollectionCheck(type, instance))
                return;

            var properties = type.GetProperties();
            GenericClassPrinter.Print(properties, className, instance);
        }

        public static void Dump<T>(this List<T> instances) where T : class
        {
            if (instances.Count < 1)
            {
                PrimitiveValuePrinter.PrintLine("No Value Found");
                return;
            }

            var types = instances[0].GetType();

            // bool isDict = types.GetGenericTypeDefinition() == typeof(Dictionary<,>);
            // bool isTuples = types.GetGenericTypeDefinition() == typeof(Tuple<,>);
            // bool isHashMaps = types.GetGenericTypeDefinition() == typeof(Hashtable);

            // if (isDict)
            // {
            //     Console.WriteLine("It is dictonary type");
            // }

            // if (isTuples)
            // {
            //     System.Console.WriteLine("It is a tuple type");
            // }

            // if (isHashMaps)
            // {
            //     System.Console.WriteLine("It is a hash map");
            // }

            var properties = types.GetProperties();

            GenericClassPrinter.PrintList(properties, instances);
        }

        private static bool CollectionCheck<T>(Type type, T instance)
        {
            var underlyingBaseType = type.UnderlyingSystemType;
            var underlyingSystemName = type.UnderlyingSystemType.Name;

            if (underlyingSystemName.Contains("Int"))
            {
                PrimitiveArrayPrinter.Print(instance as int[]);
                return true;
            }

            if (underlyingSystemName.Contains("String"))
            {
                PrimitiveArrayPrinter.Print(instance as string[]);
                return true;
            }

            if (underlyingSystemName.Contains("List"))
            {
                var typeArguments = underlyingBaseType.UnderlyingSystemType.GetGenericArguments();
                if (typeArguments.Length > 0)
                {
                    var convertionType = typeArguments[0];

                    if (convertionType.Name.Contains("Int"))
                    {
                        var converted = instance as List<int>;
                        if (converted.Count > 0)
                            PrimitiveArrayPrinter.Print(converted.ToArray());
                    }

                    if (convertionType.Name.Contains("String"))
                    {
                        var converted = instance as List<string>;
                        if (converted.Count > 0)
                            PrimitiveArrayPrinter.Print(converted.ToArray());
                    }
                }

                return true;
            }

            return false;
        }
    }
}
