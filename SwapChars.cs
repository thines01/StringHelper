using System;
using System.Linq;

namespace StringHelper
{
   public static class CSwapChars
   {
      private static Func<int, int, int> getBoundaryLen = (intLength, intIntvl) => (intLength / intIntvl) + ((0 == (intLength % intIntvl)) ? 0 : 1);
      public static Func<string, int, string> getFlippedChars = (strData, intInterval) =>
      string.Join("", Enumerable.Range(0, getBoundaryLen(strData.Length, intInterval))
             .Select(i => new string(strData.Skip(i * intInterval).Take(intInterval).Reverse().ToArray()))
            .ToArray());
   }
}
