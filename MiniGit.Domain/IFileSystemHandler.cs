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
        Stream UnzipFile(string name);
        void SaveStreamToFile(string path, string filename, Stream content);
        Stream GetStreamFromFile(string filename);
    }
}
