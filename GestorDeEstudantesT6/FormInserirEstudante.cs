﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelecionarImagem = new OpenFileDialog();

            "selecione a foto (*.jpg, *.png, *.gif)"
        }
    }
}
