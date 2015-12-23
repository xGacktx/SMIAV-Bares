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
        private int mesaActiva;
        //cantidad de mesas en la interfaz 1er piso
        private static int cantMesas = 10;
        //arreglo de datos de mesas donde se guardaran la comanda(id) y garzon(nick)
        private string[,] mesas = new string[cantMesas+1, 2]; 

        public GarzonUI1P()
        {
            InitializeComponent();
            //comentario para commit           

        }

        //abre un "listener" que verifica el final de n proceso(en este caso el de el ingreso de una comanda)
        private void GarzonUI_Load(object sender, EventArgs e)
        {
            CompleteEvents.Complete += new CompleteEvents.CompleteHandler(CompleteEvents_Complete);
        }

        //cuando el proceso de completa, se llama a este metodo y recibe los datos del ingreso de la comanda
        void CompleteEvents_Complete(CompleteEventArgs args)
        {
            Console.WriteLine(string.Format("La operacion se completó correctamente \n Resultado: mesa:{0} comanda:{1} garzon:{2}", args.Mesa, args.Comanda, args.Garzon));
            // cargo los campos de comanda(id) y garzon(nombre) al arreglo de mesas
            mesas[args.Mesa, 0] = args.Comanda;
            mesas[args.Mesa, 1] = args.Garzon;
            PintaMesas();
                
        }

        private void PintaMesas()
        {
            if (mesas[1, 0] != null)
            {
                buttonMesa1.BackColor = Color.LightGreen;
            }
            if (mesas[2, 0] != null)
            {
                buttonMesa2.BackColor = Color.LightGreen;
            }
            if (mesas[3, 0] != null)
            {
                buttonMesa3.BackColor = Color.LightGreen;
            }
            if (mesas[4, 0] != null)
            {
                buttonMesa4.BackColor = Color.LightGreen;
            }
            if (mesas[5, 0] != null)
            {
                buttonMesa5.BackColor = Color.LightGreen;
            }
            if (mesas[6, 0] != null)
            {
                buttonMesa6.BackColor = Color.LightGreen;
            }
            if (mesas[7, 0] != null)
            {
                buttonMesa7.BackColor = Color.LightGreen;
            }
            if (mesas[8, 0] != null)
            {
                buttonMesa8.BackColor = Color.LightGreen;
            }
            if (mesas[9, 0] != null)
            {
                buttonMesa9.BackColor = Color.LightGreen;
            }
            if (mesas[10, 0] != null)
            {
                buttonMesa10.BackColor = Color.LightGreen;
            }
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

        // ###### Botones Mesas ######
        private void buttonMesa1_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(1, mesas[1, 0], mesas[1, 1]);
            L.Visible = true;
        }

        private void buttonMesa2_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(2, mesas[2, 0], mesas[2, 1]);
            L.Visible = true;
        }

        private void buttonMesa3_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(3, mesas[3, 0], mesas[3, 1]);
            L.Visible = true;
        }

        private void buttonMesa4_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(4, mesas[4, 0], mesas[4, 1]);
            L.Visible = true;
        }

        private void buttonMesa5_Click(object sender, EventArgs e)
        {

            FormLoginGarzon L = new FormLoginGarzon(5, mesas[5, 0], mesas[5, 1]);
            L.Visible = true;

        }

        private void buttonMesa6_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(6, mesas[6, 0], mesas[6, 1]);
            L.Visible = true;
        }

        private void buttonMesa7_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(7, mesas[7, 0], mesas[7, 1]);
            L.Visible = true;
        }

        private void buttonMesa8_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(8, mesas[8, 0], mesas[8, 1]);
            L.Visible = true;
        }

        private void buttonMesa9_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(9, mesas[9, 0], mesas[9, 1]);
            L.Visible = true;
        }
        private void buttonMesa10_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(10, mesas[10, 0], mesas[10, 1]);
            L.Visible = true;
        }
        // ######## Fin Botones Mesas #############

    }
}
