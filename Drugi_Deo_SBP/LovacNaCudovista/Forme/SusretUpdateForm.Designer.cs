﻿namespace LovacNaCudovista.Forme
{
    partial class SusretUpdateForm
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
            btnAzuriraj = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbIshod);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbVreme);
            groupBox1.Controls.Add(btnAzuriraj);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 386);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o susretu";
            // 
            // txbIshod
            // 
            txbIshod.Location = new Point(213, 191);
            txbIshod.Name = "txbIshod";
            txbIshod.Size = new Size(125, 27);
            txbIshod.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 194);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 9;
            label2.Text = "Ishod";
            // 
            // txbVreme
            // 
            txbVreme.Location = new Point(213, 101);
            txbVreme.Name = "txbVreme";
            txbVreme.Size = new Size(125, 27);
            txbVreme.TabIndex = 8;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(474, 308);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(203, 58);
            btnAzuriraj.TabIndex = 7;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 104);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Vreme";
            // 
            // SusretUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "SusretUpdateForm";
            Text = "SusretUpdateForm";
            Load += SusretUpdateForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbIshod;
        private Label label2;
        private TextBox txbVreme;
        private Button btnAzuriraj;
        private Label label1;
    }
}