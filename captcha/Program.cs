using System;
using ImageMagick;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace captcha
{
    class Program
    {
        static void Main(string[] args)
        {
            MagickImageInfo info = new MagickImageInfo(@"C:\DSC_6919v16.jpg");
            Console.WriteLine(info.Format);
            Console.WriteLine(info.Width);
            Console.WriteLine(info.Height);
            Console.WriteLine(info.ColorSpace);
            Console.WriteLine(info.Density.X);
            Console.WriteLine(info.Density.Y);

            Console.WriteLine("Read Exif Data: ");
            using (MagickImage image = new MagickImage(@"C:\DSC_6919v16.jpg"))
            {
                ExifProfile profile = image.GetExifProfile();

                if (profile == null)
                    Console.WriteLine("Image does not contain exif information");
                else
                {
                    foreach(ExifValue value in profile.Values)
                    {
                        Console.WriteLine("{0}({1}) : {2}", value.Tag, value.DataType, value.ToString());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
