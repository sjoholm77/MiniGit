using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGit.Domain
{
    public interface IFileSystemHandler
    {
        void CreateDirectory(string name);
        void CreateZippedFile(string relPath, string name, Stream content);
    }
}
