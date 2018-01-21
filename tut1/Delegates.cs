using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
  public  delegate double MathActio(double num);
    public delegate void HelloFunctionDelegate(string message);
    
    public class Delegates
    {
       public static double Double(double input)
        {
            return input * 2;
        } 


        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
