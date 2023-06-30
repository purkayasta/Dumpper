// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

namespace Dumpper.Shared
{
    internal class ObjectProperty
    {
        public bool IsSystemDefined { get; set; }
        public string? Name { get; set; } = string.Empty;
        public object? Value { get; set; } = null;
        public List<ObjectProperty> ChildProperties { get; set; } = Enumerable.Empty<ObjectProperty>().ToList();
    }
}