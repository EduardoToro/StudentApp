using System;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class EventoTextBox
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Solo datos de texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false; 
            }
            //No da salto de linea cuando se pulsa Enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            //Utilizar tecla Eliminar
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; 
            }
            //Permite tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;
            }
        }
        
        public void numberKeyPress(KeyPressEventArgs e)
        {
            //Solo datos de numerico
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false; 
            }
            //No da salto de linea cuando se pulsa Enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            //No permite letras
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            //Utilizar tecla Eliminar
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; 
            }
            //Permite tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; 
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}