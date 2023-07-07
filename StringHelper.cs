using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StringHelper
{
   public static partial class CStringHelper
   {
      public static string DigitsOnly(this string strRawData)
      { // Using Dot Net 3.5 - Extract the digits out of a string.
         //return new string(strRawData.Where(chr => Char.IsDigit(chr)).ToArray());
         return Regex.Replace(strRawData, "[^0-9]", "");
      }

      public static string NoPunct(this string strRawData)
      {  // Using Dot Net 3.5 - Extract a pure alpha-numeric string.
         //return new string(strRawData.Where(chr =>Char.IsLetterOrDigit(chr)).ToArray());
         return Regex.Replace(strRawData, "[^0-9a-zA-Z]", "");
      }

      public static string PunctToSpace(this string strRawData)
      {  // Using Dot Net 3.5 - Extract a pure alpha-numeric string.
         return Regex.Replace(strRawData, @"[^\w\s\d]", " ");
      }

      public static bool IsEmpty(this string str)
      {
         return string.IsNullOrEmpty(str);
      }

      public static List<string> ToList(this ArrayList arr_lst)
      {
         return new List<string>((string[])arr_lst.ToArray(
            Type.GetType("System.String")));
      }
   }
}
