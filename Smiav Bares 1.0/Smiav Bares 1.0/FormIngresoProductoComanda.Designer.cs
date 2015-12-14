namespace Smiav_Bares_1._0
{
    partial class FormIngresoProductoComanda
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.smiav_dbDataSet = new Smiav_Bares_1._0.smiav_dbDataSet();
            this.smiavdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smiav_dbDataSet1 = new Smiav_Bares_1._0.smiav_dbDataSet1();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Smiav_Bares_1._0.smiav_dbDataSet1TableAdapters.productoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciodescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiavdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.preciodescDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(159, 20);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(141, 31);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoria";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // smiav_dbDataSet
            // 
            this.smiav_dbDataSet.DataSetName = "smiav_dbDataSet";
            this.smiav_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smiavdbDataSetBindingSource
            // 
            this.smiavdbDataSetBindingSource.DataSource = this.smiav_dbDataSet;
            this.smiavdbDataSetBindingSource.Position = 0;
            // 
            // smiav_dbDataSet1
            // 
            this.smiav_dbDataSet1.DataSetName = "smiav_dbDataSet1";
            this.smiav_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.smiav_dbDataSet1;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // preciodescDataGridViewTextBoxColumn
            // 
            this.preciodescDataGridViewTextBoxColumn.DataPropertyName = "precio_desc";
            this.preciodescDataGridViewTextBoxColumn.HeaderText = "precio_desc";
            this.preciodescDataGridViewTextBoxColumn.Name = "preciodescDataGridViewTextBoxColumn";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.Location = new System.Drawing.Point(496, 138);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(128, 51);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFinalizar.Location = new System.Drawing.Point(496, 242);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(128, 51);
            this.buttonFinalizar.TabIndex = 4;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // FormIngresoProductoComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 327);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormIngresoProductoComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIngresoProductoComanda";
            this.Load += new System.EventHandler(this.FormIngresoProductoComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiavdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource smiavdbDataSetBindingSource;
        private smiav_dbDataSet smiav_dbDataSet;
        private smiav_dbDataSet1 smiav_dbDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private smiav_dbDataSet1TableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciodescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonFinalizar;
    }
}