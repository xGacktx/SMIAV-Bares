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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //boton administrador
        private void AdminButton_Click(object sender, EventArgs e)
        {
            //cierra la ventana actual y muestra la siguiente
            this.Hide();
            LoginAdmin L = new LoginAdmin(0); // 0 = administrador
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

        //boton garzon
        private void garzonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin L = new LoginAdmin(1); // 1 = garzon
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

        //boton bartender
        private void bartenderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin L = new LoginAdmin(2); // 2 = bartender
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

        //boton cajera
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin L = new LoginAdmin(3); //3 = cajera
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

    }
}
