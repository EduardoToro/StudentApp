﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logica;

namespace EstudiantesApp
{
    public partial class Form1 : Form
    {
        private Estudiantes _estudiantes;
        public Form1()
        {
            InitializeComponent();

            var listaTextBox = new List<TextBox>();
            listaTextBox.Add(textBoxId);
            listaTextBox.Add(textBoxNombre);
            listaTextBox.Add(textBoxApellido);
            listaTextBox.Add(textBoxEmail);

            var listaLabel = new List<Label>();
            listaLabel.Add(labelId);
            listaLabel.Add(labelNombre);
            listaLabel.Add(labelApellido);
            listaLabel.Add(labelEmail);
            listaLabel.Add(labelPaginas);

            Object[] objetos = { pictureBoxImage, Properties.Resources.persona, dataGridView1, numericUpDown1 };
            
            _estudiantes = new Estudiantes(listaTextBox, listaLabel, objetos);
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            _estudiantes.cargarImagen.CargarImagenes(pictureBoxImage);
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
            _estudiantes.eventoTextBox.numberKeyPress(e);
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
            _estudiantes.eventoTextBox.textKeyPress(e);
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
            _estudiantes.eventoTextBox.textKeyPress(e);
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

        private void buttonAgregar_MouseClick(object sender, MouseEventArgs e)
        {
            _estudiantes.Registrar();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            _estudiantes.BuscarEstudiante(textBoxBuscar.Text);
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            _estudiantes.Paginador("Primero");
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            _estudiantes.Paginador("Anterior");
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            _estudiantes.Paginador("Siguiente");
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            _estudiantes.Paginador("Ultimo");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _estudiantes.RegistroPaginas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                _estudiantes.ObtenerEstudiante();
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                _estudiantes.ObtenerEstudiante();
            }
        }
        
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            _estudiantes.Reestablecer();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            _estudiantes.Eliminar();
        }
    }
}