using System.Collections.Generic;
using System.IO;
using System;

namespace CSharpStarter.src.main.IO
{
    public class FileOp
    {
        public void readFile(string fileName) {
            
            using (TextReader reader = File.OpenText(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Do something with line
                }
            }
        }

        // Readin file using Iterators
        public IEnumerable<string> readUsingIterator(string fileName) {
            using (TextReader reader = File.OpenText(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}