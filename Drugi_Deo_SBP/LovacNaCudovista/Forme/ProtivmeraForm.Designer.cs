﻿namespace LovacNaCudovista.Forme
{
    partial class ProtivmeraForm
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
            listaProtivmera = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnDodaj = new Button();
            btnUslovi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaProtivmera);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 370);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Protivmera";
            // 
            // listaProtivmera
            // 
            listaProtivmera.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listaProtivmera.Dock = DockStyle.Fill;
            listaProtivmera.FullRowSelect = true;
            listaProtivmera.GridLines = true;
            listaProtivmera.Location = new Point(3, 23);
            listaProtivmera.Name = "listaProtivmera";
            listaProtivmera.Size = new Size(555, 344);
            listaProtivmera.TabIndex = 4;
            listaProtivmera.UseCompatibleStateImageBehavior = false;
            listaProtivmera.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Opis";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 250;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Location = new Point(707, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 183);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // btnIzmeni
            // 
            btnIzmeni.AutoSize = true;
            btnIzmeni.Location = new Point(40, 119);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(132, 43);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.AutoSize = true;
            btnObrisi.Location = new Point(40, 70);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(132, 43);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.AutoSize = true;
            btnDodaj.Location = new Point(40, 23);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(132, 43);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUslovi
            // 
            btnUslovi.AutoSize = true;
            btnUslovi.Location = new Point(747, 240);
            btnUslovi.Name = "btnUslovi";
            btnUslovi.Size = new Size(137, 43);
            btnUslovi.TabIndex = 4;
            btnUslovi.Text = "Uslovi za primenu";
            btnUslovi.UseVisualStyleBackColor = true;
            btnUslovi.Click += btnUslovi_Click;
            // 
            // ProtivmeraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 450);
            Controls.Add(btnUslovi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ProtivmeraForm";
            Text = "Protivmera";
            Load += ProtivmeraForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaProtivmera;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox2;
        private Button btnIzmeniBaj;
        private Button btnObrisiBaj;
        private Button btnDodaj;
        private Button btnObrisi;
        private Button btnIzmeni;
        private Button btnUslovi;
    }
}