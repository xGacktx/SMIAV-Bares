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
    public partial class ComandaUI : Form
    {
        public ComandaUI()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            /*
            // Confirmacion para cerrar la ventana
            switch (MessageBox.Show(this, "¿Estas seguro que deseas salir?", "Cerrar", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }*/
        }

        private void ComandaUI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelMesa_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "RON";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("RON");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "CERVEZA";   
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("Cerveza");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "VODKA";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("VODKA");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "PISCO";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("PISCO");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "COÑAC";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("COÑAC");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void labelGarzonNom_Click(object sender, EventArgs e)
        {

        }

        private void labelGarzon_Click(object sender, EventArgs e)
        {

        }

        private void labelMesaNum_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = false;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormCantidad l = new FormCantidad();
            l.Visible = true;
            //this.Enabled = false;
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "TEQUILA";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("TEQUILA");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "WHISKY";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("WHISKY");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "VINO";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("VINO");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "ESPUMANTE";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("ESPUMANTE");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "BEBIDA";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("BEBIDA");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "JUGO";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("JUGO");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = "CACHAZA";
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto("CACHAZA");
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }
    }
}
