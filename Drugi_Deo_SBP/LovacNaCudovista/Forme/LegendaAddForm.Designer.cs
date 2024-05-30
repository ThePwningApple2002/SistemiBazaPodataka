namespace LovacNaCudovista.Forme
{
    partial class LegendaAddForm
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
            txbText = new TextBox();
            txbPrvoPom = new TextBox();
            btnDodaj = new Button();
            txbZemljaPorekla = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbText);
            groupBox1.Controls.Add(txbPrvoPom);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txbZemljaPorekla);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 386);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o legendi";
            // 
            // txbText
            // 
            txbText.Location = new Point(474, 104);
            txbText.Name = "txbText";
            txbText.Size = new Size(203, 27);
            txbText.TabIndex = 9;
            // 
            // txbPrvoPom
            // 
            txbPrvoPom.Location = new Point(213, 104);
            txbPrvoPom.Name = "txbPrvoPom";
            txbPrvoPom.Size = new Size(125, 27);
            txbPrvoPom.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(474, 308);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(203, 58);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txbZemljaPorekla
            // 
            txbZemljaPorekla.Location = new Point(213, 191);
            txbZemljaPorekla.Name = "txbZemljaPorekla";
            txbZemljaPorekla.Size = new Size(125, 27);
            txbZemljaPorekla.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 191);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Zemlja porekla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 104);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Tekst";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 104);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Prvo pominjanje";
            // 
            // LegendaAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "LegendaAddForm";
            Text = "LegendaAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbText;
        private TextBox txbPrvoPom;
        private Button btnDodaj;
        private TextBox txbZemljaPorekla;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}