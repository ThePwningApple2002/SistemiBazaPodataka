namespace LovacNaCudovista.Forme
{
    partial class ZastitaUpdateForm
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
            txbNazivZastite = new TextBox();
            txbTipZastite = new TextBox();
            btnAzuriraj = new Button();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbNazivZastite);
            groupBox1.Controls.Add(txbTipZastite);
            groupBox1.Controls.Add(btnAzuriraj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 405);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o zastiti";
            // 
            // txbNazivZastite
            // 
            txbNazivZastite.Location = new Point(474, 106);
            txbNazivZastite.Name = "txbNazivZastite";
            txbNazivZastite.Size = new Size(203, 28);
            txbNazivZastite.TabIndex = 9;
            // 
            // txbTipZastite
            // 
            txbTipZastite.Location = new Point(213, 109);
            txbTipZastite.Name = "txbTipZastite";
            txbTipZastite.Size = new Size(125, 28);
            txbTipZastite.TabIndex = 8;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = SystemColors.ScrollBar;
            btnAzuriraj.Location = new Point(474, 323);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(203, 61);
            btnAzuriraj.TabIndex = 7;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 109);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 2;
            label3.Text = "Naziv zastite";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 109);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Tip zastite";
            // 
            // ZastitaUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 472);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 10.2F);
            Name = "ZastitaUpdateForm";
            Text = "ZastitaUpdateForm";
            Load += ZastitaUpdateForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbNazivZastite;
        private TextBox txbTipZastite;
        private Button btnAzuriraj;
        private Label label3;
        private Label label1;
    }
}