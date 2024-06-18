namespace LovacNaCudovista.Forme
{
    partial class LegendaForm
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
            listaLegenda = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnLokacijaLeg = new Button();
            btnIzmeniLeg = new Button();
            btnObrisiLeg = new Button();
            btnDodajLeg = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaLegenda);
            groupBox1.Location = new Point(28, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 388);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Legenda";
            // 
            // listaLegenda
            // 
            listaLegenda.BackColor = SystemColors.ScrollBar;
            listaLegenda.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listaLegenda.Dock = DockStyle.Fill;
            listaLegenda.FullRowSelect = true;
            listaLegenda.GridLines = true;
            listaLegenda.Location = new Point(3, 24);
            listaLegenda.Name = "listaLegenda";
            listaLegenda.Size = new Size(605, 361);
            listaLegenda.TabIndex = 4;
            listaLegenda.UseCompatibleStateImageBehavior = false;
            listaLegenda.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Prvo pominjanje";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tekst";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Zemlja Porekla";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLokacijaLeg);
            groupBox2.Controls.Add(btnIzmeniLeg);
            groupBox2.Controls.Add(btnObrisiLeg);
            groupBox2.Controls.Add(btnDodajLeg);
            groupBox2.Location = new Point(736, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 244);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnLokacijaLeg
            // 
            btnLokacijaLeg.AutoSize = true;
            btnLokacijaLeg.BackColor = SystemColors.ScrollBar;
            btnLokacijaLeg.Location = new Point(40, 178);
            btnLokacijaLeg.Name = "btnLokacijaLeg";
            btnLokacijaLeg.Size = new Size(142, 45);
            btnLokacijaLeg.TabIndex = 4;
            btnLokacijaLeg.Text = "Lokacija Legende";
            btnLokacijaLeg.UseVisualStyleBackColor = false;
            btnLokacijaLeg.Click += btnLokacijaLeg_Click;
            // 
            // btnIzmeniLeg
            // 
            btnIzmeniLeg.AutoSize = true;
            btnIzmeniLeg.BackColor = SystemColors.ScrollBar;
            btnIzmeniLeg.Location = new Point(40, 127);
            btnIzmeniLeg.Name = "btnIzmeniLeg";
            btnIzmeniLeg.Size = new Size(142, 45);
            btnIzmeniLeg.TabIndex = 3;
            btnIzmeniLeg.Text = "Izmeni Legendu";
            btnIzmeniLeg.UseVisualStyleBackColor = false;
            btnIzmeniLeg.Click += btnIzmeniLeg_Click;
            // 
            // btnObrisiLeg
            // 
            btnObrisiLeg.AutoSize = true;
            btnObrisiLeg.BackColor = SystemColors.ScrollBar;
            btnObrisiLeg.Location = new Point(40, 76);
            btnObrisiLeg.Name = "btnObrisiLeg";
            btnObrisiLeg.Size = new Size(142, 45);
            btnObrisiLeg.TabIndex = 2;
            btnObrisiLeg.Text = "Obrisi Legendu";
            btnObrisiLeg.UseVisualStyleBackColor = false;
            btnObrisiLeg.Click += btnObrisiLeg_Click;
            // 
            // btnDodajLeg
            // 
            btnDodajLeg.AutoSize = true;
            btnDodajLeg.BackColor = SystemColors.ScrollBar;
            btnDodajLeg.Location = new Point(40, 24);
            btnDodajLeg.Name = "btnDodajLeg";
            btnDodajLeg.Size = new Size(142, 45);
            btnDodajLeg.TabIndex = 1;
            btnDodajLeg.Text = "Dodaj Legendu";
            btnDodajLeg.UseVisualStyleBackColor = false;
            btnDodajLeg.Click += btnDodajLeg_Click;
            // 
            // LegendaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(983, 519);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LegendaForm";
            Text = "LegendaForm";
            Load += LegendaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaLegenda;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox2;
        private Button btnIzmeniLeg;
        private Button btnObrisiLeg;
        private Button btnDodajLeg;
        private Button btnLokacijaLeg;
    }
}