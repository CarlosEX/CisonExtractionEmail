using System.Text;

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
        /// <param name="ignoreCase">Consider find KeySensitive</param>
        /// <returns>string (email1,email2,email3...)</returns>
        public static string Extract(this string text, bool ignoreCase = false)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                    return string.Empty;
                    
                return Results(PatternExtractionEmailRegex.ExtractEmailString(text, ignoreCase));
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