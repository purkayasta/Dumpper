using System;
using Dumpper.Types.Collections;
// using Dumpper.Types;
// using Dumpper.Types.Collections;

namespace ConsumerApp;
public class Tasks
{
    public static void Execute()
    {
        Model model = new()
        {
            Name = "Pritom Purkayasta",
            CreatedOn = DateTime.UtcNow,
            CreatedAtDateTimeUtc = DateOnly.FromDateTime(DateTime.UtcNow)
        };

        model.Dump();

        huda.tes2.ToString().Dump();
    }

    internal class Model
    {
        public string? Name { get; set; } = default;
        public DateTime CreatedOn { get; set; }
        public DateOnly CreatedAtDateTimeUtc { get; set; }
    }

}

