namespace LovacNaCudovista.Forme
{
    partial class SusretForm
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
            listaSusreta = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
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
            groupBox1.Controls.Add(listaSusreta);
            groupBox1.Location = new Point(28, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 370);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Susret";
            // 
            // listaSusreta
            // 
            listaSusreta.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader4, columnHeader5 });
            listaSusreta.Dock = DockStyle.Fill;
            listaSusreta.FullRowSelect = true;
            listaSusreta.GridLines = true;
            listaSusreta.Location = new Point(3, 23);
            listaSusreta.Name = "listaSusreta";
            listaSusreta.Size = new Size(304, 344);
            listaSusreta.TabIndex = 4;
            listaSusreta.UseCompatibleStateImageBehavior = false;
            listaSusreta.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Vreme";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ishod";
            columnHeader5.Width = 100;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Location = new Point(441, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 183);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnIzmeni
            // 
            btnIzmeni.AutoSize = true;
            btnIzmeni.Location = new Point(40, 121);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(132, 43);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni Susret";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.AutoSize = true;
            btnObrisi.Location = new Point(40, 72);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(132, 43);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obrisi Susret";
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
            btnDodaj.Text = "Dodaj Susret";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // SusretForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SusretForm";
            Text = "Susret";
            Load += SusretForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaSusreta;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox2;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnDodaj;
    }
}