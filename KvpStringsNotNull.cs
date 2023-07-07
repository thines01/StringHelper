using System.Collections.Generic;

namespace StringHelper
{
   public static partial class CStringHelper
   {
      public static bool KvpStringsNotNull(KeyValuePair<string, string> kvp) =>
            (!string.IsNullOrEmpty(kvp.Key) || !string.IsNullOrEmpty(kvp.Value));
   }
}