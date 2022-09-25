using System;

namespace Dumpper.Shared;

internal static class Utils
{
    internal static DumpperColor RandomColor()
    {
        var enumCount = Enum.GetNames(typeof(DumpperColor)).Length;
        var randomNumber = Random.Shared.Next(0, enumCount);
        return (DumpperColor)randomNumber;
    }
}
