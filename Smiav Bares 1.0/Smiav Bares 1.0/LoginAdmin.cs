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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cierra la ventana actual y muestra la siguiente
            this.Hide();
            AdminUI L = new AdminUI();
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
