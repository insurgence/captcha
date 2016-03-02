using System;
using ImageMagick;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace captcha
{
    class Program
    {
        static void Main(string[] args)
        {
            MagickImageInfo info = new MagickImageInfo(@"C:\ph.png");
            Console.WriteLine(info.Format);
            Console.WriteLine(info.Width);
            Console.WriteLine(info.Height);
            Console.WriteLine(info.ColorSpace);
            Console.WriteLine(info.Density.X);
            Console.WriteLine(info.Density.Y);
            Console.ReadLine();
        }
    }
}
