namespace StringHelper
{
   public static partial class CStringHelper
   {
      public static string FlipChars(this string strData, int intInterval = 2)
      {
         return CSwapChars.getFlippedChars(strData, intInterval);
      }
   }
}
