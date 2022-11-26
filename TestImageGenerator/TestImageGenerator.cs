using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImageGenerator
{
    internal class TestImageGenerator
    {
        public void Generate(string dirPath, string fileName, System.Drawing.Imaging.ImageFormat imageFormat, int width, int height)
        {
            Bitmap? image = null;
            Graphics? g = null;
            Font? font = null;
            try
            {
                image = new Bitmap(width, height);
                g = Graphics.FromImage(image);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // 背景を白にする
                g.Clear(Color.White);

                // テキストを出力
                font = new Font("Arial", 24, FontStyle.Regular, GraphicsUnit.Point);

                var textRect = new Rectangle(0, 0, width, height);

                var stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                g.DrawString(fileName, font, Brushes.Black, textRect, stringFormat);

                // ファイルを保存
                image.Save(Path.Combine(dirPath, fileName), imageFormat);
            }
            finally
            {
                if (font != null) font.Dispose();
                if (g != null) g.Dispose();
                if (image != null) image.Dispose();
            }
        }
    }
}
