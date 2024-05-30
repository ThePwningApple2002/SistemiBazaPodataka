namespace LovacNaCudovista.Forme
{
    partial class LokacijaForm
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
            listaLokacija = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeniCud = new Button();
            btnObrisiCud = new Button();
            btnDodajCud = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaLokacija);
            groupBox1.Location = new Point(33, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 370);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lokacija";
            // 
            // listaLokacija
            // 
            listaLokacija.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listaLokacija.Dock = DockStyle.Fill;
            listaLokacija.FullRowSelect = true;
            listaLokacija.GridLines = true;
            listaLokacija.Location = new Point(3, 23);
            listaLokacija.Name = "listaLokacija";
            listaLokacija.Size = new Size(655, 344);
            listaLokacija.TabIndex = 4;
            listaLokacija.UseCompatibleStateImageBehavior = false;
            listaLokacija.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tip";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Naziv";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Zemlja ";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Blago";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Id Legende";
            columnHeader6.Width = 100;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeniCud);
            groupBox2.Controls.Add(btnObrisiCud);
            groupBox2.Controls.Add(btnDodajCud);
            groupBox2.Location = new Point(817, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 183);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnIzmeniCud
            // 
            btnIzmeniCud.AutoSize = true;
            btnIzmeniCud.Location = new Point(40, 121);
            btnIzmeniCud.Name = "btnIzmeniCud";
            btnIzmeniCud.Size = new Size(132, 43);
            btnIzmeniCud.TabIndex = 3;
            btnIzmeniCud.Text = "Izmeni Lokaciju";
            btnIzmeniCud.UseVisualStyleBackColor = true;
            // 
            // btnObrisiCud
            // 
            btnObrisiCud.AutoSize = true;
            btnObrisiCud.Location = new Point(40, 72);
            btnObrisiCud.Name = "btnObrisiCud";
            btnObrisiCud.Size = new Size(132, 43);
            btnObrisiCud.TabIndex = 2;
            btnObrisiCud.Text = "Obrisi Lokaciju";
            btnObrisiCud.UseVisualStyleBackColor = true;
            // 
            // btnDodajCud
            // 
            btnDodajCud.AutoSize = true;
            btnDodajCud.Location = new Point(40, 23);
            btnDodajCud.Name = "btnDodajCud";
            btnDodajCud.Size = new Size(132, 43);
            btnDodajCud.TabIndex = 1;
            btnDodajCud.Text = "Dodaj Lokaciju";
            btnDodajCud.UseVisualStyleBackColor = true;
            // 
            // LokacijaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LokacijaForm";
            Text = "LokacijaForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaLokacija;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox2;
        private Button btnIzmeniCud;
        private Button btnObrisiCud;
        private Button btnDodajCud;
    }
}