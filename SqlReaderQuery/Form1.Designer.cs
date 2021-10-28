
namespace SqlReaderQuery
{
    partial class Fm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bt_Aplicar = new System.Windows.Forms.Button();
            this.Bt_Executar = new System.Windows.Forms.Button();
            this.Tx_ComandoAplicar = new System.Windows.Forms.TextBox();
            this.Tx_ComandoExecutar = new System.Windows.Forms.TextBox();
            this.Bt_Excel = new System.Windows.Forms.Button();
            this.Gr_data = new System.Windows.Forms.DataGridView();
            this.Cb_Database = new System.Windows.Forms.ComboBox();
            this.Cb_Tables = new System.Windows.Forms.ComboBox();
            this.Lb_Contagem = new System.Windows.Forms.Label();
            this.Bt_Filtrar = new System.Windows.Forms.Button();
            this.Bt_Exportar = new System.Windows.Forms.Button();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Importar = new System.Windows.Forms.Button();
            this.LL_AdicionarComando = new System.Windows.Forms.LinkLabel();
            this.LL_C1 = new System.Windows.Forms.LinkLabel();
            this.LL_C2 = new System.Windows.Forms.LinkLabel();
            this.LL_C3 = new System.Windows.Forms.LinkLabel();
            this.LL_C4 = new System.Windows.Forms.LinkLabel();
            this.LL_C5 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Gr_data)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Aplicar
            // 
            this.Bt_Aplicar.Location = new System.Drawing.Point(12, 54);
            this.Bt_Aplicar.Name = "Bt_Aplicar";
            this.Bt_Aplicar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Aplicar.TabIndex = 0;
            this.Bt_Aplicar.Text = "Aplicar";
            this.Bt_Aplicar.UseVisualStyleBackColor = true;
            this.Bt_Aplicar.Click += new System.EventHandler(this.Bt_Aplicar_Click);
            // 
            // Bt_Executar
            // 
            this.Bt_Executar.Location = new System.Drawing.Point(12, 83);
            this.Bt_Executar.Name = "Bt_Executar";
            this.Bt_Executar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Executar.TabIndex = 1;
            this.Bt_Executar.Text = "Executar";
            this.Bt_Executar.UseVisualStyleBackColor = true;
            this.Bt_Executar.Click += new System.EventHandler(this.Bt_Executar_Click);
            // 
            // Tx_ComandoAplicar
            // 
            this.Tx_ComandoAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tx_ComandoAplicar.Location = new System.Drawing.Point(93, 54);
            this.Tx_ComandoAplicar.Name = "Tx_ComandoAplicar";
            this.Tx_ComandoAplicar.Size = new System.Drawing.Size(665, 23);
            this.Tx_ComandoAplicar.TabIndex = 2;
            // 
            // Tx_ComandoExecutar
            // 
            this.Tx_ComandoExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tx_ComandoExecutar.Location = new System.Drawing.Point(93, 83);
            this.Tx_ComandoExecutar.Name = "Tx_ComandoExecutar";
            this.Tx_ComandoExecutar.Size = new System.Drawing.Size(665, 23);
            this.Tx_ComandoExecutar.TabIndex = 3;
            // 
            // Bt_Excel
            // 
            this.Bt_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Excel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bt_Excel.FlatAppearance.BorderSize = 0;
            this.Bt_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Excel.ForeColor = System.Drawing.Color.White;
            this.Bt_Excel.Location = new System.Drawing.Point(630, 112);
            this.Bt_Excel.Name = "Bt_Excel";
            this.Bt_Excel.Size = new System.Drawing.Size(128, 23);
            this.Bt_Excel.TabIndex = 4;
            this.Bt_Excel.Text = "Salvar Dados Excel";
            this.Bt_Excel.UseVisualStyleBackColor = false;
            this.Bt_Excel.Click += new System.EventHandler(this.Bt_Excel_Click);
            // 
            // Gr_data
            // 
            this.Gr_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gr_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Gr_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_data.Location = new System.Drawing.Point(12, 141);
            this.Gr_data.Name = "Gr_data";
            this.Gr_data.RowTemplate.Height = 25;
            this.Gr_data.Size = new System.Drawing.Size(746, 304);
            this.Gr_data.TabIndex = 5;
            this.Gr_data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gr_data_CellValueChanged);
            // 
            // Cb_Database
            // 
            this.Cb_Database.FormattingEnabled = true;
            this.Cb_Database.Location = new System.Drawing.Point(12, 25);
            this.Cb_Database.Name = "Cb_Database";
            this.Cb_Database.Size = new System.Drawing.Size(169, 23);
            this.Cb_Database.TabIndex = 6;
            this.Cb_Database.SelectedValueChanged += new System.EventHandler(this.Cb_Database_SelectedValueChanged);
            // 
            // Cb_Tables
            // 
            this.Cb_Tables.FormattingEnabled = true;
            this.Cb_Tables.Location = new System.Drawing.Point(213, 25);
            this.Cb_Tables.Name = "Cb_Tables";
            this.Cb_Tables.Size = new System.Drawing.Size(195, 23);
            this.Cb_Tables.TabIndex = 7;
            this.Cb_Tables.SelectedValueChanged += new System.EventHandler(this.Cb_Tables_SelectedValueChanged);
            // 
            // Lb_Contagem
            // 
            this.Lb_Contagem.AutoSize = true;
            this.Lb_Contagem.Location = new System.Drawing.Point(545, 20);
            this.Lb_Contagem.Name = "Lb_Contagem";
            this.Lb_Contagem.Size = new System.Drawing.Size(0, 15);
            this.Lb_Contagem.TabIndex = 8;
            // 
            // Bt_Filtrar
            // 
            this.Bt_Filtrar.Location = new System.Drawing.Point(93, 112);
            this.Bt_Filtrar.Name = "Bt_Filtrar";
            this.Bt_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Filtrar.TabIndex = 9;
            this.Bt_Filtrar.Text = "Filtrar";
            this.Bt_Filtrar.UseVisualStyleBackColor = true;
            this.Bt_Filtrar.Click += new System.EventHandler(this.Bt_Filtrar_Click);
            // 
            // Bt_Exportar
            // 
            this.Bt_Exportar.BackColor = System.Drawing.Color.Red;
            this.Bt_Exportar.FlatAppearance.BorderSize = 0;
            this.Bt_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Exportar.ForeColor = System.Drawing.Color.White;
            this.Bt_Exportar.Location = new System.Drawing.Point(174, 112);
            this.Bt_Exportar.Name = "Bt_Exportar";
            this.Bt_Exportar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Exportar.TabIndex = 10;
            this.Bt_Exportar.Text = "Exportar";
            this.Bt_Exportar.UseVisualStyleBackColor = false;
            this.Bt_Exportar.Click += new System.EventHandler(this.Bt_Exportar_Click);
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.Location = new System.Drawing.Point(12, 112);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.Bt_Delete.TabIndex = 11;
            this.Bt_Delete.Text = "Deletar";
            this.Bt_Delete.UseVisualStyleBackColor = true;
            this.Bt_Delete.Click += new System.EventHandler(this.Bt_Delete_Click);
            // 
            // Bt_Importar
            // 
            this.Bt_Importar.BackColor = System.Drawing.Color.Lime;
            this.Bt_Importar.FlatAppearance.BorderSize = 0;
            this.Bt_Importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Importar.Location = new System.Drawing.Point(256, 112);
            this.Bt_Importar.Name = "Bt_Importar";
            this.Bt_Importar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Importar.TabIndex = 12;
            this.Bt_Importar.Text = "Importar";
            this.Bt_Importar.UseVisualStyleBackColor = false;
            this.Bt_Importar.Click += new System.EventHandler(this.Bt_Importar_Click);
            // 
            // LL_AdicionarComando
            // 
            this.LL_AdicionarComando.AutoSize = true;
            this.LL_AdicionarComando.Location = new System.Drawing.Point(13, 452);
            this.LL_AdicionarComando.Name = "LL_AdicionarComando";
            this.LL_AdicionarComando.Size = new System.Drawing.Size(201, 15);
            this.LL_AdicionarComando.TabIndex = 13;
            this.LL_AdicionarComando.TabStop = true;
            this.LL_AdicionarComando.Text = "Adicionar Comando Personalizado +";
            this.LL_AdicionarComando.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_C1_LinkClicked);
            // 
            // LL_C1
            // 
            this.LL_C1.AutoSize = true;
            this.LL_C1.Location = new System.Drawing.Point(13, 480);
            this.LL_C1.Name = "LL_C1";
            this.LL_C1.Size = new System.Drawing.Size(60, 15);
            this.LL_C1.TabIndex = 14;
            this.LL_C1.TabStop = true;
            this.LL_C1.Text = "linkLabel1";
            this.LL_C1.Visible = false;
            this.LL_C1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_C1_LinkClicked_1);
            // 
            // LL_C2
            // 
            this.LL_C2.AutoSize = true;
            this.LL_C2.Location = new System.Drawing.Point(13, 499);
            this.LL_C2.Name = "LL_C2";
            this.LL_C2.Size = new System.Drawing.Size(60, 15);
            this.LL_C2.TabIndex = 15;
            this.LL_C2.TabStop = true;
            this.LL_C2.Text = "linkLabel1";
            this.LL_C2.Visible = false;
            // 
            // LL_C3
            // 
            this.LL_C3.AutoSize = true;
            this.LL_C3.Location = new System.Drawing.Point(153, 480);
            this.LL_C3.Name = "LL_C3";
            this.LL_C3.Size = new System.Drawing.Size(60, 15);
            this.LL_C3.TabIndex = 16;
            this.LL_C3.TabStop = true;
            this.LL_C3.Text = "linkLabel2";
            this.LL_C3.Visible = false;
            // 
            // LL_C4
            // 
            this.LL_C4.AutoSize = true;
            this.LL_C4.Location = new System.Drawing.Point(153, 498);
            this.LL_C4.Name = "LL_C4";
            this.LL_C4.Size = new System.Drawing.Size(60, 15);
            this.LL_C4.TabIndex = 17;
            this.LL_C4.TabStop = true;
            this.LL_C4.Text = "linkLabel3";
            this.LL_C4.Visible = false;
            // 
            // LL_C5
            // 
            this.LL_C5.AutoSize = true;
            this.LL_C5.Location = new System.Drawing.Point(292, 479);
            this.LL_C5.Name = "LL_C5";
            this.LL_C5.Size = new System.Drawing.Size(60, 15);
            this.LL_C5.TabIndex = 18;
            this.LL_C5.TabStop = true;
            this.LL_C5.Text = "linkLabel4";
            this.LL_C5.Visible = false;
            // 
            // Fm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 535);
            this.Controls.Add(this.LL_C5);
            this.Controls.Add(this.LL_C4);
            this.Controls.Add(this.LL_C3);
            this.Controls.Add(this.LL_C2);
            this.Controls.Add(this.LL_C1);
            this.Controls.Add(this.LL_AdicionarComando);
            this.Controls.Add(this.Bt_Importar);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.Bt_Exportar);
            this.Controls.Add(this.Bt_Filtrar);
            this.Controls.Add(this.Lb_Contagem);
            this.Controls.Add(this.Cb_Tables);
            this.Controls.Add(this.Cb_Database);
            this.Controls.Add(this.Gr_data);
            this.Controls.Add(this.Bt_Excel);
            this.Controls.Add(this.Tx_ComandoExecutar);
            this.Controls.Add(this.Tx_ComandoAplicar);
            this.Controls.Add(this.Bt_Executar);
            this.Controls.Add(this.Bt_Aplicar);
            this.Name = "Fm_Principal";
            this.Text = "UtilReaderQuery";
            this.Load += new System.EventHandler(this.Fm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gr_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Aplicar;
        private System.Windows.Forms.Button Bt_Executar;
        private System.Windows.Forms.TextBox Tx_ComandoAplicar;
        private System.Windows.Forms.TextBox Tx_ComandoExecutar;
        private System.Windows.Forms.Button Bt_Excel;
        private System.Windows.Forms.DataGridView Gr_data;
        private System.Windows.Forms.ComboBox Cb_Database;
        private System.Windows.Forms.ComboBox Cb_Tables;
        private System.Windows.Forms.Label Lb_Contagem;
        private System.Windows.Forms.Button Bt_Filtrar;
        private System.Windows.Forms.Button Bt_Exportar;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Importar;
        private System.Windows.Forms.LinkLabel LL_AdicionarComando;
        private System.Windows.Forms.LinkLabel LL_C1;
        private System.Windows.Forms.LinkLabel LL_C2;
        private System.Windows.Forms.LinkLabel LL_C3;
        private System.Windows.Forms.LinkLabel LL_C4;
        private System.Windows.Forms.LinkLabel LL_C5;
    }
}

