﻿namespace LovacNaCudovista.Forme
{
    partial class UslovZaPrimenuForm
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
            groupBox1 = new GroupBox();
            listaUslova = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnDodaj = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaUslova);
            groupBox1.Location = new Point(35, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 388);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // listaUslova
            // 
            listaUslova.BackColor = SystemColors.ScrollBar;
            listaUslova.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listaUslova.Dock = DockStyle.Fill;
            listaUslova.FullRowSelect = true;
            listaUslova.GridLines = true;
            listaUslova.Location = new Point(3, 24);
            listaUslova.Name = "listaUslova";
            listaUslova.Size = new Size(326, 361);
            listaUslova.TabIndex = 4;
            listaUslova.UseCompatibleStateImageBehavior = false;
            listaUslova.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Uslov";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 220;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Location = new Point(462, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 192);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnIzmeni
            // 
            btnIzmeni.AutoSize = true;
            btnIzmeni.BackColor = SystemColors.ScrollBar;
            btnIzmeni.Location = new Point(40, 127);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(132, 45);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.AutoSize = true;
            btnObrisi.BackColor = SystemColors.ScrollBar;
            btnObrisi.Location = new Point(40, 76);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(132, 45);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.AutoSize = true;
            btnDodaj.BackColor = SystemColors.ScrollBar;
            btnDodaj.Location = new Point(40, 24);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(132, 45);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // UslovZaPrimenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(695, 472);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F);
            Name = "UslovZaPrimenuForm";
            Text = "UslovZaPrimenuForm";
            Load += UslovZaPrimenuForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaUslova;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox2;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnDodaj;
    }
}