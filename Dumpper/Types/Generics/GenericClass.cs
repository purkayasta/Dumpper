using Spectre.Console;

namespace Dumpper.Types.Generics
{
    public static class GenericClass
    {
        public static void Dump<T>(this T instance) where T : class
        {
            var className = typeof(T).Name;
            var properties = instance.GetType().GetProperties();

            var tree = new Tree(className).Style("Green");

            foreach (var property in properties)
            {
                tree.AddNodes(new Markup($"[bold yellow1]{property?.Name} [/] : {property?.GetValue(instance, null)}"));
            }
            AnsiConsole.Write(tree);
        }

        public static void Dump<T>(this List<T> instances) where T : class
        {
            if (instances.Count < 1)
                AnsiConsole.WriteLine("No Value Found");

            var properties = instances[0].GetType().GetProperties();

            var table = new Table();

            foreach (var prop in properties)
                table.AddColumn(new TableColumn($"[yellow1]{prop.Name}[/]").Centered());

            string[] columnValues = new string[properties.Length];

            foreach (var instance in instances)
            {
                for (int i = 0; i < properties.Length; i++)
                {
                    var values = properties[i].GetValue(instance);
                    if (values != null)
                        columnValues[i] = values?.ToString();
                    else
                        columnValues[i] = string.Empty;
                }

                table.AddRow(columnValues);

                Array.Clear(columnValues, 0, columnValues.Length);
            }

            AnsiConsole.Write(table);
        }
    }
}
