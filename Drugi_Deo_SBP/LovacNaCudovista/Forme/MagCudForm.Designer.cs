namespace LovacNaCudovista.Forme
{
    partial class MagCudForm
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
            listaCudovista = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
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
            groupBox1.Controls.Add(listaCudovista);
            groupBox1.Location = new Point(34, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 370);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Magicna Cudovista";
            // 
            // listaCudovista
            // 
            listaCudovista.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listaCudovista.Dock = DockStyle.Fill;
            listaCudovista.FullRowSelect = true;
            listaCudovista.GridLines = true;
            listaCudovista.Location = new Point(3, 23);
            listaCudovista.Name = "listaCudovista";
            listaCudovista.Size = new Size(604, 344);
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
            columnHeader5.Text = "Postojanje";
            columnHeader5.Width = 120;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeniCud);
            groupBox2.Controls.Add(btnObrisiCud);
            groupBox2.Controls.Add(btnDodajCud);
            groupBox2.Location = new Point(727, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 183);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci o Cudovistu";
            // 
            // btnIzmeniCud
            // 
            btnIzmeniCud.AutoSize = true;
            btnIzmeniCud.Location = new Point(40, 121);
            btnIzmeniCud.Name = "btnIzmeniCud";
            btnIzmeniCud.Size = new Size(132, 43);
            btnIzmeniCud.TabIndex = 3;
            btnIzmeniCud.Text = "Izmeni Cudoviste";
            btnIzmeniCud.UseVisualStyleBackColor = true;
            btnIzmeniCud.Click += btnIzmeniCud_Click;
            // 
            // btnObrisiCud
            // 
            btnObrisiCud.AutoSize = true;
            btnObrisiCud.Location = new Point(40, 72);
            btnObrisiCud.Name = "btnObrisiCud";
            btnObrisiCud.Size = new Size(132, 43);
            btnObrisiCud.TabIndex = 2;
            btnObrisiCud.Text = "Obrisi Cudoviste";
            btnObrisiCud.UseVisualStyleBackColor = true;
            btnObrisiCud.Click += btnObrisiCud_Click;
            // 
            // btnDodajCud
            // 
            btnDodajCud.AutoSize = true;
            btnDodajCud.Location = new Point(40, 23);
            btnDodajCud.Name = "btnDodajCud";
            btnDodajCud.Size = new Size(132, 43);
            btnDodajCud.TabIndex = 1;
            btnDodajCud.Text = "Dodaj Cudovista";
            btnDodajCud.UseVisualStyleBackColor = true;
            btnDodajCud.Click += btnDodajCud_Click;
            // 
            // MagCudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 520);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MagCudForm";
            Text = "MagCudForm";
            Load += MagCudForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listaCudovista;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox2;
        private Button btnIzmeniCud;
        private Button btnObrisiCud;
        private Button btnDodajCud;
        private ColumnHeader columnHeader5;
    }
}