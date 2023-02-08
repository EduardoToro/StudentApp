using System;
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
    }
}