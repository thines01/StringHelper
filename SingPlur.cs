using System;
using System.Collections.Generic;

namespace StringHelper
{
   public static partial class CStringHelper
   {
      public static Func<int, string, string, string>
         singPlur = (i, sYes, sNo) => (i.Equals(1) ? sYes : sNo);

      public static string SingPlur(this int i, string sYes, string sNo)
      {
         return singPlur(i, sYes, sNo);
      }

      public static string SingPlur(this int i, KeyValuePair<string, string> kvp_s2sYesNo)
      {
         return singPlur(i, kvp_s2sYesNo.Key, kvp_s2sYesNo.Value);
      }

      public static string SingPlur(this int i, string[] arr_strYesNo)
      {
         return singPlur(i, arr_strYesNo[0], arr_strYesNo[1]);
      }
   }
}