using csharp_fundamentals_strings.Main;
using NUnit.Framework;

namespace csharp_fundamentals_strings.Test
{
    public class CoreTests
    {
        Core _exercise;
        public CoreTests()
        {
            this._exercise = new Core();
        }

        [Test]
        public void urlShouldBeFixed()
        {
            Assert.AreEqual(" https://booLeAn.co.uk/who-we-are ", this._exercise.fixedUrl);
        }

        [Test]
        public void urlShouldBeLowerCase()
        {
            Assert.AreEqual(" https://boolean.co.uk/who-we-are ", this._exercise.lowerCasedUrl);
        }

        [Test]
        public void urlShouldBeTrimmed()
        {
            Assert.AreEqual("https://boolean.co.uk/who-we-are", this._exercise.url);
        }

        [Test]
        public void protocolShouldBeHttps()
        {
            Console.WriteLine(this._exercise.protocol);
            Assert.AreEqual("https", this._exercise.protocol);
        }

        [Test]
        public void domainShouldBeBooleanCoUk()
        {
            Assert.AreEqual("boolean.co.uk", this._exercise.domain);
        }

        [Test]
        public void lengthShouldBe32()
        {
            Assert.AreEqual(32, this._exercise.length);
        }

        [Test]
        public void faqUrlShouldBeBooleanCoUkFaq()
        {
            Assert.AreEqual("https://boolean.co.uk/faq", this._exercise.faqUrl);
        }

    }
}