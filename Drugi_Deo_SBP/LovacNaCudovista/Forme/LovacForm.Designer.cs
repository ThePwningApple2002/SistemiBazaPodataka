namespace LovacNaCudovista.Forme
{
    partial class LovacForm
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
            listaLovca = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeniLovca = new Button();
            btnObrisiLovca = new Button();
            btnDodajLovca = new Button();
            btnSusret = new Button();
            btnPredmet = new Button();
            btnProtivmere = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaLovca);
            groupBox1.Location = new Point(24, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 370);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lovac";
            // 
            // listaLovca
            // 
            listaLovca.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listaLovca.Dock = DockStyle.Fill;
            listaLovca.FullRowSelect = true;
            listaLovca.GridLines = true;
            listaLovca.Location = new Point(3, 23);
            listaLovca.Name = "listaLovca";
            listaLovca.Size = new Size(254, 344);
            listaLovca.TabIndex = 4;
            listaLovca.UseCompatibleStateImageBehavior = false;
            listaLovca.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeniLovca);
            groupBox2.Controls.Add(btnObrisiLovca);
            groupBox2.Controls.Add(btnDodajLovca);
            groupBox2.Location = new Point(418, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 183);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // btnIzmeniLovca
            // 
            btnIzmeniLovca.AutoSize = true;
            btnIzmeniLovca.Location = new Point(40, 121);
            btnIzmeniLovca.Name = "btnIzmeniLovca";
            btnIzmeniLovca.Size = new Size(132, 43);
            btnIzmeniLovca.TabIndex = 3;
            btnIzmeniLovca.Text = "Izmeni Lovca";
            btnIzmeniLovca.UseVisualStyleBackColor = true;
            btnIzmeniLovca.Click += btnIzmeniLovca_Click;
            // 
            // btnObrisiLovca
            // 
            btnObrisiLovca.AutoSize = true;
            btnObrisiLovca.Location = new Point(40, 72);
            btnObrisiLovca.Name = "btnObrisiLovca";
            btnObrisiLovca.Size = new Size(132, 43);
            btnObrisiLovca.TabIndex = 2;
            btnObrisiLovca.Text = "Obrisi Lovca";
            btnObrisiLovca.UseVisualStyleBackColor = true;
            btnObrisiLovca.Click += btnObrisiLovca_Click;
            // 
            // btnDodajLovca
            // 
            btnDodajLovca.AutoSize = true;
            btnDodajLovca.Location = new Point(40, 23);
            btnDodajLovca.Name = "btnDodajLovca";
            btnDodajLovca.Size = new Size(132, 43);
            btnDodajLovca.TabIndex = 1;
            btnDodajLovca.Text = "Dodaj Lovca";
            btnDodajLovca.UseVisualStyleBackColor = true;
            btnDodajLovca.Click += btnDodajLovca_Click;
            // 
            // btnSusret
            // 
            btnSusret.AutoSize = true;
            btnSusret.Location = new Point(458, 223);
            btnSusret.Name = "btnSusret";
            btnSusret.Size = new Size(132, 43);
            btnSusret.TabIndex = 7;
            btnSusret.Text = "Susret";
            btnSusret.UseVisualStyleBackColor = true;
            btnSusret.Click += btnSusret_Click;
            // 
            // btnPredmet
            // 
            btnPredmet.AutoSize = true;
            btnPredmet.Location = new Point(458, 272);
            btnPredmet.Name = "btnPredmet";
            btnPredmet.Size = new Size(132, 43);
            btnPredmet.TabIndex = 8;
            btnPredmet.Text = "Predmet";
            btnPredmet.UseVisualStyleBackColor = true;
            btnPredmet.Click += btnPredmet_Click;
            // 
            // btnProtivmere
            // 
            btnProtivmere.AutoSize = true;
            btnProtivmere.Location = new Point(458, 321);
            btnProtivmere.Name = "btnProtivmere";
            btnProtivmere.Size = new Size(132, 43);
            btnProtivmere.TabIndex = 9;
            btnProtivmere.Text = "Protivmere";
            btnProtivmere.UseVisualStyleBackColor = true;
            btnProtivmere.Click += btnProtivmere_Click;
            // 
            // LovacForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 450);
            Controls.Add(btnProtivmere);
            Controls.Add(btnPredmet);
            Controls.Add(btnSusret);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LovacForm";
            Text = "LovacForm";
            Load += LovacForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaLovca;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox2;
        private Button btnIzmeniLovca;
        private Button btnObrisiLovca;
        private Button btnDodajLovca;
        private Button btnSusret;
        private Button btnPredmet;
        private Button btnProtivmere;
    }
}