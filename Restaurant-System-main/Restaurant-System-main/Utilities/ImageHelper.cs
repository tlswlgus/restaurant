using System.Drawing;
using System.IO;


namespace RestaurantSystem.Utilities
{
    internal class ImageHelper
    {
        public static Image ByteArrayToImage(byte[] imageData)
        {
            if (imageData == null) return null;
            using (var ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
