using System.Text.RegularExpressions;

namespace StringHelper
{
   public static partial class CStringHelper
   {
      /// <summary>
      /// Within a specified input string, replaces all strings that match a specified regular expression with a string returned by a MatchEvaluator delegate.
      /// </summary>
      /// <param name="input">this string</param>
      /// <param name="pattern">The regex pattern to search for a match.</param>
      /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
      /// <returns>A new string that is identical to the input string, except that a replacement string takes the place of each matched string.</returns>
      public static string Replace(this string input, Regex pattern, MatchEvaluator evaluator)
      {
         return Regex.Replace(input, pattern.ToString(), evaluator);
      }

      /// <summary>
      /// Within a specified input string, replaces all strings that match a regular expression pattern with a specified replacement string.
      /// </summary>
      /// <param name="input">this string</param>
      /// <param name="pattern">The regex pattern to search for a match.</param>
      /// <param name="replacement">The replacement string.</param>
      /// <returns>A new string that is identical to the input string, except that a replacement string takes the place of each matched string.</returns>
      public static string Replace(this string input, Regex pattern, string replacement)
      {
         return Regex.Replace(input, pattern.ToString(), replacement);
      }

      /// <summary>
      /// Within a specified input string, replaces all strings that match a specified regular expression with a string returned by a MatchEvaluator delegate. Specified options modify the matching operation.
      /// </summary>
      /// <param name="input">this string</param>
      /// <param name="pattern">The regex pattern to search for a match.</param>
      /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
      /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
      /// <returns>A new string that is identical to the input string, except that a replacement string takes the place of each matched string. Specified options modify the matching operation.</returns>
      public static string Replace(this string input, Regex pattern, MatchEvaluator evaluator, RegexOptions options)
      {
         return Regex.Replace(input, pattern.ToString(), evaluator, options);
      }

      /// <summary>
      /// Within a specified input string, replaces all strings that match a specified regular expression with a specified replacement string. Specified options modify the matching operation.
      /// </summary>
      /// <param name="input">this string</param>
      /// <param name="pattern">The regex pattern to search for a match.</param>
      /// <param name="replacement">The replacement string.</param>
      /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
      /// <returns>A new string that is identical to the input string, except that a replacement string takes the place of each matched string. Specified options modify the matching operation.</returns>
      public static string Replace(this string input, Regex pattern, string replacement, RegexOptions options)
      {
         return Regex.Replace(input, pattern.ToString(), replacement, options);
      }

      /// <summary>
      /// Within a specified input string, replaces all strings that match a specified regular expression with a string returned by a MatchEvaluator delegate.
      /// </summary>
      /// <param name="input">this string</param>
      /// <param name="pattern">The regular expression pattern to match.</param>
      /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
      /// <returns>A new string that is identical to the input string, except that a replacement string takes the place of each matched string.</returns>
      public static string Replace(this string input, string pattern, MatchEvaluator evaluator)
      {
         return Regex.Replace(input, pattern, evaluator);
      }
   }
}