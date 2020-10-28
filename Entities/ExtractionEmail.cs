using System.Text;
using System.Text.RegularExpressions;

namespace CisonExtractionEmail
{
    /// <summary>
    /// Represents a static class for manipulation/extraction of text string
    /// </summary>

    public static class ExtractionEmail
    {
        /// <summary>
        /// Returns a text string, with e-mail occurrences found in the text
        /// </summary>
        /// <param name="text">Text for extracting emails</param>
        /// <param name="keySensitive">Consider find KeySensitive</param>
        /// <returns></returns>
        public static string Extract(this string text, bool keySensitive = false)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                    return string.Empty;
                    
                return Results(PatternExtractionEmailRegex.ExtractEmailString(text, keySensitive));
            }
            catch (System.Exception e)
            {
                return "#error: " + e.Message;
            }
        }
        private static string Results(string[] results)
        {
            try{
                StringBuilder stringBuilder = new StringBuilder();

                foreach(string result in results)
                {
                    if (stringBuilder.Length > 2)
                        stringBuilder.Append(",");
                    stringBuilder.Append(result);
                }

                return stringBuilder.ToString();

            }catch(System.Exception e){
                return "#error " + e.Message;
            }
        }
    }
}