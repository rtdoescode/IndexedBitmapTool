using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IndexedBitmapTool {
    static class FormatFunctions {

        public static Bitmap GenericConvert(Bitmap img, PixelFormat pf) {
            return img.Clone(new Rectangle(0, 0, img.Width, img.Height), pf);
        }

        public static Bitmap Convert4bitIndexed(Bitmap img) {
            return GenericConvert(img, PixelFormat.Format4bppIndexed);
        }

        public static Bitmap Convert8bitIndexed(Bitmap img) {
            return GenericConvert(img, PixelFormat.Format8bppIndexed);
        }

        public static Bitmap Convert24bitIndexed(Bitmap img) {
            return GenericConvert(img, PixelFormat.Format24bppRgb);
        }

        public static Bitmap Convert32bitIndexed(Bitmap img) {
            return GenericConvert(img, PixelFormat.Format32bppArgb);
        }

        public static Bitmap Convert8bitGrayscale(Bitmap img) {

            Bitmap newbmp = new Bitmap(img.Width, img.Height, PixelFormat.Format8bppIndexed);

            ColorPalette pal = newbmp.Palette;
            for (int i = 0; i < 256; i++) {
                pal.Entries[i] = Color.FromArgb(i, i, i);
            }

            newbmp.Palette = pal;
            Color px;
            int v;

            BitmapData data = newbmp.LockBits(new Rectangle(0, 0, newbmp.Width, newbmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            byte[] bytes = new byte[data.Height * data.Stride];
            Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);

            for (int y = 0; y < newbmp.Height; y++) {
                for (int x = 0; x < newbmp.Width; x++) {
                    px = img.GetPixel(x, y);
                    v = (px.R+px.G+px.B) / 3;
                    bytes[y * data.Stride + x] = (byte)v;
                }
            }

            // Copy the bytes from the byte array into the image
            Marshal.Copy(bytes, 0, data.Scan0, bytes.Length);
            newbmp.UnlockBits(data);
            return newbmp;
        }

    }
}
