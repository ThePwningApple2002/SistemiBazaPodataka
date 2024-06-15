namespace LovacNaCudovista.Forme
{
    partial class BajalicaForm
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
            listaBajalica = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeniBaj = new Button();
            btnObrisiBaj = new Button();
            btnDodajBaj = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaBajalica);
            groupBox1.Location = new Point(28, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 370);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bajalica";
            // 
            // listaBajalica
            // 
            listaBajalica.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listaBajalica.Dock = DockStyle.Fill;
            listaBajalica.FullRowSelect = true;
            listaBajalica.GridLines = true;
            listaBajalica.Location = new Point(3, 23);
            listaBajalica.Name = "listaBajalica";
            listaBajalica.Size = new Size(604, 344);
            listaBajalica.TabIndex = 4;
            listaBajalica.UseCompatibleStateImageBehavior = false;
            listaBajalica.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Zastita";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Prednost";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeniBaj);
            groupBox2.Controls.Add(btnObrisiBaj);
            groupBox2.Controls.Add(btnDodajBaj);
            groupBox2.Location = new Point(756, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 183);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnIzmeniBaj
            // 
            btnIzmeniBaj.AutoSize = true;
            btnIzmeniBaj.Location = new Point(40, 121);
            btnIzmeniBaj.Name = "btnIzmeniBaj";
            btnIzmeniBaj.Size = new Size(132, 43);
            btnIzmeniBaj.TabIndex = 3;
            btnIzmeniBaj.Text = "Izmeni Bajalicu";
            btnIzmeniBaj.UseVisualStyleBackColor = true;
            btnIzmeniBaj.Click += btnIzmeniBaj_Click;
            // 
            // btnObrisiBaj
            // 
            btnObrisiBaj.AutoSize = true;
            btnObrisiBaj.Location = new Point(40, 72);
            btnObrisiBaj.Name = "btnObrisiBaj";
            btnObrisiBaj.Size = new Size(132, 43);
            btnObrisiBaj.TabIndex = 2;
            btnObrisiBaj.Text = "Obrisi Bajalicu";
            btnObrisiBaj.UseVisualStyleBackColor = true;
            btnObrisiBaj.Click += btnObrisiBaj_Click;
            // 
            // btnDodajBaj
            // 
            btnDodajBaj.AutoSize = true;
            btnDodajBaj.Location = new Point(40, 23);
            btnDodajBaj.Name = "btnDodajBaj";
            btnDodajBaj.Size = new Size(132, 43);
            btnDodajBaj.TabIndex = 1;
            btnDodajBaj.Text = "Dodaj Bajalicu";
            btnDodajBaj.UseVisualStyleBackColor = true;
            btnDodajBaj.Click += btnDodajBaj_Click;
            // 
            // BajalicaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "BajalicaForm";
            Text = "BajalicaForm";
            Load += BajalicaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaBajalica;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox2;
        private Button btnIzmeniBaj;
        private Button btnObrisiBaj;
        private Button btnDodajBaj;
    }
}