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
            this.components = new System.ComponentModel.Container();
            this.tabStock = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.botonEliminarUsuario = new System.Windows.Forms.Button();
            this.botonEditarUsuario = new System.Windows.Forms.Button();
            this.botonAgregarUsuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smiav_dbDataSet = new Smiav_Bares_1._0.smiav_dbDataSet();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciodescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smiav_dbDataSet1 = new Smiav_Bares_1._0.smiav_dbDataSet1();
            this.usuarioTableAdapter = new Smiav_Bares_1._0.smiav_dbDataSetTableAdapters.usuarioTableAdapter();
            this.smiavdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Smiav_Bares_1._0.smiav_dbDataSet1TableAdapters.productoTableAdapter();
            this.tabStock.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiavdbDataSetBindingSource)).BeginInit();
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
            this.tabUsuarios.Controls.Add(this.button10);
            this.tabUsuarios.Controls.Add(this.botonEliminarUsuario);
            this.tabUsuarios.Controls.Add(this.botonEditarUsuario);
            this.tabUsuarios.Controls.Add(this.botonAgregarUsuario);
            this.tabUsuarios.Controls.Add(this.dataGridView1);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(801, 314);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Gestión Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            this.tabUsuarios.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(625, 158);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 38);
            this.button10.TabIndex = 4;
            this.button10.Text = "Refrescar Datos";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // botonEliminarUsuario
            // 
            this.botonEliminarUsuario.Location = new System.Drawing.Point(625, 243);
            this.botonEliminarUsuario.Name = "botonEliminarUsuario";
            this.botonEliminarUsuario.Size = new System.Drawing.Size(124, 38);
            this.botonEliminarUsuario.TabIndex = 3;
            this.botonEliminarUsuario.Text = "Eliminar Usuario";
            this.botonEliminarUsuario.UseVisualStyleBackColor = true;
            this.botonEliminarUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // botonEditarUsuario
            // 
            this.botonEditarUsuario.Location = new System.Drawing.Point(625, 95);
            this.botonEditarUsuario.Name = "botonEditarUsuario";
            this.botonEditarUsuario.Size = new System.Drawing.Size(124, 38);
            this.botonEditarUsuario.TabIndex = 2;
            this.botonEditarUsuario.Text = "Editar Usuario";
            this.botonEditarUsuario.UseVisualStyleBackColor = true;
            this.botonEditarUsuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonAgregarUsuario
            // 
            this.botonAgregarUsuario.Location = new System.Drawing.Point(625, 34);
            this.botonAgregarUsuario.Name = "botonAgregarUsuario";
            this.botonAgregarUsuario.Size = new System.Drawing.Size(124, 38);
            this.botonAgregarUsuario.TabIndex = 1;
            this.botonAgregarUsuario.Text = "Agregar Usuario";
            this.botonAgregarUsuario.UseVisualStyleBackColor = true;
            this.botonAgregarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nickDataGridViewTextBoxColumn,
            this.claveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(545, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "Rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            this.rutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nickDataGridViewTextBoxColumn
            // 
            this.nickDataGridViewTextBoxColumn.DataPropertyName = "nick";
            this.nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            this.nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            this.nickDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            this.claveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.smiav_dbDataSet;
            // 
            // smiav_dbDataSet
            // 
            this.smiav_dbDataSet.DataSetName = "smiav_dbDataSet";
            this.smiav_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tabPage3.Text = "Gestión Stock";
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
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.ShowEditingIcon = false;
            this.dataGridView3.Size = new System.Drawing.Size(644, 257);
            this.dataGridView3.TabIndex = 0;
            // 
            // ColumnIDStock
            // 
            this.ColumnIDStock.HeaderText = "ID";
            this.ColumnIDStock.Name = "ColumnIDStock";
            this.ColumnIDStock.ReadOnly = true;
            // 
            // ColumnNombreStock
            // 
            this.ColumnNombreStock.HeaderText = "Nombre";
            this.ColumnNombreStock.Name = "ColumnNombreStock";
            this.ColumnNombreStock.ReadOnly = true;
            // 
            // ColumnTipoStock
            // 
            this.ColumnTipoStock.HeaderText = "Tipo";
            this.ColumnTipoStock.Name = "ColumnTipoStock";
            this.ColumnTipoStock.ReadOnly = true;
            // 
            // ColumnVolumenStock
            // 
            this.ColumnVolumenStock.HeaderText = "Volumen";
            this.ColumnVolumenStock.Name = "ColumnVolumenStock";
            this.ColumnVolumenStock.ReadOnly = true;
            // 
            // ColumnCantidadStock
            // 
            this.ColumnCantidadStock.HeaderText = "Cantidad";
            this.ColumnCantidadStock.Name = "ColumnCantidadStock";
            this.ColumnCantidadStock.ReadOnly = true;
            // 
            // ColumnBarraStock
            // 
            this.ColumnBarraStock.HeaderText = "Barra";
            this.ColumnBarraStock.Name = "ColumnBarraStock";
            this.ColumnBarraStock.ReadOnly = true;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.button1);
            this.tabProductos.Controls.Add(this.button4);
            this.tabProductos.Controls.Add(this.button5);
            this.tabProductos.Controls.Add(this.button6);
            this.tabProductos.Controls.Add(this.dataGridView2);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(801, 314);
            this.tabProductos.TabIndex = 3;
            this.tabProductos.Text = "Gestión Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refrescar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(625, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "Agregar Producto";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn,
            this.preciodescDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(18, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(545, 275);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preciodescDataGridViewTextBoxColumn
            // 
            this.preciodescDataGridViewTextBoxColumn.DataPropertyName = "precio_desc";
            this.preciodescDataGridViewTextBoxColumn.HeaderText = "Precio Descuento";
            this.preciodescDataGridViewTextBoxColumn.Name = "preciodescDataGridViewTextBoxColumn";
            this.preciodescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.smiav_dbDataSet1;
            // 
            // smiav_dbDataSet1
            // 
            this.smiav_dbDataSet1.DataSetName = "smiav_dbDataSet1";
            this.smiav_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // smiavdbDataSetBindingSource
            // 
            this.smiavdbDataSetBindingSource.DataSource = this.smiav_dbDataSet;
            this.smiavdbDataSetBindingSource.Position = 0;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 386);
            this.Controls.Add(this.tabStock);
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMIAV Bares 1.0";
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.tabStock.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiavdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStock;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Button botonEliminarUsuario;
        private System.Windows.Forms.Button botonEditarUsuario;
        private System.Windows.Forms.Button botonAgregarUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private smiav_dbDataSet smiav_dbDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private smiav_dbDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource smiavdbDataSetBindingSource;
        private smiav_dbDataSet1 smiav_dbDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private smiav_dbDataSet1TableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciodescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}