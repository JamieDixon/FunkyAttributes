namespace FuncAttributes
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PartialCaller(CachedMethod);
        }

        public static void PartialCaller(Func<string, string> func)
        {
            var isAttrDefined = func.Method.IsDefined(typeof (CustomAttribute), false);

            Console.Write("Does our method have the right attribute: {0}", isAttrDefined);

            Console.ReadLine();
        }

        [Custom]
        public static string CachedMethod(string args)
        {
            return "Chicken dippers";
        }
    }

    public class CustomAttribute : Attribute
    {
        
    }
}