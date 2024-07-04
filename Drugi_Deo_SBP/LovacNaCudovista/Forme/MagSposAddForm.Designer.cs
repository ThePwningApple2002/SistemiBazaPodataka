namespace LovacNaCudovista.Forme
{
    partial class MagSposAddForm
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
            txbDefanzivna = new TextBox();
            label4 = new Label();
            txbOfanzivno = new TextBox();
            label3 = new Label();
            txbOpis = new TextBox();
            label2 = new Label();
            txbNaziv = new TextBox();
            label5 = new Label();
            btnDodaj = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbDefanzivna);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txbOfanzivno);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbOpis);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbNaziv);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Font = new Font("Impact", 10.2F);
            groupBox1.Location = new Point(38, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1075, 405);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o sposobnosti";
            // 
            // txbDefanzivna
            // 
            txbDefanzivna.Location = new Point(553, 182);
            txbDefanzivna.Name = "txbDefanzivna";
            txbDefanzivna.Size = new Size(125, 28);
            txbDefanzivna.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 185);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 21;
            label4.Text = "Defanzivna";
            // 
            // txbOfanzivno
            // 
            txbOfanzivno.Location = new Point(205, 179);
            txbOfanzivno.Name = "txbOfanzivno";
            txbOfanzivno.Size = new Size(125, 28);
            txbOfanzivno.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 182);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 19;
            label3.Text = "Ofanzivna";
            // 
            // txbOpis
            // 
            txbOpis.Location = new Point(553, 93);
            txbOpis.Name = "txbOpis";
            txbOpis.Size = new Size(125, 28);
            txbOpis.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 96);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 17;
            label2.Text = "Opis";
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new Point(205, 97);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new Size(125, 28);
            txbNaziv.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 100);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 15;
            label5.Text = "Naziv";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = SystemColors.ScrollBar;
            btnDodaj.Location = new Point(835, 316);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(203, 61);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // MagSposAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1176, 505);
            Controls.Add(groupBox1);
            Name = "MagSposAddForm";
            Text = "MagSposAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDodaj;
        private TextBox txbDefanzivna;
        private Label label4;
        private TextBox txbOfanzivno;
        private Label label3;
        private TextBox txbOpis;
        private Label label2;
        private TextBox txbNaziv;
        private Label label5;
    }
}