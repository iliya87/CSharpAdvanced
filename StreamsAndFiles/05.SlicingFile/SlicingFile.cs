using System;
using System.Collections.Generic;
using System.IO;

namespace _05.SlicingFile
{
    class SlicingFile
    {
        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var source = new FileStream(sourceFile,FileMode.Open))
            {
                byte[] buffer = new byte[4096];
                var allFile = new List<byte>();
                while (true)
                {
                    int readByte = source.Read(buffer, 0, buffer.Length);
                    if (readByte == 0)
                    {
                        break;
                    }
                    for (int i = 0; i < readByte; i++)
                    {
                        allFile.Add(buffer[i]);
                    }
                }
                int partSize = allFile.Count/parts;
                int leftOver = allFile.Count - partSize*parts;
                for (int i = 0; i < parts; i++)
                {
                    var newFile = destinationDirectory + "part-" + i + ".jpg";
                    using (var copy = new FileStream(newFile,FileMode.Create))
                    {
                        if (i == parts -1 )
                        {
                            copy.Write(allFile.ToArray(),i*partSize,partSize+leftOver);
                        }
                        else
                        {
                            copy.Write(allFile.ToArray(),i*partSize,partSize);
                        }
                    }
                }
            }
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            var allFile = new List<byte>();
            for (int i = 0; i < files.Count; i++)
            {
                var sourceFile = files[i];
                using (var source = new FileStream(sourceFile,FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break; 
                        }
                        for (int j = 0; j < readBytes; j++)
                        {
                            allFile.Add(buffer[j]);
                        }
                    }
                }
            }
            using (var copy = new FileStream(destinationDirectory,FileMode.Create))
            {
                copy.Write(allFile.ToArray(),0,allFile.Count);
            }
        }

        static void Main()
        {
            string sourceFile = "../../Cake.jpg";
            string destinationDirectory = "../../";
            int parts = 5;
            Slice(sourceFile,destinationDirectory,parts);
            Assemble(new List<string>()
            {
                "../../part-0.jpg",
                "../../part-1.jpg",
                "../../part-2.jpg",
                "../../part-3.jpg",
                "../../part-4.jpg",
            }, "../../Constructed.jpg");
            Console.WriteLine("It's Sliced");
        }
    }
}
