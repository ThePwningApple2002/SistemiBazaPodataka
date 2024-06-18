namespace LovacNaCudovista.Forme
{
    partial class BajalicaAddForm
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
            txbZastita = new TextBox();
            txbNaziv = new TextBox();
            btnDodaj = new Button();
            txbPrednost = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbZastita);
            groupBox1.Controls.Add(txbNaziv);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txbPrednost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 405);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o bajalici";
            // 
            // txbZastita
            // 
            txbZastita.Location = new Point(464, 106);
            txbZastita.Name = "txbZastita";
            txbZastita.Size = new Size(125, 28);
            txbZastita.TabIndex = 9;
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
            // txbPrednost
            // 
            txbPrednost.Location = new Point(213, 201);
            txbPrednost.Name = "txbPrednost";
            txbPrednost.Size = new Size(125, 28);
            txbPrednost.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 201);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 3;
            label4.Text = "Prednost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 109);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 2;
            label3.Text = "Zastita";
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
            // BajalicaAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 472);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "BajalicaAddForm";
            Text = "BajalicaAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbBlago;
        private Label label2;
        private TextBox txbNazivLok;
        private TextBox txbTipLok;
        private Button btnDodaj;
        private TextBox txbPrednost;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txbZastita;
        private TextBox txbNaziv;
    }
}