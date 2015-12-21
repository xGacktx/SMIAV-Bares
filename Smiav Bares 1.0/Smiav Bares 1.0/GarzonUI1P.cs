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
    public partial class GarzonUI1P : Form 
    {
        private int mesaActiva,i;        
        public GarzonUI1P()
        {
            InitializeComponent();
            //comentario para commit           
         
        }           

        private void GarzonUI_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirmacion para cerrar la ventana
            switch (MessageBox.Show(this, "¿Está seguro que deseas salir?", "Confirmación", MessageBoxButtons.OKCancel))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
        // ###### Botones Mesas ######33
        private void buttonMesa1_Click(object sender, EventArgs e)
        {           
            FormLoginGarzon L = new FormLoginGarzon(1);
            L.Visible = true;
        }

        private void buttonMesa2_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(2);
            L.Visible = true;
        }

        private void buttonMesa3_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(3);
            L.Visible = true;
        }

        private void buttonMesa4_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(4);
            L.Visible = true;
        }

        private void buttonMesa5_Click(object sender, EventArgs e)
        {
           
            //FormLoginGarzon caca = new FormLoginGarzon(5);
            ComandaUI caca = new ComandaUI("caca", 9);
            //caca.Visible = true;
            DialogResult res = caca.ShowDialog();
            if (res == DialogResult.OK) Console.WriteLine(caca.datosEntreForm);
           // string caca = L.datosEntreForm;
            
        }

        private void buttonMesa6_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(6);
            L.Visible = true;
        }

        private void buttonMesa7_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(7);
            L.Visible = true;
        }
        
        private void buttonMesa8_Click(object sender, EventArgs e)
        {            
            FormLoginGarzon L = new FormLoginGarzon(8);
            L.Visible = true;
        }

        private void buttonMesa9_Click(object sender, EventArgs e)
        {
            /*FormLoginGarzon L = new FormLoginGarzon(9);
            L.Visible = true;*/
            mesaActiva = 9;
            panelLogin.Visible = true;
        }
        private void buttonMesa10_Click(object sender, EventArgs e)
        {
            /*FormLoginGarzon L = new FormLoginGarzon(10);
            L.Visible = true;*/
            mesaActiva = 10;
            //if (estadoMesa[9] == true) buttonMesa9.BackColor = Color.Red;
            panelLogin.Visible = true;
        }
        // ######## Fin Botones Mesas #############
             
        // ########  Codigo LOGIN Garzon  ##########
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // LOGIN
            DBConnect c = new DBConnect();
            string clave = textBoxPassword.Text;

            if (!clave.Equals(""))
            {

                List<string> usuario = c.SelectUsuario(clave);
                int cont = c.CountUsuario(clave, "clave");

                if (cont == 1 && usuario[0].Equals("GARZÓN"))
                {
                    
                    //Abrir Comanda
                    ComandaUI l = new ComandaUI(1,usuario[1], mesaActiva);
                    l.Visible = true;
                    textBoxPassword.Text = "";
                    panelLogin.Visible = false;
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

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length > 0)
                textBoxPassword.Text = textBoxPassword.Text.Substring(0, textBoxPassword.Text.Length - 1);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
        }
    }
    //################# Fin Login ###############
}
