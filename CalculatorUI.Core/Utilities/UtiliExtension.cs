using System.Runtime.CompilerServices;

namespace CalculatorUI.Core.Utilities
{
    public static class UtiliExtension
    {
        public static double ToDouble(this string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                bool isDoubleParsed = Double.TryParse(text, out double parseOP);
                if (isDoubleParsed)
                {
                    return parseOP;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public static string ToClear(this string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return text.Remove(text.Length - 1, 1);
            }
            else { return string.Empty; }
        }

        public static string ToConvertString(this string textString)
        {
            if (!string.IsNullOrEmpty(textString))
            {
                return Convert.ToString(textString);
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
