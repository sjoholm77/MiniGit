using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGit.Domain;
using Moq;
using Xunit;

namespace MiniGit.UnitTests
{
    public class CommiterTests
    {
        [Fact]
        public void Commiting_Stream_Generates_Correct_File_Structure()
        {
            var generator = new Sha1Generator();
            var mockedFileSystemHandler = new Mock<IFileSystemHandler>();
            var hash = generator.GenerateHash(new MemoryStream(Encoding.UTF8.GetBytes("Apple pie")));
            var sut = new Commiter(mockedFileSystemHandler.Object);
            sut.Commit(new MemoryStream(Encoding.UTF8.GetBytes("Apple pie")));
            mockedFileSystemHandler.Verify(x => x.CreateDirectory(hash.Substring(0, 2)));
        }
    }
}
