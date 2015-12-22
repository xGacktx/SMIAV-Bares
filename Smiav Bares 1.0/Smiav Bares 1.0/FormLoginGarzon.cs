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
    public partial class FormLoginGarzon : Form
    {
        private int mesa;
        private string garzon;
        private string comanda;
        public FormLoginGarzon(int mesa, string comanda, string garzon)
        {
            InitializeComponent();
            this.TopMost = true;
            this.mesa = mesa;
            this.comanda = comanda;
            this.garzon = garzon;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormLoginGarzon_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 4) 
                textBoxPassword.Text = textBoxPassword.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length > 0) 
            textBoxPassword.Text = textBoxPassword.Text.Substring(0, textBoxPassword.Text.Length - 1);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // LOGIN
            DBConnect c = new DBConnect();
            string clave = textBoxPassword.Text;

            if (!clave.Equals(""))
            {

                List<string> usuario = c.SelectUsuario(clave);
                int cont = c.CountUsuario(clave, "clave");

                Console.WriteLine("nomgarzon: "+ garzon);
                
                //nombre del garzon, usuario
                if(garzon == null)
                {
                    if (cont == 1 && usuario[0].Equals("GARZÓN"))
                    {
                        //cierra la ventana actual y muestra la siguiente
                        this.Hide();

                        //Abrir Comanda
                        ComandaUI l = new ComandaUI(usuario[1], mesa);
                        l.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show(this, "Clave Inválida", "Inicio de sesión fallida",
                        MessageBoxButtons.OK);
                    }
                }
                

                if (garzon != null)
                {
                    Console.WriteLine("usuario: "+usuario[1]+" garzon: "+garzon);
                    if (cont == 1 && usuario[0].Equals("GARZÓN") && usuario[1].Equals(garzon))
                    {
                        //cierra la ventana actual y muestra la siguiente
                        this.Hide();

                        //Abrir Comanda
                        ComandaUI l = new ComandaUI(usuario[1], mesa);
                        l.Visible = true;
                    }
                    else
                    {
                        Console.WriteLine("user=garzon");
                        MessageBox.Show(this, "Clave Inválida", "Inicio de sesión fallida",
                        MessageBoxButtons.OK);
                    }
                }
                
            }
            else
            {
                MessageBox.Show(this, "Ingrese su clave", "Inicio de sesión fallida",
                MessageBoxButtons.OK);
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)            
                buttonOk.PerformClick();            
        }
    }
}
