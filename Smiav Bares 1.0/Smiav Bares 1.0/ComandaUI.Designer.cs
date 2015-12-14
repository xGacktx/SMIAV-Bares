namespace Smiav_Bares_1._0
{
    partial class ComandaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComandaUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProductoComanda = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelGarzonNom = new System.Windows.Forms.Label();
            this.labelGarzon = new System.Windows.Forms.Label();
            this.labelMesaNum = new System.Windows.Forms.Label();
            this.labelMesa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCategorias = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProductoComanda);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelGarzonNom);
            this.panel1.Controls.Add(this.labelGarzon);
            this.panel1.Controls.Add(this.labelMesaNum);
            this.panel1.Controls.Add(this.labelMesa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 730);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelProductoComanda
            // 
            this.labelProductoComanda.AutoSize = true;
            this.labelProductoComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelProductoComanda.Location = new System.Drawing.Point(26, 12);
            this.labelProductoComanda.Name = "labelProductoComanda";
            this.labelProductoComanda.Size = new System.Drawing.Size(335, 31);
            this.labelProductoComanda.TabIndex = 7;
            this.labelProductoComanda.Text = "PRODUCTOS COMANDA";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 607);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 447);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelGarzonNom
            // 
            this.labelGarzonNom.AutoSize = true;
            this.labelGarzonNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelGarzonNom.Location = new System.Drawing.Point(265, 64);
            this.labelGarzonNom.Name = "labelGarzonNom";
            this.labelGarzonNom.Size = new System.Drawing.Size(100, 17);
            this.labelGarzonNom.TabIndex = 3;
            this.labelGarzonNom.Text = "NOMGARZON";
            this.labelGarzonNom.Click += new System.EventHandler(this.labelGarzonNom_Click);
            // 
            // labelGarzon
            // 
            this.labelGarzon.AutoSize = true;
            this.labelGarzon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelGarzon.Location = new System.Drawing.Point(196, 64);
            this.labelGarzon.Name = "labelGarzon";
            this.labelGarzon.Size = new System.Drawing.Size(63, 17);
            this.labelGarzon.TabIndex = 2;
            this.labelGarzon.Text = "Garzon :";
            this.labelGarzon.Click += new System.EventHandler(this.labelGarzon_Click);
            // 
            // labelMesaNum
            // 
            this.labelMesaNum.AutoSize = true;
            this.labelMesaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelMesaNum.Location = new System.Drawing.Point(92, 64);
            this.labelMesaNum.Name = "labelMesaNum";
            this.labelMesaNum.Size = new System.Drawing.Size(39, 17);
            this.labelMesaNum.TabIndex = 1;
            this.labelMesaNum.Text = "NUM";
            this.labelMesaNum.Click += new System.EventHandler(this.labelMesaNum_Click);
            // 
            // labelMesa
            // 
            this.labelMesa.AutoSize = true;
            this.labelMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelMesa.Location = new System.Drawing.Point(17, 64);
            this.labelMesa.Name = "labelMesa";
            this.labelMesa.Size = new System.Drawing.Size(69, 17);
            this.labelMesa.TabIndex = 0;
            this.labelMesa.Text = "Mesa Nº: ";
            this.labelMesa.Click += new System.EventHandler(this.labelMesa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCategorias);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(421, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 706);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelCategorias.Location = new System.Drawing.Point(365, 33);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(193, 31);
            this.labelCategorias.TabIndex = 7;
            this.labelCategorias.Text = "CATEGORIAS";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(40, 436);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 119);
            this.button11.TabIndex = 17;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(262, 436);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(172, 119);
            this.button12.TabIndex = 16;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(484, 436);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(172, 119);
            this.button13.TabIndex = 15;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(706, 436);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(172, 119);
            this.button14.TabIndex = 14;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(40, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 119);
            this.button7.TabIndex = 13;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(262, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 119);
            this.button8.TabIndex = 12;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(484, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 119);
            this.button9.TabIndex = 11;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(706, 272);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(172, 119);
            this.button10.TabIndex = 10;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(484, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 119);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(706, 108);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 119);
            this.button6.TabIndex = 8;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 119);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(40, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 119);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cervezas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ComandaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComandaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMIAV Bares 1.0";
            this.Load += new System.EventHandler(this.ComandaUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGarzonNom;
        private System.Windows.Forms.Label labelGarzon;
        private System.Windows.Forms.Label labelMesaNum;
        private System.Windows.Forms.Label labelMesa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.Label labelProductoComanda;
    }
}