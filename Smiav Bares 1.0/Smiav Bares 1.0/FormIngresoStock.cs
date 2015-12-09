using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smiav_Bares_1._0
{
    public partial class FormIngresoStock : Form
    {
        public FormIngresoStock()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormIngresoStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smiav_dbDataSet4.insumo' table. You can move, or remove it, as needed.
            this.insumoTableAdapter1.Fill(this.smiav_dbDataSet4.insumo);
            // TODO: This line of code loads data into the 'smiav_dbDataSet3.insumo' table. You can move, or remove it, as needed.
            this.insumoTableAdapter.Fill(this.smiav_dbDataSet3.insumo);

        }
    }
}
