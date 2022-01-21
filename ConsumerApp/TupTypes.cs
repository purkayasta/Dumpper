using System;
using Dumpper.Types.Collections;
namespace ConsumerApp
{
	public class TupTypes
	{
		public void Execute()
		{
			var tuple = Tuple.Create<int, int, string, string, int>(1, 2, "Pritom", "Purkayasta", 12);
			tuple.Dump();

			//var t1 = (12, 12, 12, 12, 12, 12, 12);
			//t1.Dump();

			var valueType = (1, 2, (1, 2), 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, ("Pritom", "Purkayasta"));
			valueType.Dump();
		}
	}
}
