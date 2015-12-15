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
    public partial class FormSelectPiso : Form
    {
        public FormSelectPiso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GarzonUI1P L = new GarzonUI1P();
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GarzonUI2P L= new GarzonUI2P();
            L.Closed += (s, args) => this.Close();
            L.Show();
        }
    }
}
