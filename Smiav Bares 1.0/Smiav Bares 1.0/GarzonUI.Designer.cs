namespace Smiav_Bares_1._0
{
    partial class GarzonUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarzonUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMesa = new System.Windows.Forms.Label();
            this.labelMesaNum = new System.Windows.Forms.Label();
            this.labelGarzonNom = new System.Windows.Forms.Label();
            this.labelGarzon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelGarzonNom);
            this.panel1.Controls.Add(this.labelGarzon);
            this.panel1.Controls.Add(this.labelMesaNum);
            this.panel1.Controls.Add(this.labelMesa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 706);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(421, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 706);
            this.panel2.TabIndex = 1;
            // 
            // labelMesa
            // 
            this.labelMesa.AutoSize = true;
            this.labelMesa.Location = new System.Drawing.Point(28, 15);
            this.labelMesa.Name = "labelMesa";
            this.labelMesa.Size = new System.Drawing.Size(54, 13);
            this.labelMesa.TabIndex = 0;
            this.labelMesa.Text = "Mesa Nº: ";
            // 
            // labelMesaNum
            // 
            this.labelMesaNum.AutoSize = true;
            this.labelMesaNum.Location = new System.Drawing.Point(88, 15);
            this.labelMesaNum.Name = "labelMesaNum";
            this.labelMesaNum.Size = new System.Drawing.Size(32, 13);
            this.labelMesaNum.TabIndex = 1;
            this.labelMesaNum.Text = "NUM";
            // 
            // labelGarzonNom
            // 
            this.labelGarzonNom.AutoSize = true;
            this.labelGarzonNom.Location = new System.Drawing.Point(265, 15);
            this.labelGarzonNom.Name = "labelGarzonNom";
            this.labelGarzonNom.Size = new System.Drawing.Size(78, 13);
            this.labelGarzonNom.TabIndex = 3;
            this.labelGarzonNom.Text = "NOMGARZON";
            // 
            // labelGarzon
            // 
            this.labelGarzon.AutoSize = true;
            this.labelGarzon.Location = new System.Drawing.Point(205, 15);
            this.labelGarzon.Name = "labelGarzon";
            this.labelGarzon.Size = new System.Drawing.Size(47, 13);
            this.labelGarzon.TabIndex = 2;
            this.labelGarzon.Text = "Garzon :";
            // 
            // GarzonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GarzonUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMIAV Bares 1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGarzonNom;
        private System.Windows.Forms.Label labelGarzon;
        private System.Windows.Forms.Label labelMesaNum;
        private System.Windows.Forms.Label labelMesa;
        private System.Windows.Forms.Panel panel2;
    }
}