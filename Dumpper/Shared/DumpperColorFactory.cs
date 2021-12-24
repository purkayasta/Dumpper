using Spectre.Console;

namespace Dumpper.Shared
{
	public class DumpperColorFactory
	{
		public Color GetColor(DumpperColor color)
		{
			return color switch
			{
				DumpperColor.Maroon => Color.Maroon,
				DumpperColor.Green => Color.Green1,
				DumpperColor.LightGreen => Color.LightGreen_1,
				DumpperColor.Cyan => Color.Cyan1,
				DumpperColor.Navy => Color.Navy,
				DumpperColor.Olive => Color.Olive,
				DumpperColor.Red => Color.Red1,
				DumpperColor.DarkRed => Color.DarkRed_1,
				_ => Color.LightCoral
			};
		}
	}
}
