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
    public partial class FormIngresoProductoComanda : Form
    {
        
        public FormIngresoProductoComanda(string categoria)
        {
            InitializeComponent();
            labelCategoria.Text = categoria;

        }

        private void FormIngresoProductoComanda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smiav_dbDataSet1.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.smiav_dbDataSet1.producto);

        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
