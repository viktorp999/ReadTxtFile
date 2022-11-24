using NUnit.Framework;
using Moq;
using ReadTxtFile.Core;

namespace ReadTxtFile.UnitTests
{
    [TestFixture]
    public class MainTests
    {
        private Mock<IReadFile> _readfile;
        private Main _main;
        private string[] _text;

        [Test]
        public void ReadTxt_OnCall_ReturnArrayOsString()
        {
            _readfile = new Mock<IReadFile>();
            _main = new Main(_readfile.Object);
            _text = new string[3] 
            {
                "A",
                "B",
                "C" 
            };

            _readfile.Setup(rf => rf.Read("Text.txt")).Returns(new string[3] 
            { 
                "A", 
                "B", 
                "C" 
            });

            var result = _main.ReadTxt();

            Assert.That(result, Is.EqualTo(_text));
        }
    }
}
