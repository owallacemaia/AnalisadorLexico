
namespace AnalisadorLexico
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnExecutar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSelecionar = new MaterialSkin.Controls.MaterialLabel();
            this.btnSelecionarArquivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "Arquivo";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Depth = 0;
            this.btnExecutar.Location = new System.Drawing.Point(209, 123);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExecutar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Primary = true;
            this.btnExecutar.Size = new System.Drawing.Size(160, 32);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelecionar.Depth = 0;
            this.lblSelecionar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSelecionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSelecionar.Location = new System.Drawing.Point(23, 112);
            this.lblSelecionar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(136, 19);
            this.lblSelecionar.TabIndex = 0;
            this.lblSelecionar.Text = "Selecionar Arquivo";
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Depth = 0;
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(209, 86);
            this.btnSelecionarArquivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelecionarArquivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Primary = true;
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(160, 32);
            this.btnSelecionarArquivo.TabIndex = 2;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(12, 178);
            this.rtbTexto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(448, 355);
            this.rtbTexto.TabIndex = 3;
            this.rtbTexto.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 571);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lblSelecionar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.Text = "Analisador Léxico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnExecutar;
        private MaterialSkin.Controls.MaterialLabel lblSelecionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSelecionarArquivo;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

