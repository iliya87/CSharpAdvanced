using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main()
        {
            using (var myCake = new FileStream("../../Cake.jpg",FileMode.Open))
            {
                using (var copyCake = new FileStream("../../CopyCake.jpg",FileMode.Create))
                {
                   
                    byte[] bufferBytes = new byte[4096];
                     int read;
                    
                    while ((read = myCake.Read(bufferBytes, 0, bufferBytes.Length)) > 0)
                    {
                        copyCake.Write(bufferBytes,0,read);
                    }
                }
            }
            Console.WriteLine("It's copied");
        }
    }
}
