using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MiniGit.AcceptanceTests
{
    public class CommandTests
    {
        public CommandTests()
        {
            //Add error handling for app setting not existing
            var runTimeDir = ConfigurationManager.AppSettings["RuntimeDirectory"];
            if (!FileHelper.DirectoryExists(runTimeDir))
                FileHelper.CreateDirectory(runTimeDir);
            Directory.SetCurrentDirectory(runTimeDir);
        }
    
        [Fact]
        public void InitCommandCreatesCorrectFileStructure()
        {
            Assert.False(FileHelper.DirectoryExists(".mg"));
            //var initCommand = new InitCommand();
            //initCommand.Execute();
            Assert.True(FileHelper.DirectoryExists(".mg"));

        }

        [Fact]
        public void CommitCommandCreatesZipWithCorrectNameInCorrectPlaceWithCorrectContent()
        {
            
        }
    }

    internal class FileHelper
    {
        public static bool DirectoryExists(string dirPath)
        {
            return Directory.Exists(dirPath);
        }

        public static void CreateDirectory(string dirPath)
        {
            Directory.CreateDirectory(dirPath);
        }
    }
}
