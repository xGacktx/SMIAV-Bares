namespace Smiav_Bares_1._0
{
    partial class FormIngresoStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoStock));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.insumoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.smiav_dbDataSet4 = new Smiav_Bares_1._0.smiav_dbDataSet4();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.insumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smiav_dbDataSet3 = new Smiav_Bares_1._0.smiav_dbDataSet3();
            this.insumoTableAdapter = new Smiav_Bares_1._0.smiav_dbDataSet3TableAdapters.insumoTableAdapter();
            this.insumoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.insumoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.insumoTableAdapter1 = new Smiav_Bares_1._0.smiav_dbDataSet4TableAdapters.insumoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Primer Piso",
            "Segundo Piso",
            "Bodega"});
            this.comboBox1.Location = new System.Drawing.Point(102, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Barra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Volumen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre Insumo";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.insumoBindingSource3;
            this.comboBox3.DisplayMember = "volumen";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(102, 60);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(103, 21);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.ValueMember = "volumen";
            // 
            // insumoBindingSource3
            // 
            this.insumoBindingSource3.DataMember = "insumo";
            this.insumoBindingSource3.DataSource = this.smiav_dbDataSet4;
            // 
            // smiav_dbDataSet4
            // 
            this.smiav_dbDataSet4.DataSetName = "smiav_dbDataSet4";
            this.smiav_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.insumoBindingSource;
            this.comboBox4.DisplayMember = "nombre";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(102, 23);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(170, 21);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.ValueMember = "nombre";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // insumoBindingSource
            // 
            this.insumoBindingSource.DataMember = "insumo";
            this.insumoBindingSource.DataSource = this.smiav_dbDataSet3;
            // 
            // smiav_dbDataSet3
            // 
            this.smiav_dbDataSet3.DataSetName = "smiav_dbDataSet3";
            this.smiav_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insumoTableAdapter
            // 
            this.insumoTableAdapter.ClearBeforeFill = true;
            // 
            // insumoBindingSource1
            // 
            this.insumoBindingSource1.DataMember = "insumo";
            this.insumoBindingSource1.DataSource = this.smiav_dbDataSet3;
            // 
            // insumoBindingSource2
            // 
            this.insumoBindingSource2.DataMember = "insumo";
            this.insumoBindingSource2.DataSource = this.smiav_dbDataSet4;
            // 
            // insumoTableAdapter1
            // 
            this.insumoTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "cc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormIngresoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIngresoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Ingreso Stock";
            this.Load += new System.EventHandler(this.FormIngresoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiav_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private smiav_dbDataSet3 smiav_dbDataSet3;
        private System.Windows.Forms.BindingSource insumoBindingSource;
        private smiav_dbDataSet3TableAdapters.insumoTableAdapter insumoTableAdapter;
        private System.Windows.Forms.BindingSource insumoBindingSource1;
        private smiav_dbDataSet4 smiav_dbDataSet4;
        private System.Windows.Forms.BindingSource insumoBindingSource2;
        private smiav_dbDataSet4TableAdapters.insumoTableAdapter insumoTableAdapter1;
        private System.Windows.Forms.BindingSource insumoBindingSource3;
        private System.Windows.Forms.Label label1;
    }
}