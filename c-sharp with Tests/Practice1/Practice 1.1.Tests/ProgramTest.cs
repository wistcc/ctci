using NUnit.Framework;

namespace Practice_1._1.Tests
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void StringIsUniqueShouldReturnTrue()
        {
            Assert.IsTrue(Program.StringIsUnique("abcdefg"));
        }
        [Test]
        public void StringIsUniqueShouldReturnFalse()
        {
            Assert.IsFalse(Program.StringIsUnique("abcdcefgc"));
        }
    }
}