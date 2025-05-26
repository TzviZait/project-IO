using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class Writh
    {
        public static void writhText()
        {
            string myString = GetString.Get();
            string encryptString = Encryption.Atbash(myString);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = Path.Combine(desktopPath, "test.txt");
            File.WriteAllText(filePath, encryptString);

        }
    }
}
