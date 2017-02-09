using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniGit.Domain;

namespace MiniGit.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Class1();
            var value = c.AStart("Apple pie");
            System.Console.WriteLine("Hash: {0}", value);
            System.Console.Read();
        }
    }
}
