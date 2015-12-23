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
    public partial class BartenderUI : Form
    {
        int piso;
        public BartenderUI(int piso)
        {
            InitializeComponent();
            this.piso = piso;
            labelPiso.Text = this.piso + "";
        }

        private void BartenderUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smiav_dbDataSet6.comanda' table. You can move, or remove it, as needed.
            //this.comandaTableAdapter.Fill(this.smiav_dbDataSet6.comanda);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
