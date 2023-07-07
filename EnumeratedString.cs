using System.Collections.Generic;
using System.Linq;

namespace StringHelper
{
   public static partial class CStringHelper
   {
      /// <summary>
      /// Returns a collection of strings with numbers prefixed
      /// </summary>
      /// <param name="arr">The original collection</param>
      /// <param name="intStartNum">1=default, can be any number and will be incremented</param>
      /// <param name="blnNaturalPadding">TRUE=Number padding based on highest count.  FALSE means user-supplied value</param>
      /// <param name="intPadding">Number of places to pad if blnNatural Padding is FALSE</param>
      /// <param name="strSpacer">Delimiter to use for spacing. ": " is default</param>
      /// <returns></returns>
      public static IEnumerable<string> EnumeratedString(this IEnumerable<string> arr, int intStartNum = 1, bool blnNaturalPadding = true, int intPadding = 0, string strSpacer = ": ")
      {
         int intPaddingToUse = blnNaturalPadding ? GetPaddingWidth(arr) : intPadding;

         return
            Enumerable.Range(intStartNum, arr.Count())
               .Select((iContent, iIndex) =>
                  string.Format("{0}{1}{2}",
                     iContent.ToString("D" + intPaddingToUse), strSpacer, arr.ElementAt(iIndex)));
      }
   }
}