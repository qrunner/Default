using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Web;

namespace Mcs.Services.FileSystem
{
    public class PictureService : IPictureService
    {
        private string _imagesBaseDirectory = "~/content/images/base/";
        private string _imageNameFormat = "{0}/{1}.png";            // {prefix}/{id}.{ext}
        private string _imageNotFound = "noimage.png";
        private string _imageNameFormatW = "{0}/{1}-{2}.png";        // {prefix}/{id}-{width}.{ext}
        private string _imageNameFormatWH = "{0}/{1}-{2}x{3}.png";    // {prefix}/{id}-{width}x{heigth}.{ext}
        private string _imageNameFormatWHNoClip = "{0}/{1}~{2}x{3}.png";    // {prefix}/{id}~{noclipsizeW}x{noclipsizeH}.{ext}
        private string _imageDeleteFormat = "{0}*.png";               // {id}*.{ext}

        public string GetImagePath(string prefix, int id)
        {
            string imagepath = _imagesBaseDirectory + string.Format(_imageNameFormat, prefix, id);
            string filename = HttpContext.Current.Server.MapPath(imagepath);
            if (File.Exists(filename))
                return imagepath;
            else
                return _imagesBaseDirectory + _imageNotFound;
        }

        public string GetImagePathFitWidth(string prefix, int id, int width)
        {
            string imagepath = _imagesBaseDirectory + string.Format(_imageNameFormatW, prefix, id, width);
            string filenameW = HttpContext.Current.Server.MapPath(imagepath);
            if (File.Exists(filenameW))
                return imagepath;
            else
            {
                string filename = HttpContext.Current.Server.MapPath(_imagesBaseDirectory + string.Format(_imageNameFormat, prefix, id));
                if (File.Exists(filename))
                {
                    Bitmap img = new Bitmap(filename).ResizeImage(width);
                    img.Save(filenameW);
                    return imagepath;
                }
                else
                    return _imagesBaseDirectory + _imageNotFound;
            }
        }

        public string GetImagePath(string prefix, int id, int width, int height)
        {
            return GetImagePath(prefix, id, width, height, true);
        }

        public string GetImagePathFit(string prefix, int id, int size)
        {
            return GetImagePath(prefix, id, size, size, false);
        }

        public string GetImagePath(string prefix, int id, int width, int height, bool clip)
        {
            string imagepath = _imagesBaseDirectory + string.Format(clip ? _imageNameFormatWH : _imageNameFormatWHNoClip, prefix, id, width, height);
            string filenameWH = HttpContext.Current.Server.MapPath(imagepath);
            if (File.Exists(filenameWH))
                return imagepath;
            else
            {
                string filename = HttpContext.Current.Server.MapPath(_imagesBaseDirectory + string.Format(_imageNameFormat, prefix, id));
                if (File.Exists(filename))
                {
                    Bitmap img = new Bitmap(filename).ResizeImage(width, height, clip); // resize code here
                    img.Save(filenameWH);
                    return imagepath;
                }
                else
                    return _imagesBaseDirectory + _imageNotFound;
            }
        }

        public void SetPicture(string prefix, int id, Image image)
        {
            string imagepath = _imagesBaseDirectory + string.Format(_imageNameFormat, prefix, id);
            string filename = HttpContext.Current.Server.MapPath(imagepath);

            DeletePicture(prefix, id);

            Directory.CreateDirectory(Path.GetDirectoryName(filename));

            if (image.PixelFormat != System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            {
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                using (Bitmap dest = image.CreateBitmap(image.Size, rect, rect))
                {
                    dest.Save(filename);
                }
            }
            else image.Save(filename);            
        }

        public void DeletePicture(string prefix, int id)
        {
            string dir = HttpContext.Current.Server.MapPath(_imagesBaseDirectory + "/" + prefix + "/");
            if (Directory.Exists(dir))
            {
                foreach (string file in Directory.GetFiles(dir, string.Format(_imageDeleteFormat, id)))
                {
                    FileInfo myfileinf = new FileInfo(file);
                    myfileinf.Delete();
                 //   File.Delete(file);
                }
            }
        }
    }
}