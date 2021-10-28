
namespace SqlReaderQuery
{
    partial class ComandoPersonalizado
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
            this.Tx_EditarComando = new System.Windows.Forms.TextBox();
            this.Bt_GravarComandoPersonalizado = new System.Windows.Forms.Button();
            this.Bt_FecharForm2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cb_PosicaoComando = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tx_NomeComando = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tx_EditarComando
            // 
            this.Tx_EditarComando.Location = new System.Drawing.Point(12, 94);
            this.Tx_EditarComando.Multiline = true;
            this.Tx_EditarComando.Name = "Tx_EditarComando";
            this.Tx_EditarComando.Size = new System.Drawing.Size(588, 78);
            this.Tx_EditarComando.TabIndex = 0;
            // 
            // Bt_GravarComandoPersonalizado
            // 
            this.Bt_GravarComandoPersonalizado.Location = new System.Drawing.Point(525, 178);
            this.Bt_GravarComandoPersonalizado.Name = "Bt_GravarComandoPersonalizado";
            this.Bt_GravarComandoPersonalizado.Size = new System.Drawing.Size(75, 23);
            this.Bt_GravarComandoPersonalizado.TabIndex = 1;
            this.Bt_GravarComandoPersonalizado.Text = "Gravar";
            this.Bt_GravarComandoPersonalizado.UseVisualStyleBackColor = true;
            this.Bt_GravarComandoPersonalizado.Click += new System.EventHandler(this.Bt_GravarComandoPersonalizado_Click);
            // 
            // Bt_FecharForm2
            // 
            this.Bt_FecharForm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_FecharForm2.BackColor = System.Drawing.Color.White;
            this.Bt_FecharForm2.FlatAppearance.BorderSize = 0;
            this.Bt_FecharForm2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Bt_FecharForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_FecharForm2.Location = new System.Drawing.Point(585, 0);
            this.Bt_FecharForm2.Name = "Bt_FecharForm2";
            this.Bt_FecharForm2.Size = new System.Drawing.Size(27, 22);
            this.Bt_FecharForm2.TabIndex = 2;
            this.Bt_FecharForm2.Text = "X";
            this.Bt_FecharForm2.UseVisualStyleBackColor = false;
            this.Bt_FecharForm2.Click += new System.EventHandler(this.Bt_FecharForm2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar Comando Personalizado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Bt_FecharForm2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 22);
            this.panel1.TabIndex = 4;
            // 
            // Cb_PosicaoComando
            // 
            this.Cb_PosicaoComando.FormattingEnabled = true;
            this.Cb_PosicaoComando.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4",
            "C5"});
            this.Cb_PosicaoComando.Location = new System.Drawing.Point(12, 178);
            this.Cb_PosicaoComando.Name = "Cb_PosicaoComando";
            this.Cb_PosicaoComando.Size = new System.Drawing.Size(160, 23);
            this.Cb_PosicaoComando.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titulo";
            // 
            // Tx_NomeComando
            // 
            this.Tx_NomeComando.Location = new System.Drawing.Point(13, 47);
            this.Tx_NomeComando.Name = "Tx_NomeComando";
            this.Tx_NomeComando.Size = new System.Drawing.Size(285, 23);
            this.Tx_NomeComando.TabIndex = 8;
            // 
            // ComandoPersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 213);
            this.Controls.Add(this.Tx_NomeComando);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_PosicaoComando);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bt_GravarComandoPersonalizado);
            this.Controls.Add(this.Tx_EditarComando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComandoPersonalizado";
            this.Text = "ComandoPersonalizado";
            this.Load += new System.EventHandler(this.ComandoPersonalizado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tx_EditarComando;
        private System.Windows.Forms.Button Bt_GravarComandoPersonalizado;
        private System.Windows.Forms.Button Bt_FecharForm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Cb_PosicaoComando;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tx_NomeComando;
    }
}