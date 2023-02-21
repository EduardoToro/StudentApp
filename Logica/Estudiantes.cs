using System.Collections.Generic;
using System.Net.Mime;
using System.Windows.Forms;
using Logica.Libreria;

namespace Logica
{
    public class Estudiantes : Librerias
    {
        private List<TextBox> listaTextBox;
        public Estudiantes(List<TextBox> listaTextBox)
        {
            this.listaTextBox = listaTextBox;
        }
    }
}