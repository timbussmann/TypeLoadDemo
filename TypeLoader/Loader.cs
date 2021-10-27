using System;

namespace TypeLoader
{
    public class Loader
    {
        public static Type GetDemoClass() => 
            Type.GetType("AssemblyToLoad.DemoClass, AssemblyToLoad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
    }
}
