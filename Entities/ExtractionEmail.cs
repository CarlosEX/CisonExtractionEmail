using System.Text;

namespace CisonExtractionEmail
{
    public static class ExtractionEmail
    {
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