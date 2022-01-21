using System;
using System.Collections.Generic;
using Dumpper.Types.Collections;

namespace ConsumerApp;
public class Tasks
{
	public static void Execute()
	{
		Model model = new Model();
		model.Dump();
	}

	internal class Model
	{
		public string? Name { get; set; } = default;
		public DateTime CreatedOn { get; set; }
	}

}

