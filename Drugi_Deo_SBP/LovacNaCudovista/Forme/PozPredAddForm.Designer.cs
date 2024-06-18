namespace LovacNaCudovista.Forme
{
    partial class PozPredAddForm
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
            btnDodaj = new Button();
            txbCudId = new TextBox();
            txbJedIme = new TextBox();
            txbStarost = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txbCudId);
            groupBox1.Controls.Add(txbJedIme);
            groupBox1.Controls.Add(txbStarost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 405);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o poznatom predstavniku";
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
            // txbCudId
            // 
            txbCudId.Location = new Point(552, 109);
            txbCudId.Name = "txbCudId";
            txbCudId.Size = new Size(125, 28);
            txbCudId.TabIndex = 6;
            // 
            // txbJedIme
            // 
            txbJedIme.Location = new Point(213, 103);
            txbJedIme.Name = "txbJedIme";
            txbJedIme.Size = new Size(125, 28);
            txbJedIme.TabIndex = 5;
            // 
            // txbStarost
            // 
            txbStarost.Location = new Point(213, 201);
            txbStarost.Name = "txbStarost";
            txbStarost.Size = new Size(125, 28);
            txbStarost.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 201);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 3;
            label4.Text = "Starost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 109);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 2;
            label3.Text = "Cudoviste Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 109);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Jedinstveno Ime";
            // 
            // PozPredAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(825, 485);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PozPredAddForm";
            Text = "PozPredAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDodaj;
        private TextBox txbCudId;
        private TextBox txbJedIme;
        private TextBox txbStarost;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}