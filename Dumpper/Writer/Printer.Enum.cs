// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------


namespace Dumpper.Writer
{
    internal sealed partial class Printer
    {
        // Have to evaluate any other options
        internal static bool IsItEnum<T>(Type type, T? enumInstance)
        {
            ArgumentNullException.ThrowIfNull(enumInstance);

            if (type.UnderlyingSystemType.IsEnum)
            {
                Enum.GetName(type, enumInstance)?.Dump();
                return true;
            }

            return false;
        }
    }
}