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

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            rtbFinal.Text = new Analisador().AnalisadorExec(rtbTexto.Text);
        }
    }
}
