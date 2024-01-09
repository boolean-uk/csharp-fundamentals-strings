using csharp_fundamentals_strings.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_strings.Test
{
    public class ExtensionTests
    {
        Extension extension;

        public ExtensionTests()
        {
            this.extension = new Extension();
        }

        [Test]
        public void helloWorldShouldBeAppended()
        {
            Assert.AreEqual("Hello, world!", this.extension.one().ToString());
        }

        [Test]
        public void helloWorldShouldBeReversed()
        {
            Assert.AreEqual("!dlrow ,olleH", this.extension.two().ToString());
        }

        [Test]
        public void commaShouldBeRemoved()
        {
            Assert.AreEqual("Hello world!", this.extension.three().ToString());
        }

        [Test]
        public void shouldSayHelloToCS()
        {
            Assert.AreEqual("Hello, C#!", this.extension.four().ToString());
        }
    }
}