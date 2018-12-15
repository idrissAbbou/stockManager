using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BarcodeGeneratorClasses
{
    public class BarecodeGenerator
    {
        public Image GenerateBarcode(string barcode)
        {
            Image image;
            PrivateFontCollection pfc = LoadFontFromResourcesToFontCollection();
            Bitmap bitmap = new Bitmap(barcode.Length * 50, 120);
            using (Graphics graphic = Graphics.FromImage(bitmap))
            {
                Font font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphic.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphic.DrawString(barcode, font, black, point);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                image = bitmap;
            }
            return image;
        }

        private PrivateFontCollection LoadFontFromResourcesToFontCollection()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            byte[] fontArray = Properties.Resources.barcodeFont;
            //allocate memory for the file
            IntPtr dataPtr = Marshal.AllocCoTaskMem(fontArray.Length);
            Marshal.Copy(fontArray, 0, dataPtr, fontArray.Length);
            //pass font to the font collection
            pfc.AddMemoryFont(dataPtr, fontArray.Length);
            //free allocated memory
            Marshal.FreeCoTaskMem(dataPtr);
            return pfc;
        }
    }
}
