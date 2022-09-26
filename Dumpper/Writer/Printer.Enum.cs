using System.Reflection;

namespace Dumpper.Writer;

internal sealed partial class Printer
{
    // Have to evaluate any other options
    internal static bool IsItEnum<T>(Type type, T enumInstance)
    {
        if (type.UnderlyingSystemType.IsEnum)
        {
            Console.WriteLine(Enum.GetName(type, enumInstance));
            return true;
        }

        return false;
    }
}