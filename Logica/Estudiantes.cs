using System.Collections.Generic;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using Logica.Libreria;

namespace Logica
{
    public class Estudiantes : Librerias
    {
        private List<TextBox> listaTextBox;
        private List<Label> listaLabel;
        private PictureBox image;
        public Estudiantes(List<TextBox> listaTextBox, List<Label> listaLabel, object[] objetos)
        {
            this.listaTextBox = listaTextBox;
            this.listaLabel = listaLabel;
            image = (PictureBox)objetos[0];
        }

        public void Registrar()
        {
            if (listaTextBox[0].Text.Equals(""))
            {
                listaLabel[0].Text = "El campo es requerido.";
                listaLabel[0].ForeColor = Color.Red;
                listaTextBox[0].Focus();
            }
            else
            {
                if (listaTextBox[1].Text.Equals(""))
                {
                    listaLabel[1].Text = "El campo es requerido.";
                    listaLabel[1].ForeColor = Color.Red;
                    listaTextBox[1].Focus();
                }
                else
                {
                    if (listaTextBox[2].Text.Equals(""))
                    {
                        listaLabel[2].Text = "El campo es requerido.";
                        listaLabel[2].ForeColor = Color.Red;
                        listaTextBox[2].Focus();
                    }
                    else
                    {
                        if (listaTextBox[3].Text.Equals(""))
                        {
                            listaLabel[3].Text = "El campo es requerido.";
                            listaLabel[3].ForeColor = Color.Red;
                            listaTextBox[3].Focus();
                        }
                        else
                        {
                            if (eventoTextBox.ComprobarFormatoEmail(listaTextBox[3].Text))
                            {
                                var imageArray = cargarImagen.imagenByte(image.Image);
                            }
                            else
                            {
                                listaLabel[3].Text = "EMAIL no valido.";
                                listaLabel[3].ForeColor = Color.Red;
                                listaTextBox[3].Focus();
                            }
                        }
                    }
                }
            }
        }
    }
}