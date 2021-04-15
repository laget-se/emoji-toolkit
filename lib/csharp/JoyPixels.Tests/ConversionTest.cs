using Xunit;

namespace JoyPixels.Tests
{
    public class ConversionTest
    {
        private string EmojiVersion = "6.5";

        private IClient Client = new JoyPixels.Client();

        /**
        * test single unicode character
        */
        [Fact]
        public void TestSingleUnicodeCharacter()
        {
            var unicode = "🐌";
            var shortname = ":snail:";

            Assert.Equal(unicode, Client.ShortnameToUnicode(shortname));
        }

        /**
        * test shortname mid sentence
        */
        [Fact]
        public void TestShortnameInsideSentence()
        {
            var unicode = "The 🦄 was EmojiOne's official mascot.";
            var shortname = "The :unicorn: was EmojiOne's official mascot.";

            Assert.Equal(unicode, Client.ShortnameToUnicode(shortname));
        }

        /**
        * test shortname mid sentence with a comma
        */
        [Fact]
        public void TestShortnameInsideSentenceWithComma()
        {
            var unicode = "The 🦄, was EmojiOne's official mascot.";
            var shortname = "The :unicorn:, was EmojiOne's official mascot.";

            Assert.Equal(unicode, Client.ShortnameToUnicode(shortname));
        }

        /**
        * test shortname at start of sentence
        */
        [Fact]
        public void TestShortnameAtStartOfSentence()
        {
            var unicode = "🐌 mail.";
            var shortname = ":snail: mail.";

            Assert.Equal(unicode, Client.ShortnameToUnicode(shortname));
        }

        /**
        * test shortname at start of sentence with apostrophe
        */
        [Fact]
        public void TestShortnameAtStartOfSentenceWithApostrophe()
        {
            var unicode = "🐌's are cool!";
            var shortname = ":snail:'s are cool!";

            Assert.Equal(unicode, Client.ShortnameToUnicode(shortname));
        }

        /**
        * test shortname at end of sentence
        */
        [Fact]
        public void TestShortnameAtEndOfSentence()
        {
            var unicode = "EmojiOne's official mascot was 🦄.";
            var shortname = "EmojiOne's official mascot was :unicorn:.";

            Assert.Equal(unicode, Client.ShortnameToUnicode(shortname));
        }

        /**
        * test shortname at end of sentence with alternate punctuation
        */
        [Fact]
        public void TestShortnameAtEndOfSentenceWithAlternatePunctuation()
        {
            var unicode = "EmojiOne's official mascot was 🦄!";
            var shortname = "EmojiOne's official mascot was :unicorn:!";

            Assert.Equal(unicode, Client.ShortnameToUnicode(shortname));
        }

        /**
        * test shortname at end of sentence with preceeding colon
        */
        [Fact]
        public void TestShortnameAtEndOfSentenceWithPreceedingColon()
        {
            var unicode = "EmojiOne's official mascot was: 🦄";
            var shortname = "EmojiOne's official mascot was: :unicorn:";

            Assert.Equal(unicode, Client.ShortnameToUnicode(shortname));
        }

        /**
        * shortname inside of IMG tag
        */
        [Fact]
        public void TestShortnameInsideOfImgTag()
        {
            var unicode = $"The <img class=\"joypixels\" alt=\"🦄\" title=\":unicorn:\" src=\"https://cdn.jsdelivr.net/joypixels/assets/{EmojiVersion}/png/32/1f984.png\" /> was EmojiOne's official mascot.";
            var shortname = $"The <img class=\"joypixels\" alt=\":unicorn:\" title=\":unicorn:\" src=\"https://cdn.jsdelivr.net/joypixels/assets/{EmojiVersion}/png/32/1f984.png\" /> was EmojiOne's official mascot.";

            Assert.Equal(shortname, Client.ShortnameToUnicode(shortname));
        }
    }
}
