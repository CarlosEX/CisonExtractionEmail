using System.Linq;
using System.Text.RegularExpressions;

namespace CisonExtractionEmail
{
    public static class PatternExtractionEmailRegex
    {
       internal static string[] ExtractEmailString(string value)
        {    
            string partternExtractEmail = "[A_Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*" + "@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})";
            MatchCollection mc = Regex.Matches(value, partternExtractEmail);
            return (from Match m in mc select m.Value).ToArray();        
        } 
    }
}