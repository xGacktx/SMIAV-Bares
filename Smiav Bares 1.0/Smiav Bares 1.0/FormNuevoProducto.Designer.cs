namespace Smiav_Bares_1._0
{
    partial class FormNuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.dginsumosproducto = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEliminarInsumo = new System.Windows.Forms.Button();
            this.buttonAgregarInsumo = new System.Windows.Forms.Button();
            this.smiav_dbDataSet5 = new Smiav_Bares_1._0.smiav_dbDataSet5();
            this.insumoproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insumo_productoTableAdapter = new Smiav_Bares_1._0.smiav_dbDataSet5TableAdapters.insumo_productoTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxInsumos = new System.Windows.Forms.ComboBox();
            this.insumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smiav_dbDataSet2 = new Smiav_Bares_1._0.smiav_dbDataSet2();
            this.comboBoxVolumen = new System.Windows.Forms.ComboBox();
            this.insumoTableAdapter = new Smiav_Bares_1._0.smiav_dbDataSet2TableAdapters.insumoTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dginsumosproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Descuento";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(120, 63);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(175, 20);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(120, 94);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(175, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxRut_TextChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(120, 128);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(175, 20);
            this.textBoxPrecio.TabIndex = 8;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxNick_TextChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(46, 218);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(88, 30);
            this.buttonAceptar.TabIndex = 12;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(160, 218);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(85, 30);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Location = new System.Drawing.Point(121, 159);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.Size = new System.Drawing.Size(175, 20);
            this.textBoxDescuento.TabIndex = 9;
            // 
            // dginsumosproducto
            // 
            this.dginsumosproducto.AllowUserToAddRows = false;
            this.dginsumosproducto.AllowUserToDeleteRows = false;
            this.dginsumosproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginsumosproducto.Location = new System.Drawing.Point(342, 51);
            this.dginsumosproducto.Name = "dginsumosproducto";
            this.dginsumosproducto.ReadOnly = true;
            this.dginsumosproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dginsumosproducto.Size = new System.Drawing.Size(389, 128);
            this.dginsumosproducto.TabIndex = 14;
            this.dginsumosproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Receta ( Insumos Producto )";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonEliminarInsumo
            // 
            this.buttonEliminarInsumo.Location = new System.Drawing.Point(656, 228);
            this.buttonEliminarInsumo.Name = "buttonEliminarInsumo";
            this.buttonEliminarInsumo.Size = new System.Drawing.Size(75, 35);
            this.buttonEliminarInsumo.TabIndex = 16;
            this.buttonEliminarInsumo.Text = "Eliminar";
            this.buttonEliminarInsumo.UseVisualStyleBackColor = true;
            this.buttonEliminarInsumo.Click += new System.EventHandler(this.buttonEliminarInsumo_Click_1);
            // 
            // buttonAgregarInsumo
            // 
            this.buttonAgregarInsumo.Location = new System.Drawing.Point(558, 228);
            this.buttonAgregarInsumo.Name = "buttonAgregarInsumo";
            this.buttonAgregarInsumo.Size = new System.Drawing.Size(75, 36);
            this.buttonAgregarInsumo.TabIndex = 17;
            this.buttonAgregarInsumo.Text = "Agregar";
            this.buttonAgregarInsumo.UseVisualStyleBackColor = true;
            this.buttonAgregarInsumo.Click += new System.EventHandler(this.buttonAgregarInsumo_Click);
            // 
            // smiav_dbDataSet5
            // 
            this.smiav_dbDataSet5.DataSetName = "smiav_dbDataSet5";
            this.smiav_dbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insumoproductoBindingSource
            // 
            this.insumoproductoBindingSource.DataMember = "insumo_producto";
            this.insumoproductoBindingSource.DataSource = this.smiav_dbDataSet5;
            // 
            // insumo_productoTableAdapter
            // 
            this.insumo_productoTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = " Insumo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBoxInsumos
            // 
            this.comboBoxInsumos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxInsumos.DataSource = this.insumoBindingSource;
            this.comboBoxInsumos.DisplayMember = "nombre";
            this.comboBoxInsumos.FormattingEnabled = true;
            this.comboBoxInsumos.Location = new System.Drawing.Point(389, 191);
            this.comboBoxInsumos.Name = "comboBoxInsumos";
            this.comboBoxInsumos.Size = new System.Drawing.Size(160, 21);
            this.comboBoxInsumos.TabIndex = 21;
            this.comboBoxInsumos.TabStop = false;
            this.comboBoxInsumos.ValueMember = "id";
            this.comboBoxInsumos.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsumos_SelectedIndexChanged);
            // 
            // insumoBindingSource
            // 
            this.insumoBindingSource.DataMember = "insumo";
            this.insumoBindingSource.DataSource = this.smiav_dbDataSet2;
            // 
            // smiav_dbDataSet2
            // 
            this.smiav_dbDataSet2.DataSetName = "smiav_dbDataSet2";
            this.smiav_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxVolumen
            // 
            this.comboBoxVolumen.FormattingEnabled = true;
            this.comboBoxVolumen.Items.AddRange(new object[] {
            "250",
            "175",
            "275",
            "425"});
            this.comboBoxVolumen.Location = new System.Drawing.Point(610, 191);
            this.comboBoxVolumen.Name = "comboBoxVolumen";
            this.comboBoxVolumen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVolumen.TabIndex = 22;
            // 
            // insumoTableAdapter
            // 
            this.insumoTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Producto";
            // 
            // FormNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 278);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxVolumen);
            this.Controls.Add(this.comboBoxInsumos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAgregarInsumo);
            this.Controls.Add(this.buttonEliminarInsumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dginsumosproducto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDescuento);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dginsumosproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.DataGridView dginsumosproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEliminarInsumo;
        private System.Windows.Forms.Button buttonAgregarInsumo;
        private smiav_dbDataSet5 smiav_dbDataSet5;
        private System.Windows.Forms.BindingSource insumoproductoBindingSource;
        private smiav_dbDataSet5TableAdapters.insumo_productoTableAdapter insumo_productoTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxInsumos;
        private System.Windows.Forms.ComboBox comboBoxVolumen;
        private smiav_dbDataSet2 smiav_dbDataSet2;
        private System.Windows.Forms.BindingSource insumoBindingSource;
        private smiav_dbDataSet2TableAdapters.insumoTableAdapter insumoTableAdapter;
        private System.Windows.Forms.Label label8;
    }
}