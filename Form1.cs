using System;
using System.Drawing;
using System.Windows.Forms;
using Logica;

namespace EstudiantesApp
{
    public partial class Form1 : Form
    {
        private Estudiantes _estudiantes = new Estudiantes();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            _estudiantes.CargarImagenes(pictureBoxImage);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.Text.Equals(""))
            {
                labelId.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelId.ForeColor = Color.Green;
                labelId.Text = "Nid";
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                labelId.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelId.ForeColor = Color.Green;
                labelId.Text = "Nombre";
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellido.Text.Equals(""))
            {
                labelId.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelId.ForeColor = Color.Green;
                labelId.Text = "Apellido";
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelId.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelId.ForeColor = Color.Green;
                labelId.Text = "Email";
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}