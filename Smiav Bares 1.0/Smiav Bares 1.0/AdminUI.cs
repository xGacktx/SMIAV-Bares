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
using System.Windows;

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
            FormNuevoUsuario L = new FormNuevoUsuario(false,null);
            L.Visible = true;
      
        }
        
        //abastecer stock
        private void button7_Click(object sender, EventArgs e)
        {
            FormIngresoStock form = new FormIngresoStock();
            form.Visible = true;
        }

        // Boton Eliminar Producto
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                string ID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                Console.WriteLine(ID);
                switch (MessageBox.Show(this, "¿Está seguro de eliminar el Producto " + nombre + "?", "Confirmación de seguridad", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        ProductoConnect c = new ProductoConnect();
                        c.DeleteProducto(ID);
                        MessageBox.Show(this, "El producto ha sido eliminado", "Información", MessageBoxButtons.OK);
                        this.productoTableAdapter.Fill(this.smiav_dbDataSet1.producto);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smiav_dbDataSet2.insumo' table. You can move, or remove it, as needed.
            this.insumoTableAdapter.Fill(this.smiav_dbDataSet2.insumo);
            // TODO: This line of code loads data into the 'smiav_dbDataSet1.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.smiav_dbDataSet1.producto);
            // TODO: This line of code loads data into the 'smiav_dbDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.smiav_dbDataSet.usuario);
            // TODO: This line of code loads data into the 'smiav_dbDataSet.usuario' table. You can move, or remove it, as needed.
            this.insumoTableAdapter.Fill(this.smiav_dbDataSet2.insumo);
            
            StockConnect sc = new StockConnect();

            BindingSource bSource = sc.SelectStock();

            dataGridView3.DataSource = bSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        // Refrescar tabla Usuarios
        private void button10_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Fill(this.smiav_dbDataSet.usuario);
        }

        // Editar Usuario
        private void button2_Click(object sender, EventArgs e)
        {
            string rut = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FormNuevoUsuario L = new FormNuevoUsuario(true,rut);
            L.Visible = true;

        }

        // Eliminar Usuario
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string rut = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Console.WriteLine(rut);
                switch (MessageBox.Show(this, "¿Está seguro de eliminar al usuario " + nombre + "?", "Confirmación de seguridad", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        UsuarioConnect c = new UsuarioConnect();
                        c.DeleteUsuario(rut);
                        MessageBox.Show(this, "El usuario ha sido eliminado", "Información", MessageBoxButtons.OK);
                        this.usuarioTableAdapter.Fill(this.smiav_dbDataSet.usuario);
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

        // Boton agregar producto
        private void button6_Click(object sender, EventArgs e)
        {
            FormNuevoProducto L = new FormNuevoProducto(false, null);
            L.Visible = true;
        }

        // Boton refrescar productos
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.productoTableAdapter.Fill(this.smiav_dbDataSet1.producto);
        }

        //boton editar producto
        private void button5_Click(object sender, EventArgs e)
        {
            // Obtiene el id de la producto seleccionada
            string ID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            FormNuevoProducto L = new FormNuevoProducto(true, ID);
            L.Visible = true;
        }

        private void tabStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buttonAgregarInsumo_Click(object sender, EventArgs e)
        {
            FormNuevoInsumo L = new FormNuevoInsumo(false, null);
            L.Visible = true;
        }

        private void buttonEditarInsumo_Click(object sender, EventArgs e)
        {
            // Obtiene el id de la fila seleccionada
            string ID = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            FormNuevoInsumo L = new FormNuevoInsumo(true, ID);
            L.Visible = true;
        }

        private void buttonRefrescarInsumos_Click(object sender, EventArgs e)
        {
            this.insumoTableAdapter.Fill(this.smiav_dbDataSet2.insumo);
        }

        private void tabInsumos_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarInsumo_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 1)
            {
                string ID = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                Console.WriteLine(ID);
                switch (MessageBox.Show(this, "¿Está seguro de eliminar el insumo " + nombre + "?", "Confirmación de seguridad", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        InsumoConnect c = new InsumoConnect();
                        c.DeleteInsumo(ID);
                        MessageBox.Show(this, "El Insumo ha sido eliminado", "Información", MessageBoxButtons.OK);
                        this.insumoTableAdapter.Fill(this.smiav_dbDataSet2.insumo);
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

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
