namespace Smiav_Bares_1._0
{
    partial class AdminUI
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
            this.tabStock = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ColumnIDStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVolumenStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBarraStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnIDProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioDescuentoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStock.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.tabUsuarios);
            this.tabStock.Controls.Add(this.tabPage3);
            this.tabStock.Controls.Add(this.tabProductos);
            this.tabStock.Location = new System.Drawing.Point(12, 12);
            this.tabStock.Name = "tabStock";
            this.tabStock.SelectedIndex = 0;
            this.tabStock.Size = new System.Drawing.Size(809, 340);
            this.tabStock.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.button3);
            this.tabUsuarios.Controls.Add(this.button2);
            this.tabUsuarios.Controls.Add(this.button1);
            this.tabUsuarios.Controls.Add(this.dataGridView1);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(801, 314);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Gestion Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            this.tabUsuarios.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar Usuario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar Usuario";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRut,
            this.ColumnNombre,
            this.ColumnCargo,
            this.ColumnNick,
            this.ColumnPassword});
            this.dataGridView1.Location = new System.Drawing.Point(52, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnRut
            // 
            this.ColumnRut.HeaderText = "Rut";
            this.ColumnRut.Name = "ColumnRut";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.HeaderText = "Cargo";
            this.ColumnCargo.Name = "ColumnCargo";
            // 
            // ColumnNick
            // 
            this.ColumnNick.HeaderText = "Nick";
            this.ColumnNick.Name = "ColumnNick";
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(801, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gestion Stock";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(697, 245);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 38);
            this.button9.TabIndex = 3;
            this.button9.Text = "Eliminar Insumo";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(697, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 38);
            this.button8.TabIndex = 2;
            this.button8.Text = "Editar Insumo";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(697, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 38);
            this.button7.TabIndex = 1;
            this.button7.Text = "Agregar Insumo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDStock,
            this.ColumnNombreStock,
            this.ColumnTipoStock,
            this.ColumnVolumenStock,
            this.ColumnCantidadStock,
            this.ColumnBarraStock});
            this.dataGridView3.Location = new System.Drawing.Point(20, 26);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(644, 257);
            this.dataGridView3.TabIndex = 0;
            // 
            // ColumnIDStock
            // 
            this.ColumnIDStock.HeaderText = "ID";
            this.ColumnIDStock.Name = "ColumnIDStock";
            // 
            // ColumnNombreStock
            // 
            this.ColumnNombreStock.HeaderText = "Nombre";
            this.ColumnNombreStock.Name = "ColumnNombreStock";
            // 
            // ColumnTipoStock
            // 
            this.ColumnTipoStock.HeaderText = "Tipo";
            this.ColumnTipoStock.Name = "ColumnTipoStock";
            // 
            // ColumnVolumenStock
            // 
            this.ColumnVolumenStock.HeaderText = "Volumen";
            this.ColumnVolumenStock.Name = "ColumnVolumenStock";
            // 
            // ColumnCantidadStock
            // 
            this.ColumnCantidadStock.HeaderText = "Cantidad";
            this.ColumnCantidadStock.Name = "ColumnCantidadStock";
            // 
            // ColumnBarraStock
            // 
            this.ColumnBarraStock.HeaderText = "Barra";
            this.ColumnBarraStock.Name = "ColumnBarraStock";
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.button4);
            this.tabProductos.Controls.Add(this.button5);
            this.tabProductos.Controls.Add(this.button6);
            this.tabProductos.Controls.Add(this.dataGridView2);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(801, 314);
            this.tabProductos.TabIndex = 3;
            this.tabProductos.Text = "Gestion Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "Eliminar Producto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(625, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "Editar Producto";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(625, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "Agregar Producto";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDProd,
            this.ColumnNombreProd,
            this.ColumnPrecioProd,
            this.ColumnPrecioDescuentoProd});
            this.dataGridView2.Location = new System.Drawing.Point(18, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 279);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ColumnIDProd
            // 
            this.ColumnIDProd.HeaderText = "ID";
            this.ColumnIDProd.Name = "ColumnIDProd";
            // 
            // ColumnNombreProd
            // 
            this.ColumnNombreProd.HeaderText = "Nombre";
            this.ColumnNombreProd.Name = "ColumnNombreProd";
            // 
            // ColumnPrecioProd
            // 
            this.ColumnPrecioProd.HeaderText = "Precio";
            this.ColumnPrecioProd.Name = "ColumnPrecioProd";
            // 
            // ColumnPrecioDescuentoProd
            // 
            this.ColumnPrecioDescuentoProd.HeaderText = "Precio Descuento";
            this.ColumnPrecioDescuentoProd.Name = "ColumnPrecioDescuentoProd";
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 386);
            this.Controls.Add(this.tabStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smiav Bares 1.0";
            this.tabStock.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStock;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNick;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioDescuentoProd;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVolumenStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarraStock;
    }
}