using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGit.Domain
{
    public class FileSystemHandler : IFileSystemHandler
    {
        public void CreateDirectory(string name)
        {
            if (!Directory.Exists(name))
                Directory.CreateDirectory(name);
        }

        public void CreateZippedFile(string relPath, string name, Stream content)
        {
            throw new NotImplementedException();
        }
    }
}
