using ConsoleApp1.Extensions;

namespace ConsoleApp1.Tests.Extensions
{
    public class IntExtensionsTests
    {
        [Test]
        [TestCase(0, "0b")]
        [TestCase(1, "1b")]
        [TestCase(2, "01b")]
        [TestCase(3, "11b")]
        [TestCase(150, "01101001b")]
        public void AsBinaryStringSuccess(int input, string expected) => 
            Assert.That(input.AsBinaryString(), Is.EqualTo(expected));

        [Test]
        public void AsBinaryStringException() => 
            Assert.Throws<ArgumentOutOfRangeException>(() => (-2).AsBinaryString());
    }
}