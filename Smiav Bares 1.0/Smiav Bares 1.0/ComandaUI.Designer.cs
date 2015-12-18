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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNombreGarzon = new System.Windows.Forms.Label();
            this.labelGarzon = new System.Windows.Forms.Label();
            this.labelNumMesa = new System.Windows.Forms.Label();
            this.labelMesa = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.panelCategoria = new System.Windows.Forms.Panel();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.panelCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.labelProductoComanda);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.buttonIngresar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelNombreGarzon);
            this.panel1.Controls.Add(this.labelGarzon);
            this.panel1.Controls.Add(this.labelNumMesa);
            this.panel1.Controls.Add(this.labelMesa);
            this.panel1.Controls.Add(this.panelProductos);
            this.panel1.Controls.Add(this.panelCategoria);
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
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.Location = new System.Drawing.Point(215, 607);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(150, 65);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonIngresar.Location = new System.Drawing.Point(20, 607);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(150, 65);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "INGRESAR";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(20, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 447);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelNombreGarzon
            // 
            this.labelNombreGarzon.AutoSize = true;
            this.labelNombreGarzon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNombreGarzon.Location = new System.Drawing.Point(265, 64);
            this.labelNombreGarzon.Name = "labelNombreGarzon";
            this.labelNombreGarzon.Size = new System.Drawing.Size(100, 17);
            this.labelNombreGarzon.TabIndex = 3;
            this.labelNombreGarzon.Text = "NOMGARZON";
            this.labelNombreGarzon.Click += new System.EventHandler(this.labelGarzonNom_Click);
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
            // labelNumMesa
            // 
            this.labelNumMesa.AutoSize = true;
            this.labelNumMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNumMesa.Location = new System.Drawing.Point(92, 64);
            this.labelNumMesa.Name = "labelNumMesa";
            this.labelNumMesa.Size = new System.Drawing.Size(39, 17);
            this.labelNumMesa.TabIndex = 1;
            this.labelNumMesa.Text = "NUM";
            this.labelNumMesa.Click += new System.EventHandler(this.labelMesaNum_Click);
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
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.button1);
            this.panelProductos.Controls.Add(this.label1);
            this.panelProductos.Controls.Add(this.textBox1);
            this.panelProductos.Controls.Add(this.buttonAgregar);
            this.panelProductos.Controls.Add(this.labelCategoria);
            this.panelProductos.Controls.Add(this.dgProductos);
            this.panelProductos.Location = new System.Drawing.Point(412, 3);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(926, 724);
            this.panelProductos.TabIndex = 18;
            this.panelProductos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(679, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "CANTIDAD:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(783, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "1";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(706, 176);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(128, 51);
            this.buttonAgregar.TabIndex = 8;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelCategoria.Location = new System.Drawing.Point(276, 37);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(189, 31);
            this.labelCategoria.TabIndex = 6;
            this.labelCategoria.Text = "PRODUCTOS";
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(80, 105);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgProductos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgProductos.RowTemplate.Height = 50;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(563, 447);
            this.dgProductos.TabIndex = 5;
            // 
            // panelCategoria
            // 
            this.panelCategoria.Controls.Add(this.labelCategorias);
            this.panelCategoria.Controls.Add(this.button11);
            this.panelCategoria.Controls.Add(this.button12);
            this.panelCategoria.Controls.Add(this.button13);
            this.panelCategoria.Controls.Add(this.button14);
            this.panelCategoria.Controls.Add(this.button7);
            this.panelCategoria.Controls.Add(this.button8);
            this.panelCategoria.Controls.Add(this.button9);
            this.panelCategoria.Controls.Add(this.button10);
            this.panelCategoria.Controls.Add(this.button5);
            this.panelCategoria.Controls.Add(this.button6);
            this.panelCategoria.Controls.Add(this.button4);
            this.panelCategoria.Controls.Add(this.button3);
            this.panelCategoria.Location = new System.Drawing.Point(412, 3);
            this.panelCategoria.Name = "panelCategoria";
            this.panelCategoria.Size = new System.Drawing.Size(917, 706);
            this.panelCategoria.TabIndex = 1;
            this.panelCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button11.Location = new System.Drawing.Point(40, 436);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 119);
            this.button11.TabIndex = 17;
            this.button11.Text = "BEBIDA";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button12.Location = new System.Drawing.Point(262, 436);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(172, 119);
            this.button12.TabIndex = 16;
            this.button12.Text = "JUGO";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button13.Location = new System.Drawing.Point(484, 436);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(172, 119);
            this.button13.TabIndex = 15;
            this.button13.Text = "COÑAC";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button14.Location = new System.Drawing.Point(706, 436);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(172, 119);
            this.button14.TabIndex = 14;
            this.button14.Text = "CACHAZA";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button7.Location = new System.Drawing.Point(40, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 119);
            this.button7.TabIndex = 13;
            this.button7.Text = "TEQUILA";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button8.Location = new System.Drawing.Point(262, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 119);
            this.button8.TabIndex = 12;
            this.button8.Text = "WHISKY";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button9.Location = new System.Drawing.Point(484, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 119);
            this.button9.TabIndex = 11;
            this.button9.Text = "VINO";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(706, 272);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(172, 119);
            this.button10.TabIndex = 10;
            this.button10.Text = "ESPUMANTE";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button5.Location = new System.Drawing.Point(484, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 119);
            this.button5.TabIndex = 9;
            this.button5.Text = "PISCO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button6.Location = new System.Drawing.Point(706, 108);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 119);
            this.button6.TabIndex = 8;
            this.button6.Text = "VODKA";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button4.Location = new System.Drawing.Point(262, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 119);
            this.button4.TabIndex = 7;
            this.button4.Text = "RON";
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
            this.button3.Text = "CERVEZA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CANTIDAD";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(706, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ComandaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComandaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMIAV Bares 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComandaUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.panelCategoria.ResumeLayout(false);
            this.panelCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNombreGarzon;
        private System.Windows.Forms.Label labelGarzon;
        private System.Windows.Forms.Label labelNumMesa;
        private System.Windows.Forms.Label labelMesa;
        private System.Windows.Forms.Panel panelCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.Label labelProductoComanda;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
    }
}