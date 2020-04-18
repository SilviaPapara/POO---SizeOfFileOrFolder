using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SizeOfFileOrFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo info = new DirectoryInfo(@"D:/Poze"); // folderul dorit
            long MarDir = SOD(info, true);
            Console.WriteLine("Marimea folderului este : " + "{0:N0} Bytes", MarDir);


            Console.ReadLine();
           
        }


        static long SOD(DirectoryInfo info, bool b)
        {
            long Marime = info.EnumerateFiles().Sum(file => file.Length);

            if (b!=false)
            {
                Marime += info.EnumerateDirectories().Sum(dir => SOD(dir, true));

            }
            return Marime;
        }
    
    }

}

