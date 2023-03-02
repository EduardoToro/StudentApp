﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data;
using LinqToDB;
using Logica.Libreria;

namespace Logica
{
    public class Estudiantes : Librerias
    {
        private List<TextBox> listaTextBox;
        private List<Label> listaLabel;
        private PictureBox image;
        private Bitmap _imageBitmap;
        private DataGridView _dataGridView;
        private NumericUpDown _numericUpDown;
        public Estudiantes(List<TextBox> listaTextBox, List<Label> listaLabel, object[] objetos)
        {
            this.listaTextBox = listaTextBox;
            this.listaLabel = listaLabel;
            image = (PictureBox)objetos[0];
            _imageBitmap = (Bitmap)objetos[1];
            _dataGridView = (DataGridView)objetos[2];
            _numericUpDown = (NumericUpDown)objetos[3]; 
            Reestablecer();
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
                                var usuario = _Estudiante.Where(u => u.email.Equals(listaTextBox[3].Text)).ToList();
                                if (usuario.Count().Equals(0))
                                {
                                    GuardarEstudiante();
                                }
                                else
                                {
                                    listaLabel[3].Text = "Email ya registrado"; 
                                    listaLabel[3].ForeColor = Color.Red;
                                    listaTextBox[3].Focus();
                                }
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

        private void GuardarEstudiante()
        {
            //Inicia el proceso de transacción
            BeginTransactionAsync(); 
            try
            {
                var imageArray = cargarImagen.imagenByte(image.Image);
                                    
                _Estudiante.Value(e => e.nid, listaTextBox[0].Text)
                    .Value(e => e.nombre, listaTextBox[1].Text)
                    .Value(e => e.apellido, listaTextBox[2].Text)
                    .Value(e => e.email, listaTextBox[3].Text)
                    .Value(e => e.image, imageArray)
                    .Insert();
                                    
                //Permite que la transacción se ejecute
                CommitTransaction();
                
                Reestablecer();
            }
            catch (Exception)
            {
                //Si llega a fallar el método, no se inserta la información
                RollbackTransaction();
            }
        }

        private int _numPagina = 1;
        private int _regPorPagina = 2;
        public void BuscarEstudiante(string campo)
        {
            List<Estudiante> query = new List<Estudiante>();
            //Para crear paginador
            int inicio = (_numPagina - 1) * _regPorPagina;
            if (campo.Equals(""))
            {
                query = _Estudiante.ToList();
            }
            else
            {
                query = _Estudiante.Where(c => c.nid.StartsWith(campo) || c.nombre.StartsWith(campo) 
                                                                       || c.apellido.StartsWith(campo)).ToList();
            }

            if (0 < query.Count)
            {
                _dataGridView.DataSource = query.Select(c => new
                {
                    c.id,
                    c.nid,
                    c.nombre,
                    c.apellido,
                    c.email
                }).Skip(inicio).Take(_regPorPagina).ToList();
                
                //Ocultar una columna
                _dataGridView.Columns[0].Visible = false;
                
                //Estilo a las columnas
                _dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                _dataGridView.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            else
            {
                _dataGridView.DataSource = query.Select(c => new
                {
                    c.nid,
                    c.nombre,
                    c.apellido,
                    c.email
                }).ToList();
            }
        }

        private void Reestablecer()
        {
            image.Image = _imageBitmap;
            listaLabel[0].Text = "Nid"; 
            listaLabel[1].Text = "Nombre";
            listaLabel[2].Text = "Apellido";
            listaLabel[3].Text = "Email";
            listaLabel[0].ForeColor = Color.LightSlateGray;
            listaLabel[1].ForeColor = Color.LightSlateGray;
            listaLabel[2].ForeColor = Color.LightSlateGray;
            listaLabel[3].ForeColor = Color.LightSlateGray;
            listaTextBox[0].Text = "";
            listaTextBox[1].Text = "";
            listaTextBox[2].Text = "";
            listaTextBox[3].Text = "";
            
            BuscarEstudiante("");
        }
    }
}