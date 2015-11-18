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
    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut = textBox2.Text;
            string nombre = textBox1.Text;
            string nick = textBox3.Text;
            string contraseña = textBox4.Text;
            string confirmcontra = textBox5.Text;
            string cargo = comboBox1.Text;

            //busca campos vacios
            if (rut.Equals("") || nombre.Equals("") || nick.Equals("") || contraseña.Equals("") || confirmcontra.Equals("") || cargo.Equals(""))
            {
                MessageBox.Show(this, "Faltan Campos de Información", "Ingreso Fallido", MessageBoxButtons.OK);
            }
            else
            {
                if(!contraseña.Equals(confirmcontra))
                {
                    MessageBox.Show(this, "Las Contraseñas NO coinciden", "Ingreso Fallido", MessageBoxButtons.OK);
                }
                else
                {
                    DBConnect c = new DBConnect();
                    int contRut = c.CountUsuario(rut, "rut");
                    int contClave = c.CountUsuario(contraseña, "clave");
                    if(contRut ==0)
                    {
                        if (cargo.Equals("Jefe Personal"))
                        {
                            if (contraseña.Length == 6)
                            {
                                
                                if (contClave == 0)
                                {
                                    c.InsertUsuario(rut, contraseña, cargo, nick, nombre);
                                    MessageBox.Show(this, "El usuario ha sido ingresado con éxito", "Ingreso Exitoso", MessageBoxButtons.OK);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show(this, "Ya existe un usuario con la misma contraseña", "Ingreso Fallido", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "La contraseña de Jefe Personal debe ser de 6 digitos", "Ingreso Fallido", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if(contraseña.Length == 4)
                            {
                                if (contClave == 0)
                                {
                                    c.InsertUsuario(rut, contraseña, cargo, nick, nombre);
                                    MessageBox.Show(this, "El usuario ha sido ingresado con éxito", "Ingreso Exitoso", MessageBoxButtons.OK);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show(this, "Ya existe un usuario con la misma contraseña", "Ingreso Fallido", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "La clave del usuario debe ser de 4 digitos", "Ingreso Exitoso", MessageBoxButtons.OK);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Ya existe un usuario con el mismo rut", "Ingreso Fallido", MessageBoxButtons.OK);
                    } 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
