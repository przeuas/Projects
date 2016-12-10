#define DEBUG
#undef TRACE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    public class TestDefine
    {
        public static void Main(string[] args)
        {
#if(DEBUG)
            Console.WriteLine("debugowanie rozpoczete");
#endif

#if (TRACE)
            Console.WriteLine("tracking wlaczony");
#endif
        }
    }
#if (DEBUG)
#pragma warning disable 169
    public class MyClass
    {
        int poleTestowe;
    }
#pragma warning restore 169
#endif

  
}