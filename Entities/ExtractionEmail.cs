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
        /// <param name="texto">Text for extracting emails</param>
        /// <returns></returns>
        public static string Extract(this string texto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(texto))
                    return string.Empty;
                    
                return Results(PatternExtractionEmailRegex.ExtractEmailString(texto));
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