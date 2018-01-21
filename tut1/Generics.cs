using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public static class Stack
    {
     
       public static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
