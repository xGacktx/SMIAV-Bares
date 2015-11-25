namespace Smiav_Bares_1._0
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AdminButton = new System.Windows.Forms.Button();
            this.garzonButton = new System.Windows.Forms.Button();
            this.bartenderButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Location = new System.Drawing.Point(267, 35);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(145, 44);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Administrador";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // garzonButton
            // 
            this.garzonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garzonButton.Location = new System.Drawing.Point(267, 82);
            this.garzonButton.Name = "garzonButton";
            this.garzonButton.Size = new System.Drawing.Size(145, 44);
            this.garzonButton.TabIndex = 1;
            this.garzonButton.Text = "Garzón";
            this.garzonButton.UseVisualStyleBackColor = true;
            this.garzonButton.Click += new System.EventHandler(this.garzonButton_Click);
            // 
            // bartenderButton
            // 
            this.bartenderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bartenderButton.Location = new System.Drawing.Point(267, 132);
            this.bartenderButton.Name = "bartenderButton";
            this.bartenderButton.Size = new System.Drawing.Size(145, 44);
            this.bartenderButton.TabIndex = 2;
            this.bartenderButton.Text = "Bartender";
            this.bartenderButton.UseVisualStyleBackColor = true;
            this.bartenderButton.Click += new System.EventHandler(this.bartenderButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(267, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cajera";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::Smiav_Bares_1._0.Properties.Resources.New_City_bar;
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.MinimumSize = new System.Drawing.Size(150, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 150);
            this.label1.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bartenderButton);
            this.Controls.Add(this.garzonButton);
            this.Controls.Add(this.AdminButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMIAV Bares 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button garzonButton;
        private System.Windows.Forms.Button bartenderButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}