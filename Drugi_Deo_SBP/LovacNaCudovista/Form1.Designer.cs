namespace LovacNaCudovista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLovac = new Button();
            btnCud = new Button();
            btnNeMagCud = new Button();
            SuspendLayout();
            // 
            // btnLovac
            // 
            btnLovac.Location = new Point(467, 214);
            btnLovac.Margin = new Padding(3, 4, 3, 4);
            btnLovac.Name = "btnLovac";
            btnLovac.Size = new Size(86, 69);
            btnLovac.TabIndex = 0;
            btnLovac.Text = "Lovac";
            btnLovac.UseVisualStyleBackColor = true;
            btnLovac.Click += btnLovac_Click;
            // 
            // btnCud
            // 
            btnCud.Location = new Point(407, 320);
            btnCud.Margin = new Padding(3, 4, 3, 4);
            btnCud.Name = "btnCud";
            btnCud.Size = new Size(195, 67);
            btnCud.TabIndex = 1;
            btnCud.Text = "Cudovista";
            btnCud.UseVisualStyleBackColor = true;
            btnCud.Click += btnCud_Click;
            // 
            // btnNeMagCud
            // 
            btnNeMagCud.Location = new Point(407, 432);
            btnNeMagCud.Margin = new Padding(3, 4, 3, 4);
            btnNeMagCud.Name = "btnNeMagCud";
            btnNeMagCud.Size = new Size(195, 66);
            btnNeMagCud.TabIndex = 2;
            btnNeMagCud.Text = "idk jebem ti mater";
            btnNeMagCud.UseVisualStyleBackColor = true;
            btnNeMagCud.Click += btnNeMagCud_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnNeMagCud);
            Controls.Add(btnCud);
            Controls.Add(btnLovac);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLovac;
        private Button btnCud;
        private Button btnNeMagCud;
    }
}
