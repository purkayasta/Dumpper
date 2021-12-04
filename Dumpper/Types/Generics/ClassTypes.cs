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
                GenericPrinter<T>.Print(instance.GetType().GetProperties(), className);
                PrimitiveValuePrinter.PrintLine($"Empty instances {className}");

                return;
            }

            var properties = instance.GetType().GetProperties();

            GenericPrinter<T>.Print(properties, className, instance);
        }

        public static void Dump<T>(this List<T> instances) where T : class
        {
            if (instances.Count < 1)
            {
                PrimitiveValuePrinter.PrintLine("No Value Found");
                return;
            }

            var properties = instances[0].GetType().GetProperties();

            GenericPrinter<T>.PrintList(properties, instances);
        }
    }
}
