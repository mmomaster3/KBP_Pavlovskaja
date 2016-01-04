using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PCX
{
    public partial class Form1 : Form
    {
        private Image PCX_GetImageFromFile(string filename)
        {
            BinaryReader binReader = new BinaryReader(File.Open(filename, FileMode.Open, FileAccess.Read));

            int totalSize = (int)binReader.BaseStream.Length;
            // Create a new bitmap.
            byte Manufactorer = binReader.ReadByte();
            byte Version = binReader.ReadByte();
            byte Encoding = binReader.ReadByte();
            byte BPP = binReader.ReadByte();
            short xmin = binReader.ReadInt16();
            short ymin = binReader.ReadInt16();
            short xmax = binReader.ReadInt16();
            short ymax = binReader.ReadInt16();
            short hres = binReader.ReadInt16();
            short vres = binReader.ReadInt16();
            byte[] colormap = new byte[48];
            colormap = binReader.ReadBytes(48);
            byte reserved = binReader.ReadByte();
            byte NPlanes = binReader.ReadByte();
            short BPL = binReader.ReadInt16();
            short PaletteInfo = binReader.ReadInt16();
            byte[] Filter = new byte[58];
            Filter = binReader.ReadBytes(58);

            byte[] pal = new byte[256 * 3];
            binReader.BaseStream.Seek(-256 * 3 - 1, SeekOrigin.End);
            byte palExists = binReader.ReadByte();
            if (palExists == 12)
                pal = binReader.ReadBytes(256 * 3);

            binReader.BaseStream.Seek(128, SeekOrigin.Begin);

            short width = (short)(xmax - xmin + 1);
            short height = (short)(ymax - ymin + 1);

            int totalData = totalSize - 769 - 128;

            Bitmap bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
            ColorPalette bpmPalette = bmp.Palette;
            for (int i = 0; i < bpmPalette.Entries.Length; i++)
                bpmPalette.Entries[i] = Color.FromArgb(pal[i * 3 + 0], pal[i * 3 + 1], pal[i * 3 + 2]);
            bmp.Palette = bpmPalette;

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[bytes];
            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);


            int x = 0;
            int y = 0;

            byte count = 0;
            byte data = 0;

            try
            {
                while (totalData > 0)
                {
                    count = 1;
                    data = binReader.ReadByte();
                    totalData--;
                    if ((data & 192) == 192)
                    {
                        count = (byte)(data & 63);
                        data = binReader.ReadByte();
                        totalData--;
                    }
                    for (int c = 0; c < count; c++)
                    {
                        rgbValues[(y * width + x)] = data;
                        x++;
                        if (x > width - 1)
                        {
                            y++;
                            x = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            // Draw the modified image.
            // PictureBox for checking resulting image
            //pictureBox1.Image = bmp;

            return bmp;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCX_GetImageFromFile("240_320_greatuv0408_1_08.pcx");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
