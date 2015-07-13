using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStatement //Create Bitmap
{
    class Program 
    {
        static void Main(string[] args)
        {
            using (Bitmap bitmap = new Bitmap(500, 500))
            {
            var x = new Random();
            for (var i = 0; i < 1000; i++)
                {
                    bitmap.SetPixel(x.Next(500), x.Next(500), Color.Red);
                }
            var currentDirectory = Environment.CurrentDirectory;
            var path = Path.Combine(currentDirectory, "MyImage.png");
            bitmap.Save(path, ImageFormat.Png);
            }
        }
    }
}
