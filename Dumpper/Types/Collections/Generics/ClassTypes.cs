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
                if (IsItInterface(typeof(T))) return;

                instance = (T)Activator.CreateInstance(typeof(T));
                GenericClassPrinter.Print(instance.GetType().GetProperties(), className);
                PrimitiveValuePrinter.PrintLine($"Empty instances {className}");
                return;
            }
            var type = instance.GetType();

            if (IsPrimitiveCollection(type, instance))
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

            var type = instances[0].GetType();

            foreach (var item in instances)
            {
                if (!IsPrimitiveCollection(type, item)) break;
            }

            var properties = type.GetProperties();
            GenericClassPrinter.PrintList(properties, instances);
        }

        private static bool IsPrimitiveCollection<T>(Type type, T instance)
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

        private static bool IsItInterface(Type type)
        {
            if (!type.IsInterface) return false;

            var methods = type.GetMethods();
            var properties = type.GetProperties();

            InterfacePrinter.Print(methods, properties, type.Name);

            return true;
        }
    }
}
