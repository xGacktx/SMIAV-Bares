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
    public partial class GarzonUI1P : Form
    {
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

        private void button7_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(7);
            L.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(2);
            L.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(5);
            L.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(6);
            L.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(3);
            L.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(4);
            L.Visible = true;
        }

        private void buttonMesa8_Click(object sender, EventArgs e)
        {            
            FormLoginGarzon L = new FormLoginGarzon(8);
            L.Visible = true;
        }

     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonMesa10_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(10);
            L.Visible = true;
        }

        private void buttonMesa9_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(9);
            L.Visible = true;
        }

        private void buttonMesa1_Click(object sender, EventArgs e)
        {
            FormLoginGarzon L = new FormLoginGarzon(1);
            L.Visible = true;
        }
    }
}
