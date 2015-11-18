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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //agregar nuevo usuario
        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario L = new FormNuevoUsuario();
            L.Visible = true;
        }

        //abastecer stock
        private void button7_Click(object sender, EventArgs e)
        {
            FormIngresoStock form = new FormIngresoStock();
            form.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smiav_dbDataSet1.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.smiav_dbDataSet1.producto);
            // TODO: This line of code loads data into the 'smiav_dbDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.smiav_dbDataSet.usuario);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirmacion para cerrar la ventana
            switch (MessageBox.Show(this, "¿Estas seguro que deseas salir?", "Cerrar", MessageBoxButtons.OKCancel))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Fill(this.smiav_dbDataSet.usuario);
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        //eliminar Usuario
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string rut = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Console.WriteLine(rut);
                switch (MessageBox.Show(this, "¿Esta seguro de eliminar al usuario " + nombre + "?", "Confirmacion de seguridad", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        DBConnect c = new DBConnect();
                        c.Delete(rut);
                        MessageBox.Show(this, "El usuario ha sido eliminado", "Información", MessageBoxButtons.OK);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar una fila a eliminar", "Información", MessageBoxButtons.OK);
            }
        }
    }
}
