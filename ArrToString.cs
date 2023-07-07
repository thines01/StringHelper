using System.Collections.Generic;
using System.Linq;

namespace StringHelper
{
   public static partial class CStringHelper
   {
      /// <summary>
      /// Joins a collection of string by a delimiter into one string.
      /// </summary>
      /// <param name="arr">The original collection</param>
      /// <param name="strDelim">Delimiter to separate strings.  "\r\n" is default.</param>
      /// <returns></returns>
      public static string ArrToString(this IEnumerable<string> arr, string strDelim = "\r\n")
      {
         return string.Join(strDelim, arr.ToArray());
      }
   }
}