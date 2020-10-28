using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CisonExtractionEmail
{
    public static class PatternExtractionEmailRegex
    {
       internal static string[] ExtractEmailString(string value, bool keySensitive)
        {
            try
            {
                string typeRegex = string.Empty;

                if (keySensitive == false)
                {
                    typeRegex = "[A_Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*" + "@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})";
                }
                else
                {
                    typeRegex = "[A-Za-z0-9-\\+]+(\\.[A-Za-z0-9-]+)*" + "@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})";
                }
                string partternExtractEmail = typeRegex;

                MatchCollection mc = Regex.Matches(value, partternExtractEmail);
                return (from Match m in mc select m.Value).ToArray();
            }
            catch(Exception e)
            {
                string[] s = new string[] {string.Empty, e.Message};
                return s;
            }
        } 
    }
}