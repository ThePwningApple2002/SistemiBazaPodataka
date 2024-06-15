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
            btnIzmeniLeg = new Button();
            btnObrisiLeg = new Button();
            btnDodajLeg = new Button();
            btnLokacijaLeg = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaLegenda);
            groupBox1.Location = new Point(28, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 370);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Legenda";
            // 
            // listaLegenda
            // 
            listaLegenda.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listaLegenda.Dock = DockStyle.Fill;
            listaLegenda.FullRowSelect = true;
            listaLegenda.GridLines = true;
            listaLegenda.Location = new Point(3, 23);
            listaLegenda.Name = "listaLegenda";
            listaLegenda.Size = new Size(605, 344);
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
            groupBox2.Controls.Add(btnIzmeniLeg);
            groupBox2.Controls.Add(btnObrisiLeg);
            groupBox2.Controls.Add(btnDodajLeg);
            groupBox2.Location = new Point(853, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 183);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnIzmeniLeg
            // 
            btnIzmeniLeg.AutoSize = true;
            btnIzmeniLeg.Location = new Point(40, 121);
            btnIzmeniLeg.Name = "btnIzmeniLeg";
            btnIzmeniLeg.Size = new Size(132, 43);
            btnIzmeniLeg.TabIndex = 3;
            btnIzmeniLeg.Text = "Izmeni Legendu";
            btnIzmeniLeg.UseVisualStyleBackColor = true;
            btnIzmeniLeg.Click += btnIzmeniLeg_Click;
            // 
            // btnObrisiLeg
            // 
            btnObrisiLeg.AutoSize = true;
            btnObrisiLeg.Location = new Point(40, 72);
            btnObrisiLeg.Name = "btnObrisiLeg";
            btnObrisiLeg.Size = new Size(132, 43);
            btnObrisiLeg.TabIndex = 2;
            btnObrisiLeg.Text = "Obrisi Legendu";
            btnObrisiLeg.UseVisualStyleBackColor = true;
            btnObrisiLeg.Click += btnObrisiLeg_Click;
            // 
            // btnDodajLeg
            // 
            btnDodajLeg.AutoSize = true;
            btnDodajLeg.Location = new Point(40, 23);
            btnDodajLeg.Name = "btnDodajLeg";
            btnDodajLeg.Size = new Size(132, 43);
            btnDodajLeg.TabIndex = 1;
            btnDodajLeg.Text = "Dodaj Legendu";
            btnDodajLeg.UseVisualStyleBackColor = true;
            btnDodajLeg.Click += btnDodajLeg_Click;
            // 
            // btnLokacijaLeg
            // 
            btnLokacijaLeg.AutoSize = true;
            btnLokacijaLeg.Location = new Point(893, 243);
            btnLokacijaLeg.Name = "btnLokacijaLeg";
            btnLokacijaLeg.Size = new Size(134, 43);
            btnLokacijaLeg.TabIndex = 4;
            btnLokacijaLeg.Text = "Lokacija Legende";
            btnLokacijaLeg.UseVisualStyleBackColor = true;
            btnLokacijaLeg.Click += btnLokacijaLeg_Click;
            // 
            // LegendaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 494);
            Controls.Add(btnLokacijaLeg);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LegendaForm";
            Text = "LegendaForm";
            Load += LegendaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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