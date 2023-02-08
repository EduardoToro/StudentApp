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
    }
}