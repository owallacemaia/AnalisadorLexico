﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisadorLexico
{
    public partial class frmPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = ("Braselisco (*.BRO)|*.BRO" );//+ "All (*.*)|*.*")
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                lblSelecionar.Text = openFileDialog1.SafeFileName;
                rtbTexto.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
