namespace LovacNaCudovista.Forme
{
    partial class NeMagCudForm
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
            groupBox2 = new GroupBox();
            btnIzmeniCud = new Button();
            btnObrisiCud = new Button();
            btnDodajCud = new Button();
            groupBox1 = new GroupBox();
            listaCudovista = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            btnBajalica = new Button();
            btnSpecSpos = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeniCud);
            groupBox2.Controls.Add(btnObrisiCud);
            groupBox2.Controls.Add(btnDodajCud);
            groupBox2.Location = new Point(1143, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 192);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnIzmeniCud
            // 
            btnIzmeniCud.AutoSize = true;
            btnIzmeniCud.BackColor = SystemColors.ScrollBar;
            btnIzmeniCud.Location = new Point(40, 127);
            btnIzmeniCud.Name = "btnIzmeniCud";
            btnIzmeniCud.Size = new Size(140, 45);
            btnIzmeniCud.TabIndex = 3;
            btnIzmeniCud.Text = "Izmeni Cudoviste";
            btnIzmeniCud.UseVisualStyleBackColor = false;
            btnIzmeniCud.Click += btnIzmeniCud_Click;
            // 
            // btnObrisiCud
            // 
            btnObrisiCud.AutoSize = true;
            btnObrisiCud.BackColor = SystemColors.ScrollBar;
            btnObrisiCud.Location = new Point(40, 76);
            btnObrisiCud.Name = "btnObrisiCud";
            btnObrisiCud.Size = new Size(140, 45);
            btnObrisiCud.TabIndex = 2;
            btnObrisiCud.Text = "Obrisi Cudoviste";
            btnObrisiCud.UseVisualStyleBackColor = false;
            btnObrisiCud.Click += btnObrisiCud_Click;
            // 
            // btnDodajCud
            // 
            btnDodajCud.AutoSize = true;
            btnDodajCud.BackColor = SystemColors.ScrollBar;
            btnDodajCud.Location = new Point(40, 24);
            btnDodajCud.Name = "btnDodajCud";
            btnDodajCud.Size = new Size(140, 45);
            btnDodajCud.TabIndex = 1;
            btnDodajCud.Text = "Dodaj Cudovista";
            btnDodajCud.UseVisualStyleBackColor = false;
            btnDodajCud.Click += btnDodajCud_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaCudovista);
            groupBox1.Location = new Point(23, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1031, 484);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nemagicna Cudovista";
            // 
            // listaCudovista
            // 
            listaCudovista.BackColor = SystemColors.ScrollBar;
            listaCudovista.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listaCudovista.Dock = DockStyle.Fill;
            listaCudovista.FullRowSelect = true;
            listaCudovista.GridLines = true;
            listaCudovista.Location = new Point(3, 24);
            listaCudovista.Name = "listaCudovista";
            listaCudovista.Size = new Size(1025, 457);
            listaCudovista.TabIndex = 4;
            listaCudovista.UseCompatibleStateImageBehavior = false;
            listaCudovista.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
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
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Visina";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Duzina";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kandze";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Broj Glava";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Zivi u vodi";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Leti";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Otrovno";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Tezina";
            // 
            // btnBajalica
            // 
            btnBajalica.AutoSize = true;
            btnBajalica.BackColor = SystemColors.ScrollBar;
            btnBajalica.Location = new Point(1183, 264);
            btnBajalica.Name = "btnBajalica";
            btnBajalica.Size = new Size(140, 45);
            btnBajalica.TabIndex = 4;
            btnBajalica.Text = "Bajalica";
            btnBajalica.UseVisualStyleBackColor = false;
            btnBajalica.Click += btnBajalica_Click;
            // 
            // btnSpecSpos
            // 
            btnSpecSpos.AutoSize = true;
            btnSpecSpos.BackColor = SystemColors.ScrollBar;
            btnSpecSpos.Location = new Point(1134, 328);
            btnSpecSpos.Name = "btnSpecSpos";
            btnSpecSpos.Size = new Size(189, 45);
            btnSpecSpos.TabIndex = 8;
            btnSpecSpos.Text = "Specijalne Sposobnosti";
            btnSpecSpos.UseVisualStyleBackColor = false;
            // 
            // NeMagCudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1363, 693);
            Controls.Add(btnSpecSpos);
            Controls.Add(btnBajalica);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "NeMagCudForm";
            Text = "NeMagCudForm";
            Load += NeMagCudForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnIzmeniCud;
        private Button btnObrisiCud;
        private Button btnDodajCud;
        private GroupBox groupBox1;
        private ListView listaCudovista;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Button btnBajalica;
        private Button btnSpecSpos;
    }
}