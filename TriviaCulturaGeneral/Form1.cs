﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaCulturaGeneral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            FormularioPreguntas formulariopreguntas = new FormularioPreguntas();
            formulariopreguntas.Show();
            this.Hide();

        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();    
        }
    }
}
