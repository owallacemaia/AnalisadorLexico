
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
            this.lbToken = new System.Windows.Forms.ListBox();
            this.rtbFinal = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "Arquivo";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Depth = 0;
            this.btnExecutar.Location = new System.Drawing.Point(204, 138);
            this.btnExecutar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Primary = true;
            this.btnExecutar.Size = new System.Drawing.Size(213, 40);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelecionar.Depth = 0;
            this.lblSelecionar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSelecionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSelecionar.Location = new System.Drawing.Point(12, 124);
            this.lblSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(167, 24);
            this.lblSelecionar.TabIndex = 0;
            this.lblSelecionar.Text = "Selecionar Arquivo";
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Depth = 0;
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(204, 92);
            this.btnSelecionarArquivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Primary = true;
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(213, 40);
            this.btnSelecionarArquivo.TabIndex = 2;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(12, 219);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(560, 300);
            this.rtbTexto.TabIndex = 3;
            this.rtbTexto.Text = "";
            this.rtbTexto.TextChanged += new System.EventHandler(this.rtbTexto_TextChanged);
            // 
            // lbToken
            // 
            this.lbToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToken.FormattingEnabled = true;
            this.lbToken.ItemHeight = 20;
            this.lbToken.Location = new System.Drawing.Point(16, 546);
            this.lbToken.Name = "lbToken";
            this.lbToken.Size = new System.Drawing.Size(382, 204);
            this.lbToken.TabIndex = 5;
            this.lbToken.SelectedIndexChanged += new System.EventHandler(this.lbToken_SelectedIndexChanged);
            // 
            // rtbFinal
            // 
            this.rtbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFinal.Location = new System.Drawing.Point(646, 220);
            this.rtbFinal.Name = "rtbFinal";
            this.rtbFinal.Size = new System.Drawing.Size(560, 299);
            this.rtbFinal.TabIndex = 6;
            this.rtbFinal.Text = "";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 868);
            this.Controls.Add(this.rtbFinal);
            this.Controls.Add(this.lbToken);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lblSelecionar);
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
        private System.Windows.Forms.ListBox lbToken;
        private System.Windows.Forms.RichTextBox rtbFinal;
    }
}

