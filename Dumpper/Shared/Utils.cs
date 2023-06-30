// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using System.Reflection;
namespace Dumpper.Shared
{
    internal class Utils
    {
        internal static DumpperColor RandomColor()
        {
            var enumCount = Enum.GetNames(typeof(DumpperColor)).Length;
            var randomNumber = Random.Shared.Next(0, enumCount);
            return (DumpperColor)randomNumber;
        }
    }
}