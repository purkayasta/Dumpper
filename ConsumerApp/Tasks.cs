


using Dumpper.Types.Collections.Generics;

namespace ConsumerApp;
public class Tasks
{
	public static void Execute()
	{

		Model m = new();
		m.Name = "Pritom";
		Dictionary<Model, string> keyValuePairs = new();
		keyValuePairs.Add(m, "Purkayasta");
		keyValuePairs.Dump();
	}

	internal class Model
	{
		public string Name { get; set; } = default;
	}
}