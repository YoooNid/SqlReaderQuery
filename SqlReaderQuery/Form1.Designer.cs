﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.Gr_data)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Aplicar
            // 
            this.Bt_Aplicar.Location = new System.Drawing.Point(12, 112);
            this.Bt_Aplicar.Name = "Bt_Aplicar";
            this.Bt_Aplicar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Aplicar.TabIndex = 0;
            this.Bt_Aplicar.Text = "Aplicar";
            this.Bt_Aplicar.UseVisualStyleBackColor = true;
            this.Bt_Aplicar.Click += new System.EventHandler(this.Bt_Aplicar_Click);
            // 
            // Bt_Executar
            // 
            this.Bt_Executar.Location = new System.Drawing.Point(195, 112);
            this.Bt_Executar.Name = "Bt_Executar";
            this.Bt_Executar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Executar.TabIndex = 1;
            this.Bt_Executar.Text = "Executar";
            this.Bt_Executar.UseVisualStyleBackColor = true;
            this.Bt_Executar.Click += new System.EventHandler(this.Bt_Executar_Click);
            // 
            // Tx_ComandoAplicar
            // 
            this.Tx_ComandoAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tx_ComandoAplicar.Location = new System.Drawing.Point(12, 54);
            this.Tx_ComandoAplicar.Name = "Tx_ComandoAplicar";
            this.Tx_ComandoAplicar.Size = new System.Drawing.Size(746, 23);
            this.Tx_ComandoAplicar.TabIndex = 2;
            // 
            // Tx_ComandoExecutar
            // 
            this.Tx_ComandoExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tx_ComandoExecutar.Location = new System.Drawing.Point(12, 83);
            this.Tx_ComandoExecutar.Name = "Tx_ComandoExecutar";
            this.Tx_ComandoExecutar.Size = new System.Drawing.Size(746, 23);
            this.Tx_ComandoExecutar.TabIndex = 3;
            // 
            // Bt_Excel
            // 
            this.Bt_Excel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bt_Excel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bt_Excel.FlatAppearance.BorderSize = 0;
            this.Bt_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.Gr_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gr_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Gr_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gr_data.Location = new System.Drawing.Point(12, 141);
            this.Gr_data.Name = "Gr_data";
            this.Gr_data.RowTemplate.Height = 25;
            this.Gr_data.Size = new System.Drawing.Size(746, 282);
            this.Gr_data.TabIndex = 5;
            // 
            // Cb_Database
            // 
            this.Cb_Database.FormattingEnabled = true;
            this.Cb_Database.Location = new System.Drawing.Point(12, 12);
            this.Cb_Database.Name = "Cb_Database";
            this.Cb_Database.Size = new System.Drawing.Size(121, 23);
            this.Cb_Database.TabIndex = 6;
            this.Cb_Database.SelectedValueChanged += new System.EventHandler(this.Cb_Database_SelectedValueChanged);
            // 
            // Cb_Tables
            // 
            this.Cb_Tables.FormattingEnabled = true;
            this.Cb_Tables.Location = new System.Drawing.Point(207, 12);
            this.Cb_Tables.Name = "Cb_Tables";
            this.Cb_Tables.Size = new System.Drawing.Size(121, 23);
            this.Cb_Tables.TabIndex = 7;
            this.Cb_Tables.SelectedValueChanged += new System.EventHandler(this.Cb_Tables_SelectedValueChanged);
            // 
            // Lb_Contagem
            // 
            this.Lb_Contagem.AutoSize = true;
            this.Lb_Contagem.Location = new System.Drawing.Point(434, 12);
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
            // Fm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 471);
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
    }
}
