namespace LovacNaCudovista.Forme
{
    partial class PoznatiPredstavnikForm
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
            listaPozPredstavnik = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeniPozPred = new Button();
            btnObrisiPozPred = new Button();
            btnDodajPozPred = new Button();
            btnLegenda = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaPozPredstavnik);
            groupBox1.Location = new Point(33, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 379);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Poznati Predstavnik";
            // 
            // listaPozPredstavnik
            // 
            listaPozPredstavnik.BackColor = SystemColors.ScrollBar;
            listaPozPredstavnik.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listaPozPredstavnik.Dock = DockStyle.Fill;
            listaPozPredstavnik.FullRowSelect = true;
            listaPozPredstavnik.GridLines = true;
            listaPozPredstavnik.Location = new Point(3, 24);
            listaPozPredstavnik.Name = "listaPozPredstavnik";
            listaPozPredstavnik.Size = new Size(554, 352);
            listaPozPredstavnik.TabIndex = 4;
            listaPozPredstavnik.UseCompatibleStateImageBehavior = false;
            listaPozPredstavnik.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Jedinstveno Ime";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Starost";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Id Cudovista";
            columnHeader4.Width = 100;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeniPozPred);
            groupBox2.Controls.Add(btnObrisiPozPred);
            groupBox2.Controls.Add(btnDodajPozPred);
            groupBox2.Location = new Point(768, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(209, 192);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnIzmeniPozPred
            // 
            btnIzmeniPozPred.AutoSize = true;
            btnIzmeniPozPred.BackColor = SystemColors.ScrollBar;
            btnIzmeniPozPred.Location = new Point(25, 127);
            btnIzmeniPozPred.Name = "btnIzmeniPozPred";
            btnIzmeniPozPred.Size = new Size(163, 45);
            btnIzmeniPozPred.TabIndex = 3;
            btnIzmeniPozPred.Text = "Izmeni Predstavnika";
            btnIzmeniPozPred.UseVisualStyleBackColor = false;
            btnIzmeniPozPred.Click += btnIzmeniPozPred_Click;
            // 
            // btnObrisiPozPred
            // 
            btnObrisiPozPred.AutoSize = true;
            btnObrisiPozPred.BackColor = SystemColors.ScrollBar;
            btnObrisiPozPred.Location = new Point(25, 76);
            btnObrisiPozPred.Name = "btnObrisiPozPred";
            btnObrisiPozPred.Size = new Size(158, 45);
            btnObrisiPozPred.TabIndex = 2;
            btnObrisiPozPred.Text = "Obrisi Predstavnika";
            btnObrisiPozPred.UseVisualStyleBackColor = false;
            btnObrisiPozPred.Click += btnObrisiPozPred_Click;
            // 
            // btnDodajPozPred
            // 
            btnDodajPozPred.AutoSize = true;
            btnDodajPozPred.BackColor = SystemColors.ScrollBar;
            btnDodajPozPred.Location = new Point(25, 24);
            btnDodajPozPred.Name = "btnDodajPozPred";
            btnDodajPozPred.Size = new Size(157, 45);
            btnDodajPozPred.TabIndex = 1;
            btnDodajPozPred.Text = "Dodaj Predstavnika";
            btnDodajPozPred.UseVisualStyleBackColor = false;
            btnDodajPozPred.Click += btnDodajPozPred_Click;
            // 
            // btnLegenda
            // 
            btnLegenda.AutoSize = true;
            btnLegenda.BackColor = SystemColors.ScrollBar;
            btnLegenda.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLegenda.Location = new Point(793, 245);
            btnLegenda.Name = "btnLegenda";
            btnLegenda.Size = new Size(163, 45);
            btnLegenda.TabIndex = 4;
            btnLegenda.Text = "Legenda";
            btnLegenda.UseVisualStyleBackColor = false;
            btnLegenda.Click += btnLegenda_Click;
            // 
            // PoznatiPredstavnikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1023, 472);
            Controls.Add(btnLegenda);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PoznatiPredstavnikForm";
            Text = "PoznatiPredstavnikForm";
            Load += PoznatiPredstavnikForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaPozPredstavnik;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox2;
        private Button btnIzmeniPozPred;
        private Button btnObrisiPozPred;
        private Button btnDodajPozPred;
        private Button btnLegenda;
    }
}