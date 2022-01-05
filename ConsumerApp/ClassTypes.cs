

using Dumpper.Types.Collections.Generics;

namespace ConsumerApp
{
    internal class ClassTypes
	{
		internal void Execute()
		{
			var model = new List<Model>();
			model.Add(new Model
			{
				Name = "123"
			});
			model.Add(new Model
			{
				Name = "321"
			});
			model.Add(new Model
			{
				Name = "Kazi"
			});

			Model model2 = new Model();
			model2.Dump();

			model.Dump();
		}
	}

	internal class Model : Base, IModel
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }
		public DateTime CreatedOn { get; set; }

		public void Get()
		{
			Console.WriteLine("asdasd");
		}
	}

	internal class Base
	{
		public DateTime ModifiedOn { get; set; } = new DateTime();
	}

	internal interface IModel
	{

		public void Get();
	}
}
