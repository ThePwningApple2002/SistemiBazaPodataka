﻿namespace LovacNaCudovista.Forme
{
    partial class PredmetAddForm
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
            txbTip = new TextBox();
            txbNaziv = new TextBox();
            btnDodaj = new Button();
            txbMaterijal = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbTip);
            groupBox1.Controls.Add(txbNaziv);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txbMaterijal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 405);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o predmetu";
            // 
            // txbTip
            // 
            txbTip.Location = new Point(464, 106);
            txbTip.Name = "txbTip";
            txbTip.Size = new Size(125, 28);
            txbTip.TabIndex = 9;
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new Point(213, 106);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new Size(125, 28);
            txbNaziv.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = SystemColors.ScrollBar;
            btnDodaj.Location = new Point(474, 323);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(203, 61);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txbMaterijal
            // 
            txbMaterijal.Location = new Point(213, 201);
            txbMaterijal.Name = "txbMaterijal";
            txbMaterijal.Size = new Size(125, 28);
            txbMaterijal.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 201);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 3;
            label4.Text = "Materijal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 109);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 2;
            label3.Text = "Tip";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 109);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "Naziv";
            // 
            // PredmetAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 472);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PredmetAddForm";
            Text = "PredmetAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbTip;
        private TextBox txbNaziv;
        private Button btnDodaj;
        private TextBox txbMaterijal;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}