namespace LovacNaCudovista.Forme
{
    partial class CudovistaForm
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
            listaCudovista = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox3 = new GroupBox();
            btnPozPred = new Button();
            btnNeMagCud = new Button();
            btnMagCud = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaCudovista);
            groupBox1.Location = new Point(24, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cudovista";
            // 
            // listaCudovista
            // 
            listaCudovista.BackColor = SystemColors.ScrollBar;
            listaCudovista.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listaCudovista.Dock = DockStyle.Fill;
            listaCudovista.FullRowSelect = true;
            listaCudovista.GridLines = true;
            listaCudovista.Location = new Point(3, 24);
            listaCudovista.Name = "listaCudovista";
            listaCudovista.Size = new Size(604, 361);
            listaCudovista.TabIndex = 4;
            listaCudovista.UseCompatibleStateImageBehavior = false;
            listaCudovista.View = View.Details;
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
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PodTip";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Vek Pominjanja Cudovista";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPozPred);
            groupBox3.Controls.Add(btnNeMagCud);
            groupBox3.Controls.Add(btnMagCud);
            groupBox3.Location = new Point(798, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(206, 243);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // btnPozPred
            // 
            btnPozPred.AutoSize = true;
            btnPozPred.BackColor = SystemColors.ScrollBar;
            btnPozPred.Location = new Point(23, 165);
            btnPozPred.Name = "btnPozPred";
            btnPozPred.Size = new Size(172, 45);
            btnPozPred.TabIndex = 6;
            btnPozPred.Text = "Poznati Predstavnik";
            btnPozPred.UseVisualStyleBackColor = false;
            btnPozPred.Click += btnPozPred_Click;
            // 
            // btnNeMagCud
            // 
            btnNeMagCud.AutoSize = true;
            btnNeMagCud.BackColor = SystemColors.ScrollBar;
            btnNeMagCud.Location = new Point(23, 97);
            btnNeMagCud.Name = "btnNeMagCud";
            btnNeMagCud.Size = new Size(172, 45);
            btnNeMagCud.TabIndex = 5;
            btnNeMagCud.Text = "NeMagicna Cudovista";
            btnNeMagCud.UseVisualStyleBackColor = false;
            btnNeMagCud.Click += btnNeMagCud_Click;
            // 
            // btnMagCud
            // 
            btnMagCud.AutoSize = true;
            btnMagCud.BackColor = SystemColors.ScrollBar;
            btnMagCud.FlatStyle = FlatStyle.System;
            btnMagCud.Location = new Point(23, 27);
            btnMagCud.Name = "btnMagCud";
            btnMagCud.Size = new Size(172, 45);
            btnMagCud.TabIndex = 4;
            btnMagCud.Text = "Magicna Cudovista";
            btnMagCud.UseVisualStyleBackColor = false;
            btnMagCud.Click += btnMagCud_Click;
            // 
            // CudovistaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1050, 546);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CudovistaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cudovista";
            Load += CudovistaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaCudovista;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox3;
        private Button btnNeMagCud;
        private Button btnMagCud;
        private Button btnPozPred;
    }
}