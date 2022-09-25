// ---------------------------------------------------------------
// Copyright (c) Pritom Purkayasta All rights reserved.
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Spectre.Console;

namespace Dumpper.Shared;

internal static class DumpperColorExtension
{
    internal static Color ToColor(this DumpperColor color)
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
            DumpperColor.Aqua => Color.Aqua,
            DumpperColor.DeepSkyBlue1 => Color.DeepSkyBlue1,
            DumpperColor.RoyalBlue1 => Color.RoyalBlue1,
            DumpperColor.Teal => Color.Teal,
            DumpperColor.Purple => Color.Purple,
            DumpperColor.White => Color.White,
            DumpperColor.Lime => Color.Lime,
            _ => Color.LightCoral
        };
    }

    internal static string ToText(this DumpperColor color)
    {
        return color switch
        {
            DumpperColor.Maroon => "maroon",
            DumpperColor.Green => "green1",
            DumpperColor.LightGreen => "lightgreen_1",
            DumpperColor.Cyan => "cyan1",
            DumpperColor.Navy => "navy",
            DumpperColor.Olive => "olive",
            DumpperColor.Red => "red1",
            DumpperColor.DarkRed => "darkred_1",
            DumpperColor.Aqua => "aqua",
            DumpperColor.DeepSkyBlue1 => "deepskyblue1",
            DumpperColor.RoyalBlue1 => "royalblue1",
            DumpperColor.Teal => "teal",
            DumpperColor.Purple => "purple",
            DumpperColor.White => "white",
            DumpperColor.Lime => "lime",
            _ => "lightcoral"
        };
    }
}