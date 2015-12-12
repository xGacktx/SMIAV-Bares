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
    public partial class FormNuevoProducto : Form 
    {
        private bool editar;
        private string IDgrid;
        private string nombreProd;
        private bool productoCreado;

        public FormNuevoProducto(bool editar, string ID)
        {
            InitializeComponent();
            this.editar = editar;
            this.IDgrid = ID;
            if (editar)
            {
                //String rut = 
                ProductoConnect c = new ProductoConnect();
                List<string> producto = c.SelectProductoFull(IDgrid);
                nombreProd = producto[1];
                textBoxNombre.Text = producto[1];
                textBoxID.Text = IDgrid;
                textBoxPrecio.Text = producto[2].Substring(0, producto[2].Length - 3); ;
                textBoxDescuento.Text = producto[3].Substring(0, producto[2].Length - 3);
                productoCreado = true;
                
            }
        }

        // agregar un nuevo producto, validados campos vacios
        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            string ID = textBoxID.Text;
            string nombre = textBoxNombre.Text;
            string precio = textBoxPrecio.Text;
            string precioDescuento = textBoxDescuento.Text;

            nombre = nombre.ToUpper();

            ProductoConnect c = new ProductoConnect();

            // busca campos vacios
            if (ID.Equals("") || nombre.Equals("") || precio.Equals("") || precioDescuento.Equals(""))
            {
                MessageBox.Show(this, "Faltan Campos de Información", "Ingreso Fallido", MessageBoxButtons.OK);
            }
            else
            {
                                    
                //si el largo del ID tiene menos de 4 caracteres (es menor que 1000)
                if(ID.Length < 4)
                {
                    int n;
                    bool isNumeric = int.TryParse("123", out n);

                    // si el ID es un numero
                    if(isNumeric)
                    {
                        int contProdID = c.CountProducto(ID, "id");
                        int contProdNom = c.CountProducto(nombre, "nombre");

                        //si el id nuevo no existe en la BD, o si existe 1 ID igual pero eso el mismo que estamos editando
                        if ((contProdID == 0 && !ID.Equals(IDgrid)) || (contProdID == 1 && ID.Equals(IDgrid)))
                        {

                            // si el nombre del producto no existe en la BD, o si existe 1 nombre igual pero es el mismo que estamos editando 
                            if ( (contProdNom == 0 && !nombre.Equals(nombreProd)) || (contProdNom == 1 && nombre.Equals(nombreProd)) )
                            {
                                //se estamos editando
                                if (editar)
                                {
                                    c.UpdateProducto(nombre.ToUpper(), precio, precioDescuento, ID);
                                    MessageBox.Show(this, "El producto ha sido actualizado con éxito ", "Actualización Exitosa", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    c.InsertProducto(ID, nombre.ToUpper(), precio, precioDescuento);
                                    MessageBox.Show(this, "El Producto ha sido ingresado con éxito", "Ingreso Exitoso", MessageBoxButtons.OK);                               
                                    productoCreado = true;                                  
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "Ya existe un Producto con el mismo Nombre", "Ingreso Fallido", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Ya existe un Producto con el mismo ID", "Ingreso Fallido", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "El ID del producto debe ser Numérico", "Ingreso Fallido", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(this, "El ID del producto es muy largo", "Ingreso Fallido", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNick_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarInsumo_Click_1(object sender, EventArgs e)
        {
            if (productoCreado)
            {
                if (dginsumosproducto.SelectedRows.Count == 1)
                {
                    string ID_insumo = dginsumosproducto.SelectedRows[0].Cells[0].Value.ToString();
                    
                    string nombre = dginsumosproducto.SelectedRows[0].Cells[1].Value.ToString();
                    switch (MessageBox.Show(this, "¿Está seguro de eliminar el insumo " + nombre + "?", "Confirmación de seguridad", MessageBoxButtons.OKCancel))
                    {
                        case DialogResult.OK:
                            ProductoConnect c = new ProductoConnect();
                            c.eliminarInsumo(textBoxID.Text, ID_insumo);
                            MessageBox.Show(this, "El Insumo ha sido eliminado", "Información", MessageBoxButtons.OK);
                            refresh();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void refresh()
        {
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectInsumos(IDgrid);
            dginsumosproducto.DataSource = bSource;
            dginsumosproducto.Columns[0].HeaderText = "ID";
            dginsumosproducto.Columns[0].Visible = false;
            dginsumosproducto.Columns[1].HeaderText = "TIPO";
            dginsumosproducto.Columns[2].HeaderText = "NOMBRE";
            dginsumosproducto.Columns[2].Width = 145;
            dginsumosproducto.Columns[3].HeaderText = "VOLUMEN";
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smiav_dbDataSet2.insumo' table. You can move, or remove it, as needed.
            this.insumoTableAdapter.Fill(this.smiav_dbDataSet2.insumo);
           //mi codigo
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectInsumos(IDgrid);
            dginsumosproducto.DataSource = bSource;
            dginsumosproducto.Columns[0].HeaderText = "ID";
            dginsumosproducto.Columns[0].Visible = false;
            dginsumosproducto.Columns[1].HeaderText = "TIPO";            
            dginsumosproducto.Columns[2].HeaderText = "NOMBRE";
            dginsumosproducto.Columns[2].Width = 145;
            dginsumosproducto.Columns[3].HeaderText = "VOLUMEN";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarInsumo_Click(object sender, EventArgs e)
        {
            if (productoCreado)
            {
                string ID_insumo = comboBoxInsumos.SelectedValue.ToString();    
                string volumen = comboBoxVolumen.Text;
                string ID_producto = textBoxID.Text;
                if (volumen != "") {
                    ProductoConnect c = new ProductoConnect();
                    c.agregarInsumo(ID_producto, ID_insumo, volumen);
                    MessageBox.Show(this, "El Insumo ha sido ingresado con éxito", "Ingreso Exitoso", MessageBoxButtons.OK);
                    refresh();
                
                 
                }
                else
                {
                    MessageBox.Show(this, "Debe Seleccionar la cantidad", "Información", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(this, "Primero debe crear un producto", "Información", MessageBoxButtons.OK);
            }
        }
    }
}
