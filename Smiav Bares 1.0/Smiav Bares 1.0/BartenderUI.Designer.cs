namespace Smiav_Bares_1._0
{
    partial class BartenderUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BartenderUI));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smiav_dbDataSet6 = new Smiav_Bares_1._0.smiav_dbDataSet6();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandaTableAdapter = new Smiav_Bares_1._0.smiav_dbDataSet6TableAdapters.comandaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idventacomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutgarzonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNombreBartender = new System.Windows.Forms.Label();
            this.labelTextoPiso = new System.Windows.Forms.Label();
            this.labelPiso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comandas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1054, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idventacomDataGridViewTextBoxColumn,
            this.rutgarzonDataGridViewTextBoxColumn,
            this.nummesaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comandaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 548);
            this.dataGridView1.TabIndex = 2;
            // 
            // smiav_dbDataSet6
            // 
            this.smiav_dbDataSet6.DataSetName = "smiav_dbDataSet6";
            this.smiav_dbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comandaBindingSource
            // 
            this.comandaBindingSource.DataMember = "comanda";
            this.comandaBindingSource.DataSource = this.smiav_dbDataSet6;
            // 
            // comandaTableAdapter
            // 
            this.comandaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idventacomDataGridViewTextBoxColumn
            // 
            this.idventacomDataGridViewTextBoxColumn.DataPropertyName = "id_venta_com";
            this.idventacomDataGridViewTextBoxColumn.HeaderText = "id_venta_com";
            this.idventacomDataGridViewTextBoxColumn.Name = "idventacomDataGridViewTextBoxColumn";
            this.idventacomDataGridViewTextBoxColumn.Visible = false;
            // 
            // rutgarzonDataGridViewTextBoxColumn
            // 
            this.rutgarzonDataGridViewTextBoxColumn.DataPropertyName = "rut_garzon";
            this.rutgarzonDataGridViewTextBoxColumn.HeaderText = "rut_garzon";
            this.rutgarzonDataGridViewTextBoxColumn.Name = "rutgarzonDataGridViewTextBoxColumn";
            this.rutgarzonDataGridViewTextBoxColumn.Visible = false;
            // 
            // nummesaDataGridViewTextBoxColumn
            // 
            this.nummesaDataGridViewTextBoxColumn.DataPropertyName = "num_mesa";
            this.nummesaDataGridViewTextBoxColumn.HeaderText = "mesa";
            this.nummesaDataGridViewTextBoxColumn.Name = "nummesaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(1065, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(84, 20);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Bartender:";
            // 
            // labelNombreBartender
            // 
            this.labelNombreBartender.AutoSize = true;
            this.labelNombreBartender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreBartender.Location = new System.Drawing.Point(1155, 25);
            this.labelNombreBartender.Name = "labelNombreBartender";
            this.labelNombreBartender.Size = new System.Drawing.Size(183, 20);
            this.labelNombreBartender.TabIndex = 4;
            this.labelNombreBartender.Text = "NOMBRE BARTENDER";
            // 
            // labelTextoPiso
            // 
            this.labelTextoPiso.AutoSize = true;
            this.labelTextoPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoPiso.Location = new System.Drawing.Point(1106, 45);
            this.labelTextoPiso.Name = "labelTextoPiso";
            this.labelTextoPiso.Size = new System.Drawing.Size(43, 20);
            this.labelTextoPiso.TabIndex = 5;
            this.labelTextoPiso.Text = "Piso:";
            this.labelTextoPiso.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelPiso
            // 
            this.labelPiso.AutoSize = true;
            this.labelPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPiso.Location = new System.Drawing.Point(1155, 45);
            this.labelPiso.Name = "labelPiso";
            this.labelPiso.Size = new System.Drawing.Size(47, 20);
            this.labelPiso.TabIndex = 6;
            this.labelPiso.Text = "PISO";
            // 
            // BartenderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.labelPiso);
            this.Controls.Add(this.labelTextoPiso);
            this.Controls.Add(this.labelNombreBartender);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BartenderUI";
            this.Text = "Bartender";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BartenderUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private smiav_dbDataSet6 smiav_dbDataSet6;
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private smiav_dbDataSet6TableAdapters.comandaTableAdapter comandaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventacomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutgarzonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNombreBartender;
        private System.Windows.Forms.Label labelTextoPiso;
        private System.Windows.Forms.Label labelPiso;
    }
}