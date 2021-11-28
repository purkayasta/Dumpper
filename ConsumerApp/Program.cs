using Dumpper.PrimitiveTypes;

"Hello World".Dump();

"Hello World With Text".Dump("This is a header");


new string[2] { "Hello", "World" }.Dump();


new List<string> { "Hello ", "World" }.Dump();