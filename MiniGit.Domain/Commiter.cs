using System.IO;

namespace MiniGit.Domain
{
    public class Commiter
    {
        private readonly IFileSystemHandler _fileSystemHandler;

        public Commiter(IFileSystemHandler fileSystemHandler)
        {
            _fileSystemHandler = fileSystemHandler;
        }

        public void Commit(MemoryStream memoryStream)
        {
            var sha1Generator = new Sha1Generator();
            var hash = sha1Generator.GenerateHash(memoryStream);
            _fileSystemHandler.CreateDirectory(hash.Substring(0, 2));
        }
    }
}