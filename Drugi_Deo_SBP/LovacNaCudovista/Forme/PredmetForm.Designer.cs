namespace LovacNaCudovista.Forme
{
    partial class PredmetForm
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
            listaPredmeta = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnDodaj = new Button();
            btnProtivmere = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaPredmeta);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 388);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Predmet";
            // 
            // listaPredmeta
            // 
            listaPredmeta.BackColor = SystemColors.ScrollBar;
            listaPredmeta.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listaPredmeta.Dock = DockStyle.Fill;
            listaPredmeta.FullRowSelect = true;
            listaPredmeta.GridLines = true;
            listaPredmeta.Location = new Point(3, 24);
            listaPredmeta.Name = "listaPredmeta";
            listaPredmeta.Size = new Size(604, 361);
            listaPredmeta.TabIndex = 4;
            listaPredmeta.UseCompatibleStateImageBehavior = false;
            listaPredmeta.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tip";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Naziv";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Materijal";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Location = new Point(755, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 192);
            groupBox2.TabIndex = 6;
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
            btnIzmeni.Text = "Izmeni Predmet";
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
            btnObrisi.Text = "Obrisi Predmet";
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
            btnDodaj.Text = "Dodaj Predmet";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnProtivmere
            // 
            btnProtivmere.AutoSize = true;
            btnProtivmere.BackColor = SystemColors.ScrollBar;
            btnProtivmere.Location = new Point(795, 259);
            btnProtivmere.Name = "btnProtivmere";
            btnProtivmere.Size = new Size(132, 45);
            btnProtivmere.TabIndex = 4;
            btnProtivmere.Text = "Protivmere";
            btnProtivmere.UseVisualStyleBackColor = false;
            btnProtivmere.Click += btnProtivmere_Click;
            // 
            // PredmetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(975, 472);
            Controls.Add(btnProtivmere);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PredmetForm";
            Text = "PredmetForm";
            Load += PredmetForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaPredmeta;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox2;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnDodaj;
        private Button btnProtivmere;
    }
}