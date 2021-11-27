
namespace Dumpper.PrimitiveTypes
{
    /// <summary>
    /// Author: Pritom Purkayasta
    /// <para>Dumpping string types to the console</para>
    /// </summary>
    public static class StringType
    {
        public static void Dumpper(this string strVal)
        {

        }

        public static void Dumpper(this string[] strArrayVal)
        {

        }

        public static void Dumpper(this IEnumerable<string> strings)
        {

        }

        public static void Dumpper(this List<string> strings)
        {

        }

        public static void Dumpper<T>(this Dictionary<string, T> stringDictonary) where T : struct
        {

        }
    }
}
