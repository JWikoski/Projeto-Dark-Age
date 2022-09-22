using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Age
{
    public static class byte_image
    {
        public static Image byteArrayToImage(byte[] BytepraImagem)
        {
            MemoryStream ms = new MemoryStream(BytepraImagem);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
