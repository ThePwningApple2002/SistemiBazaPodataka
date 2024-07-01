namespace LovacNaCudovista.Forme
{
    partial class SpecSposAddForm
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
            txbNaziv = new TextBox();
            btnDodaj = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbNaziv);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Impact", 10.2F);
            groupBox1.Location = new Point(32, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 405);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o sposobnosti";
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new Point(213, 106);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new Size(125, 28);
            txbNaziv.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = SystemColors.ScrollBar;
            btnDodaj.Location = new Point(474, 323);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(203, 61);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 109);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "Naziv";
            // 
            // SpecSposAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(805, 468);
            Controls.Add(groupBox1);
            Name = "SpecSposAddForm";
            Text = "SpecSposAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbNaziv;
        private Button btnDodaj;
        private Label label1;
    }
}