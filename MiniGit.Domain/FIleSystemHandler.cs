using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
            using (FileStream compressedFile = File.Create(name))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFile, CompressionMode.Compress))
                {
                    content.CopyTo(compressionStream);
                }
            }
        }

        public Stream UnzipFile(string name)
        {
            var memoryStream = new MemoryStream();
            using (FileStream compressedFileStream = File.OpenRead(name))
            {                
                using (GZipStream decompressionStream = new GZipStream(compressedFileStream, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(memoryStream);
                }
            }
            memoryStream.Position = 0;
            return memoryStream;
        }

        public void SaveStreamToFile(string path, string filename, Stream content)
        {
            var filestream = File.OpenWrite(filename);
            content.CopyTo(filestream);
            filestream.Flush();
        }

        public Stream GetStreamFromFile(string filename)
        {
            return File.OpenRead(filename);
        }
    }
}
