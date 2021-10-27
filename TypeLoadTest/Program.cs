using System;

namespace TypeLoadTest
{
    using System.Reflection;
    using System.Security.Principal;
    using TypeLoader;

    class Program
    {
        static void Main(string[] args)
        {
            var d1 = AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES");
            var d2 = AppContext.GetData("PLATFORM_RESOURCE_ROOTS");
            var d3 = AppContext.GetData("NATIVE_DLL_SEARCH_DIRECTORIES");
            var d4 = AppContext.GetData("APP_PATHS");

            var t = Type.GetType("AssemblyToLoad.DemoClass, AssemblyToLoad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"); // this will be null
            Console.WriteLine($"Type.GetType result: {t}");

            var t2 = Loader.GetDemoClass(); // this will be null
            Console.WriteLine($"Loader.GetDemoClass result: {t2}");

            var x = Assembly.LoadFrom("TypeLoader.dll");

            var t3 = Type.GetType("AssemblyToLoad.DemoClass, AssemblyToLoad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"); // this will be null
            Console.WriteLine($"Type.GetType result: {t3}");

            var t4 = Loader.GetDemoClass(); // this will be a type reference
            Console.WriteLine($"Loader.GetDemoClass result: {t4}");
        }
    }
}
