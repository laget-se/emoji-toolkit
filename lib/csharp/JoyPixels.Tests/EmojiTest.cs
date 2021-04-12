using Xunit;
using JoyPixels;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace EmojiToolkit.Tests
{
    public class EmojiTest
    {
        private IClient Client = new JoyPixels.Client();

        public static IEnumerable<object[]> Data()
        {
            using (StreamReader r = new StreamReader("emoji.json"))
            {
                string json = r.ReadToEnd();

                var emojiesByUnicode = JsonConvert.DeserializeObject<Dictionary<string, Emoji>>(json);

                return emojiesByUnicode.Select(x => new object[] { x.Value.Shortname });
            }
        }

        /**
        * test all Emojis and shortnames
        */
        [Theory]
        [MemberData(nameof(Data))]
        public void TestEmojis(string shortname)
        {
            var unicode = Client.ShortnameToUnicode(shortname);

            Assert.False(unicode == shortname);
            
            Assert.True(JoyPixels.Ruleset.ShortnameReplace.ContainsValue(unicode));
            Assert.Equal(unicode, JoyPixels.Ruleset.ShortnameReplace[shortname]);
        }
    }
}
