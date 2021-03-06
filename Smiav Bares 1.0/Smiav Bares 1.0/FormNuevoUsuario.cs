﻿using System;
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
        private bool editar;
        private string rutgrid;

        public FormNuevoUsuario(bool editar,string rut)
        {
            InitializeComponent();
            this.editar = editar;
            this.rutgrid = rut;
            if (editar)
            {
                //String rut = 
                UsuarioConnect c = new UsuarioConnect();
                List<string> usuario = c.SelectUsuarioFull(rutgrid);
                textBoxNombre.Text = usuario[0];
                textBoxRut.Text = rutgrid;
                textBoxNick.Text = usuario[1] ;
                comboBoxCargo.Text = usuario[2];
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut = textBoxRut.Text;
            string nombre = textBoxNombre.Text;
            string nick = textBoxNick.Text;
            string contraseña = textBoxClave.Text;
            string confirmcontra = textBoxClave2.Text;
            string cargo = comboBoxCargo.Text;

            nombre = nombre.ToUpper();

            UsuarioConnect c = new UsuarioConnect();

            if (!editar)
            {
                //busca campos vacios
                if (rut.Equals("") || nombre.Equals("") || nick.Equals("") || contraseña.Equals("") || confirmcontra.Equals("") || cargo.Equals(""))
                {
                    MessageBox.Show(this, "Faltan Campos de Información", "Ingreso Fallido", MessageBoxButtons.OK);
                }
                else
                {
                    if (!contraseña.Equals(confirmcontra))
                    {
                        MessageBox.Show(this, "Las Contraseñas NO coinciden", "Ingreso Fallido", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int contRut = c.CountUsuario(rut, "rut");
                        int contClave = c.CountUsuario(contraseña, "clave");
                        if (contRut == 0)
                        {
                            if (cargo.Equals("Jefe Personal"))
                            {
                                if (contraseña.Length == 6)
                                {

                                    if (contClave == 0)
                                    {
                                        c.InsertUsuario(rut, contraseña, cargo, nick.ToUpper(), nombre.ToUpper());
                                        MessageBox.Show(this, "El usuario ha sido ingresado con éxito", "Ingreso Exitoso", MessageBoxButtons.OK);
                                        this.Close();                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Contraseña no valida", "Ingreso Fallido", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(this, "La contraseña de Jefe Personal debe ser de 6 dígitos", "Ingreso Fallido", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                if (contraseña.Length == 4)
                                {
                                    if (contClave == 0)
                                    {
                                        c.InsertUsuario(rut, contraseña, cargo.ToUpper(), nick.ToUpper(), nombre.ToUpper());
                                        MessageBox.Show(this, "El usuario ha sido ingresado con éxito", "Ingreso Exitoso", MessageBoxButtons.OK);
                                        this.Close();
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Contraseña no valida", "Ingreso Fallido", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(this, "La clave del usuario debe ser de 4 digitos", "Ingreso Fallido", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Ya existe un usuario con el mismo rut", "Ingreso Fallido", MessageBoxButtons.OK);
                        }
                    }
                }
            }//fin agregar usuario
            else//Editar usuario 
            {
                //busca campos vacios
                if (rut.Equals("") || nombre.Equals("") || nick.Equals("") ||  cargo.Equals(""))
                {
                    MessageBox.Show(this, "Faltan Campos de Información", "Ingreso Fallido", MessageBoxButtons.OK);
                }
                else {
                    if (contraseña.Equals("") && confirmcontra.Equals("") )
                    {
                        c.UpdateUsuario(nombre.ToUpper(), rutgrid, nick.ToUpper(), cargo.ToUpper(), null);
                        MessageBox.Show(this, "El usuario ha sido actualizado con éxito ", "Actualización Exitosa", MessageBoxButtons.OK);
                        this.Close();                    
                    }
                    else
                    {
                        int contClave = c.CountUsuario(contraseña, "clave");
                        if (!contraseña.Equals(confirmcontra))
                        {
                            MessageBox.Show(this, "Las Contraseñas NO coinciden", "Ingreso Fallido", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (cargo.Equals("Jefe Personal"))
                            {
                                if (contraseña.Length == 6)
                                {

                                    if (contClave == 0)
                                    {
                                        c.UpdateUsuario(nombre.ToUpper(), rutgrid, nick.ToUpper(), cargo.ToUpper(), contraseña);
                                        MessageBox.Show(this, "El usuario ha sido actualizado con éxito", "Ingreso Actualización", MessageBoxButtons.OK);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Contraseña no valida", "Ingreso Fallido", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(this, "La contraseña del Jefe de Personal debe ser de 6 dígitos", "Ingreso Fallido", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {                            
                                if (contraseña.Length == 4)
                                {
                                    if (contClave == 0)
                                    {
                                        c.UpdateUsuario(nombre.ToUpper(), rutgrid, nick.ToUpper(), cargo.ToUpper(), contraseña);
                                        MessageBox.Show(this, "El usuario ha sido actualizado con éxito", "Ingreso Actualización", MessageBoxButtons.OK);
                                        this.Close();

                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Contraseña no válida", "Actualización Fallida", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(this, "La clave del usuario debe ser de 4 dígitos", "Actualización Fallida", MessageBoxButtons.OK);
                                }
                            }                            
                        }
                    }
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

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
