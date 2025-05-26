using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class Read
    {
        public static void ReadText()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = Path.Combine(desktopPath, "test.txt");

            string content = File.ReadAllText(filePath);
            string decryptContent = Decryption.Atbash(content);
            Console.WriteLine("the decription text is: " + decryptContent);

        }
    }
}
