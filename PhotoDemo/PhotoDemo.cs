using System;
using static System.Console;
using System.Globalization;

namespace PhotoDemo
{
    class PhotoDemo
    {
        static void Main(string[] args)
        {
            Photo photo1 = new Photo();
            photo1.Width = 8;
            photo1.Height = 10;

            Console.WriteLine(photo1.ToString());

            MattedPhoto mphoto1 = new MattedPhoto();
            mphoto1.Width = 10;
            mphoto1.Height = 12;
            mphoto1.Color = "Blue";
            Console.WriteLine(mphoto1.ToString());

            FramedPhoto fphoto = new FramedPhoto();
            fphoto.Width = 3;
            fphoto.Height = 4;
            fphoto.Style = "Modern";
            fphoto.Material = "Titanium";
            Console.WriteLine(fphoto.ToString());

        }
    }
}
