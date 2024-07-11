using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace LaPosadaClient
{
    public static class ImageHelper
    {
        public static Image LoadImage(byte[] imageData)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine($"Error loading image from byte array: {ex.Message}");
#endif
                return null;
            }
        }

        public static byte[] ImageToByteArray(Image image, ImageFormat format)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, format);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting image to byte array: {ex.Message}");
                return null;
            }
        }
    }
}
