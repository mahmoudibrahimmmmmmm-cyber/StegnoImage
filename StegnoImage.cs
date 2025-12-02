using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace stegnographyLSB
{
    public partial class StegnoImage : Form
    {
        Bitmap bmp;
        public StegnoImage()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap original = new Bitmap(ofd.FileName);
                bmp = ConvertToPng(original);
                pictureBox1.Image = bmp;

            }
        }

        private void btnHideText_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                messages.Text = "Please Load an image first";
                return;
            }

            string text = txtMessage.Text;
            if (string.IsNullOrEmpty(text))
            {
                messages.Text = "Enter Some Text To Encode";
                return;
            }

            Bitmap encoded = new Bitmap(bmp);
            byte[] bytes = Encoding.UTF8.GetBytes(text + '\0');

            int byteIndex = 0, bitIndex = 0;
            for (int y = 0; y < encoded.Height; y++)
            {
                for (int x = 0; x < encoded.Width; x++)
                {
                    if (byteIndex >= bytes.Length)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "PNG Image|*.png";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            encoded.Save(sfd.FileName);
                            messages.Text = "Text Encoded Successfuly";
                        }
                        return;
                    }

                    Color pixel = encoded.GetPixel(x, y);
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;

                    b = (byte)((b & 0xFE) | ((bytes[byteIndex] >> bitIndex) & 1));
                    encoded.SetPixel(x, y, Color.FromArgb(r, g, b));

                    bitIndex++;
                    if (bitIndex == 8)
                    {
                        bitIndex = 0;
                        byteIndex++;
                    }
                }
            }
        }

        private void btnExtractText_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                messages.Text = "Please Load an image first";
                return;
            }
            List<byte> extractedBytes = new List<byte>();
            StringBuilder result = new StringBuilder();
            int bitCount = 0;
            byte currentByte = 0;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int lsb = pixel.B & 1;
                    currentByte |= (byte)(lsb << bitCount);
                    bitCount++;

                    if (bitCount == 8)
                    {
                        if (currentByte == 0)
                        {
                            string decoded = Encoding.UTF8.GetString(extractedBytes.ToArray());
                           // txtMessage.Text = result.ToString();
                            txtMessage.Text = decoded.ToString();
                            messages.Text = "Text Decoded Successfuly";
                            return;
                        }
                        extractedBytes.Add(currentByte);
                       // result.Append((char)currentByte);
                        currentByte = 0;
                        bitCount = 0;
                    }
                }
            }

            txtMessage.Text = result.ToString();

        }
        private Bitmap ConvertToPng(Bitmap original)
        {

            Bitmap pngCopy = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(pngCopy))
            {
                g.DrawImage(original, 0, 0, original.Width, original.Height);
            }

            return pngCopy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseSplashScreen splashScreen = new CloseSplashScreen();
            this.Hide();
            splashScreen.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StegnoImage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "StegnoImageGuide.pdf");

            
            File.WriteAllBytes(tempPath, Properties.Resources.StegnoImageGuide);
            System.Diagnostics.Process.Start(tempPath);
        }
    }
}
