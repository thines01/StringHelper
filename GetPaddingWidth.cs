using System;
using System.Collections.Generic;
using System.Linq;

namespace StringHelper
{
   public static partial class CStringHelper
   {
      /// <summary>
      /// Returns the number of places of the DEPTH of a collection.
      /// </summary>
      public static Func<IEnumerable<string>, int> GetPaddingWidth = (arr) => arr.Count().ToString().Length;
   }
}