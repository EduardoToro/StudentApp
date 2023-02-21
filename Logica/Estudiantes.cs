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
        public Estudiantes(List<TextBox> listaTextBox, List<Label> listaLabel)
        {
            this.listaTextBox = listaTextBox;
            this.listaLabel = listaLabel;
        }

        public void Registrar()
        {
            if (listaTextBox[0].Text.Equals(""))
            {
                listaLabel[0].Text = "El campo ID es requerido.";
                listaLabel[0].ForeColor = Color.Red;
                listaTextBox[0].Focus();
            }
            else
            {
                if (listaTextBox[1].Text.Equals(""))
                {
                    listaLabel[1].Text = "El campo NOMBRE es requerido.";
                    listaLabel[1].ForeColor = Color.Red;
                    listaTextBox[1].Focus();
                }
                else
                {
                    if (listaTextBox[2].Text.Equals(""))
                    {
                        listaLabel[2].Text = "El campo APELLIDO es requerido.";
                        listaLabel[2].ForeColor = Color.Red;
                        listaTextBox[2].Focus();
                    }
                    else
                    {
                        if (listaTextBox[3].Text.Equals(""))
                        {
                            listaLabel[3].Text = "El campo EMAIL es requerido.";
                            listaLabel[3].ForeColor = Color.Red;
                            listaTextBox[3].Focus();
                        }
                        else
                        {
                
                        }
                    }
                }
            }
        }
    }
}