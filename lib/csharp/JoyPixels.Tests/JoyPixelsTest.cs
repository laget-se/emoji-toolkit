using Xunit;
using JoyPixels;

namespace JoyPixels.Tests
{
    public class JoyPixelsTest
    {
        private IClient Client = new JoyPixels.Client();

        [Fact]
        public void TestShortnameToUnicode()
        {
            var test = "Hello world! 😄 :smile:";
            var expected = "Hello world! 😄 😄";

            Assert.Equal(expected, Client.ShortnameToUnicode(test));
        }
    }
}
