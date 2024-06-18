namespace LovacNaCudovista.Forme
{
    partial class ZastitaForm
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
            listaZastita = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeniZastitu = new Button();
            btnObrisiZastitu = new Button();
            btnDodajZastitu = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaZastita);
            groupBox1.Location = new Point(26, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 379);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zastita";
            // 
            // listaZastita
            // 
            listaZastita.BackColor = SystemColors.ScrollBar;
            listaZastita.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listaZastita.Dock = DockStyle.Fill;
            listaZastita.FullRowSelect = true;
            listaZastita.GridLines = true;
            listaZastita.Location = new Point(3, 24);
            listaZastita.Name = "listaZastita";
            listaZastita.Size = new Size(404, 352);
            listaZastita.TabIndex = 4;
            listaZastita.UseCompatibleStateImageBehavior = false;
            listaZastita.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID Zastite";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tip Zastite";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Naziv Zastite";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeniZastitu);
            groupBox2.Controls.Add(btnObrisiZastitu);
            groupBox2.Controls.Add(btnDodajZastitu);
            groupBox2.Location = new Point(669, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 192);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // btnIzmeniZastitu
            // 
            btnIzmeniZastitu.AutoSize = true;
            btnIzmeniZastitu.BackColor = SystemColors.ScrollBar;
            btnIzmeniZastitu.Location = new Point(31, 127);
            btnIzmeniZastitu.Name = "btnIzmeniZastitu";
            btnIzmeniZastitu.Size = new Size(150, 45);
            btnIzmeniZastitu.TabIndex = 3;
            btnIzmeniZastitu.Text = "Izmeni Zastitu";
            btnIzmeniZastitu.UseVisualStyleBackColor = false;
            btnIzmeniZastitu.Click += btnIzmeniZastitu_Click;
            // 
            // btnObrisiZastitu
            // 
            btnObrisiZastitu.AutoSize = true;
            btnObrisiZastitu.BackColor = SystemColors.ScrollBar;
            btnObrisiZastitu.Location = new Point(31, 76);
            btnObrisiZastitu.Name = "btnObrisiZastitu";
            btnObrisiZastitu.Size = new Size(150, 45);
            btnObrisiZastitu.TabIndex = 2;
            btnObrisiZastitu.Text = "Obrisi Zastitu";
            btnObrisiZastitu.UseVisualStyleBackColor = false;
            btnObrisiZastitu.Click += btnObrisiZastitu_Click;
            // 
            // btnDodajZastitu
            // 
            btnDodajZastitu.AutoSize = true;
            btnDodajZastitu.BackColor = SystemColors.ScrollBar;
            btnDodajZastitu.Location = new Point(31, 24);
            btnDodajZastitu.Name = "btnDodajZastitu";
            btnDodajZastitu.Size = new Size(150, 45);
            btnDodajZastitu.TabIndex = 1;
            btnDodajZastitu.Text = "Dodaj Zastitu";
            btnDodajZastitu.UseVisualStyleBackColor = false;
            btnDodajZastitu.Click += btnDodajZastitu_Click;
            // 
            // ZastitaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(906, 472);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F);
            Name = "ZastitaForm";
            Text = "ZastitaForm";
            Load += ZastitaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaZastita;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox2;
        private Button btnIzmeniZastitu;
        private Button btnObrisiZastitu;
        private Button btnDodajZastitu;
    }
}