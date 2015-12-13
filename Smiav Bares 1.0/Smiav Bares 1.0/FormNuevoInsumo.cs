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
    public partial class FormNuevoInsumo : Form
    {
        private bool editar;
        private string IDgrid;
        private string nombreInsumo;

        public FormNuevoInsumo(bool editar, string ID)
        {
            InitializeComponent();
            this.editar = editar;
            this.IDgrid = ID;

            if (editar)
            {
                this.Text = "Formulario Edición de Insumo";
                InsumoConnect c = new InsumoConnect();
                List<string> insumo = c.SelectInsumoFull(IDgrid);
                nombreInsumo = insumo[1];
                textBoxID.Text = IDgrid;
                textBoxNombre.Text = insumo[1];
                textBoxTipo.Text = insumo[2]; ;
                comboBoxVolumen.Text = insumo[3];

            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string ID = textBoxID.Text;
            string nombre = textBoxNombre.Text;
            string tipo = textBoxTipo.Text;
            string volumen = comboBoxVolumen.Text;

            //quita el 'ml'
            volumen = volumen.Substring(0, volumen.Length - 2);

            Console.WriteLine("vol = "+ volumen);

            Console.WriteLine("volumen: "+volumen);

            InsumoConnect c = new InsumoConnect();

            // busca campos vacios
            if (ID.Equals("") || nombre.Equals("") || tipo.Equals("") || volumen.Equals(""))
            {
                MessageBox.Show(this, "Faltan Campos de Información", "Ingreso Fallido", MessageBoxButtons.OK);
            }
            else
            {

                //si el largo del ID tiene menos de 4 caracteres (es menor que 1000)
                if (ID.Length < 4)
                {
                    int n;
                    bool isNumeric = int.TryParse("123", out n);

                    // si el ID es un numero
                    if (isNumeric)
                    {
                        int contInsumoID = c.CountInsumo(ID, "id");
                        int contInsumoNom = c.CountInsumo(nombre, "nombre");

                        //si el id nuevo no existe en la BD, o si existe 1 ID igual pero eso el mismo que estamos editando
                        if ((contInsumoID == 0 && !ID.Equals(IDgrid)) || (contInsumoID == 1 && ID.Equals(IDgrid)))
                        {

                            // si el nombre del producto no existe en la BD, o si existe 1 nombre igual pero es el mismo que estamos editando 
                            if ((contInsumoNom == 0 && !nombre.Equals(nombreInsumo)) || (contInsumoNom == 1 && nombre.Equals(nombreInsumo)))
                            {
                                //se estamos editando
                                if (editar)
                                {
                                    Console.WriteLine("editar");
                                    c.UpdateInsumo(ID, nombre.ToUpper(), tipo.ToUpper(), volumen);
                                    MessageBox.Show(this, "El Insumo ha sido actualizado con éxito ", "Actualización Exitosa", MessageBoxButtons.OK);
                                    this.Close();
                                }
                                else
                                {
                                    c.InsertInsumo(ID, nombre.ToUpper(), tipo.ToUpper(), volumen);
                                    MessageBox.Show(this, "El Insumo ha sido ingresado con éxito", "Ingreso Exitoso", MessageBoxButtons.OK);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "Ya existe un Insumo con el mismo Nombre", "Ingreso Fallido", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Ya existe un Insumo con el mismo ID", "Ingreso Fallido", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "El ID del Insumo debe ser Numérico", "Ingreso Fallido", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(this, "El ID del Insumo es muy largo", "Ingreso Fallido", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
