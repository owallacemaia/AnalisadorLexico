using System;
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
            lbToken.Items.Clear();
            Analisador an = new Analisador();
            rtbFinal.Text = an.AnalisadorExec(rtbTexto.Text);
            int op = 0;
            foreach (var item in an.listaLexema)
            {
                if(item != null)
                {
                    op = an.listaLexema.FindIndex(a => item == a) + 1;
                    lbToken.Items.Add(op + " " + item);
                }
            }
        }
    }
}
