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
    public partial class FormCantidad : Form
    {
        public FormCantidad()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        int n;
        private void buttonMas_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(textBoxNum.Text, out n);

            if (isNumeric)
            {
                n = n + 1;
                textBoxNum.Text = n + "";
            } 
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(textBoxNum.Text, out n);

            if (isNumeric)
            {
                if (n > 0)
                {
                    n = n - 1;
                    textBoxNum.Text = n + "";
                }

            }     
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
