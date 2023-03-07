using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class CargarImagen
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void CargarImagenes(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Images|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();
            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }

        public byte[] imagenByte(Image img)
        {
            var converterImg = new ImageConverter();
            return (byte[])converterImg.ConvertTo(img, typeof(byte[]));
        }

        public Image ByteArrayToImage(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            return Image.FromStream(ms);
        }
    }
}