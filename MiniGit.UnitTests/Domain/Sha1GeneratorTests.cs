using System.IO;
using System.Text;
using MiniGit.Domain;
using Xunit;

namespace MiniGit.UnitTests.Domain
{
    public class Sha1GeneratorTests
    {
        private const string APPLE_PIE_HASH = "e56baa5081ec5dbc7e08c9a29dbf667992c2146a";

        [Fact]
        public void GeneratedHashForApplePieIsCorrect()
        {
            var sut = new Sha1Generator();
            var stream = new MemoryStream(Encoding.UTF8.GetBytes("Apple pie"));
            Assert.Equal(APPLE_PIE_HASH, sut.GenerateHash(stream));
        }
    }
}
