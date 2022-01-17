

- Cannot identify array vs generic class (Using statements) ✔
```c#
using Dumpper.Types.Arrays;
int[] vs = new int[2];
vs[0] = 0;
vs[1] = 0;
vs.Dump();
```

- Custom Dictionaries with class doesnot work
```c#

Model m = new();
m.Name = "Pritom";
Dictionary<Model, string> keyValuePairs = new();
keyValuePairs.Add(m, "Purkayasta");
keyValuePairs.Dump();

┌───────┬────────────┐
│ Key   │ Value      │
├───────┼────────────┤
│ Model │ Purkayasta │
└───────┴────────────┘
```