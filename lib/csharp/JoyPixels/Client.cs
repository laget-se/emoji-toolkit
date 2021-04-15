using System.Text.RegularExpressions;

namespace JoyPixels
{
    public interface IClient
    {
      string ShortnameToUnicode(string text);
    }

    public class Client : IClient
    {
      public string ignoredRegexp = @"<object[^>]*>.*?<\/object>|<span[^>]*>.*?<\/span>|<(?:object|embed|svg|img|div|span|p|a)[^>]*>";
      public string shortnameRegexp = ":([-+\\w]+):";

      public string ShortnameToUnicode(string text)
      {
        return Regex.Replace(text, $"{ignoredRegexp}|({shortnameRegexp})", match => {
            if (!Ruleset.ShortnameReplace.ContainsKey(match.Value)) {
                return match.Value;
            }

            return Ruleset.ShortnameReplace[match.Value];
        }, RegexOptions.IgnoreCase);
      }
    }
}
