﻿namespace LovacNaCudovista.Forme
{
    partial class SusretAddForm
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
            txbIshod = new TextBox();
            label2 = new Label();
            txbVreme = new TextBox();
            btnDodaj = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbIshod);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbVreme);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 405);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o susretu";
            // 
            // txbIshod
            // 
            txbIshod.Location = new Point(213, 201);
            txbIshod.Name = "txbIshod";
            txbIshod.Size = new Size(125, 28);
            txbIshod.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 204);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 9;
            label2.Text = "Ishod";
            // 
            // txbVreme
            // 
            txbVreme.Location = new Point(213, 106);
            txbVreme.Name = "txbVreme";
            txbVreme.Size = new Size(125, 28);
            txbVreme.TabIndex = 8;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 109);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Vreme";
            // 
            // SusretAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 472);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SusretAddForm";
            Text = "SusretAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbVreme;
        private Button btnDodaj;
        private Label label1;
        private TextBox txbIshod;
        private Label label2;
    }
}