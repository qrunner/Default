using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mcs.Services.FileSystem
{
    public static class BitmapHelper
    {
        public static Bitmap CreateBitmap(this Image source, SizeF destSize, RectangleF destRect, RectangleF sourceRect)
        {
            Bitmap retval = new Bitmap((int)destSize.Width, (int)destSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            retval.SetResolution(source.HorizontalResolution, source.VerticalResolution);
            using (Graphics grPhoto = Graphics.FromImage(retval))
            {
                grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
                grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
                grPhoto.DrawImage(source, destRect, sourceRect, GraphicsUnit.Pixel);
            }

            return retval;
        }

        public static Bitmap ResizeImage(this Bitmap source, int width)
        {
            if (width == source.Width) 
                return source;         

            SizeF imageSize = new SizeF(width, (((float)width / (float)source.Width) * (float)source.Height));
            return CreateBitmap(source, imageSize, new RectangleF(Point.Empty, imageSize), new RectangleF(Point.Empty, source.Size));         
        }

        public static Bitmap ResizeImage(this Bitmap source, int width, int height, bool clip)
        {
            float W0 = source.Width;
            float H0 = source.Height;

            float Ww = width;
            float Hw = height;

            float W1, H1, X = 0, Y = 0;

            float Ri = W0 / H0;
            float Rw = Ww / Hw;

            if (!(Ri > Rw ^ clip)) // fit by heigth
            {
                H1 = Hw;
                W1 = W0 * Hw / H0;
                X = -(W1 - Ww) / 2;
            }
            else // fit by width
            {
                W1 = Ww;
                H1 = H0 * Ww / W0;
                Y = -(H1 - Hw) / 2;
            }         

            return CreateBitmap(source, new Size(width, height), new RectangleF(X, Y, W1, H1), new RectangleF(Point.Empty, source.Size));
        }
    }
}