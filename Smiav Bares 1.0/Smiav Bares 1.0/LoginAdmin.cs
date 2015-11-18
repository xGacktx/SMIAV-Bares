using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ConnectCsharpToMysql;

namespace Smiav_Bares_1._0
{
    public partial class LoginAdmin : Form
    {
        int categoria;
        public LoginAdmin(int cat)
        {
            categoria = cat;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();
            string clave = textBox1.Text;
     
            if (!clave.Equals(""))
            {

                List<string> usuario = c.SelectUsuario(clave);
                int cont = c.CountUsuario(clave, "clave");

                if (cont == 1 && usuario[0].Equals("Jefe Personal"))
                {
                    //cierra la ventana actual y muestra la siguiente
                    this.Hide();

                    //categoria Administrador
                    if(categoria == 0)
                    {
                        AdminUI L = new AdminUI();
                        L.Closed += (s, args) => this.Close();
                        L.Show();
                    }

                    //categoria Garzon
                    if (categoria == 1)
                    {
                        GarzonUI L = new GarzonUI();
                        L.Closed += (s, args) => this.Close();
                        L.Show();
                    }

                    //categoria Bartender
                    if (categoria == 2)
                    {
                        AdminUI L = new AdminUI();
                        L.Closed += (s, args) => this.Close();
                        L.Show();
                    }

                    //categoria Cajera
                    if (categoria == 3)
                    {
                        AdminUI L = new AdminUI();
                        L.Closed += (s, args) => this.Close();
                        L.Show();
                    }


                    //mensaje de bienvenida
                    MessageBox.Show(this, "Bienvenida(o) " + usuario[1], "Inicio de sesión exitoso",
                    MessageBoxButtons.OK);
                }
                else 
                {
                    MessageBox.Show(this, "Clave Inválida", "Inicio de sesión fallida",
                    MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(this, "Ingrese su clave", "Inicio de sesión fallida",
                MessageBoxButtons.OK);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow L = new MainWindow();
            L.Closed += (s, args) => this.Close();
            L.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("keypressed");
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
