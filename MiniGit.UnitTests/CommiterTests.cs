using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGit.Domain;
using Xunit;

namespace MiniGit.UnitTests
{
    public class CommiterTests
    {
        [Fact]
        public void Commiting_Stream_Generates_Correct_File_Structure()
        {
            var generator = new Sha1Generator();
            var hash = generator.GenerateHash(new MemoryStream(Encoding.UTF8.GetBytes("Apple pie")));
            var runtimeDir = Directory.GetCurrentDirectory();
            Assert.False(Directory.Exists(@"e5"));
        }
    }
}
