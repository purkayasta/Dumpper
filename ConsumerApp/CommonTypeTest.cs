

using Dumpper.Types.Collections;

namespace ConsumerApp
{
	enum huda
	{
		test,
		tes2
	};

	internal class CommonTypeTest
	{
		internal void Execute()
		{
			List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
			int[] vs = list.ToArray();
			string[] strArray = new string[5] { "asd", string.Empty, "23", "", "rgdf" };

			//vs.Dump(); //=> base type
			list.Dump(); //=> generic type
			strArray.Dump(); // =>
		}
	}
}
