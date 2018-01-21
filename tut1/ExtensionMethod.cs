using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    /// <summary>
    /// You can use extension methods to extend a class or interface, but not to override them
    /// </summary>
    public static class Extensions
    {
        public static void MethodA(this IMyInterface myInterface,int i)
        {
            Console.WriteLine("Extension.Method(this is IMyInterface myInterface,int i");
        }


        public static void MethodA(this IMyInterface myInterface,string s)
        {
            Console.WriteLine("Extension,Method(this IMyInterface myInterface,string s");
        }

        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine("Extension.MethodB(this IMyInterface myInterface");
        }

        
    }



    public interface IMyInterface
    {
        void MethodB();
    }
   
}
