using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBackgroundChanger
{
    class Program
    {
        private const string ImagesFolder = "Images";

        static void Main(string[] args)
        {
            var fileName = GetRandomFileName(); 
            WallpaperChanger.Set(fileName, WallpaperChanger.Style.Centered);
        }

        private static string GetRandomFileName()
        {
            var files = Directory.GetFiles(ImagesFolder);
            var fileCount = files.Length;
            var random = new Random();
            var randomIndex = random.Next(0, fileCount - 1);
            var randomFile = files.ElementAt(randomIndex);
            var fileName = randomFile.Split('\\').Last();
            return fileName;
        }
    }
}
