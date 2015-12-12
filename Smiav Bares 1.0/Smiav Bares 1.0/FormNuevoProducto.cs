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
                textBoxRut.Text = producto[1];
                textBoxNombre.Text = IDgrid;
                textBoxNick.Text = producto[2].Substring(0, producto[2].Length - 3); ;
                textBoxClave.Text = producto[3].Substring(0, producto[2].Length - 3);
                
            }
        }

        // agregar un nuevo producto, validados campos vacios
        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBoxNombre.Text;
            string nombre = textBoxRut.Text;
            string precio = textBoxNick.Text;
            string precioDescuento = textBoxClave.Text;

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
                                    c.UpdateProducto(nombre, precio, precioDescuento, ID);
                                    MessageBox.Show(this, "El producto ha sido actualizado con éxito ", "Actualización Exitosa", MessageBoxButtons.OK);
                                    this.Close();
                                }
                                else
                                {
                                    c.InsertProducto(ID, nombre, precio, precioDescuento);
                                    MessageBox.Show(this, "El Producto ha sido ingresado con éxito", "Ingreso Exitoso", MessageBoxButtons.OK);
                                    this.Close();
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
