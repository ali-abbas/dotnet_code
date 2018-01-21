using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    
    public class AnonymousMethods
    {
        public static bool FindEmployee(Employee emp)
        {
            return emp.ID == 102; // will return true or false
        }
    }
}
