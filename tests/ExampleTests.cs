using FakeItEasy;
using NUnit.Framework;
using practice.Implementation;

namespace tests
{
    public class ExampleTests
    {

        private Example _exampleInst;

        [SetUp]
        public void Setup()
        {
            _exampleInst = A.Fake<Example>(x => x.WithArgumentsForConstructor(() => new Example()));
        }

        [Test]
        public void Revert_WithNullInput_ReturnsNull()
        {
            Assert.IsNull(_exampleInst.Revert(null));
        }

        [Test]
        public void Revert_WithEmptyInput_ReturnsEmpty()
        {
            Assert.That(_exampleInst.Revert(string.Empty), Is.EqualTo(string.Empty));
        }

        [Test]
        public void Revert_WithWhitespaceInput_ReturnsWhitespace()
        {
            Assert.That(_exampleInst.Revert("   "), Is.EqualTo("   "));
        }

        [Test]
        public void Revert_WithValidInput_ReturnsReverse()
        {
            Assert.That(_exampleInst.Revert("a"), Is.EqualTo("a"));
            Assert.That(_exampleInst.Revert("ab"), Is.EqualTo("ba"));
            Assert.That(_exampleInst.Revert("abc"), Is.EqualTo("cba"));
            Assert.That(_exampleInst.Revert("aa"), Is.EqualTo("aa"));
            Assert.That(_exampleInst.Revert("aaa"), Is.EqualTo("aaa"));
        }
    }
}