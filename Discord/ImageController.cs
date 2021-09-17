using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;

namespace Discord
{
    class ImageController
    {
        public ImageController(byte[] image)
        {
           byteArrayToImage(image);
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms, true);
            return returnImage;
        }
    }
}
