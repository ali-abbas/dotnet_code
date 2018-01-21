using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public static class StringHelper
    {
        /// <summary>
        /// Class extension
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>


        public static string ChanegFirstLetterCase(this string inputString)
        {

            if(inputString.Length > 0)
            {

                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);


            }

            return inputString;
        }



    }
}
