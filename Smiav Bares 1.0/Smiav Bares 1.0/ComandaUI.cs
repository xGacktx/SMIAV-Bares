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
        private string nombreGarzon;
        private int mesa, n, fila = 0;
        public string datosEntreForm;
        private int idComanda;
        private string nom_prod, id_com, id_prod, cantidad, tipo_venta, precio, rut_garzon;

        public ComandaUI(String nombreGarzon,int mesa)
        {
            InitializeComponent();
            labelNombreGarzon.Text = nombreGarzon;
            labelNumMesa.Text = mesa+"";
            this.nombreGarzon = nombreGarzon;
            this.mesa = mesa;
        }
        public ComandaUI(int id, String nombreGarzon, int mesa)
        {
            InitializeComponent();
            this.idComanda = id;
            //codigo cargar datos
            ComandaConnect sc = new ComandaConnect();
            BindingSource bSource = sc.SelectProdComanda(1);
            dgProdComanda.DataSource = bSource;
            dgProdComanda.Columns[0].HeaderText = "NOMBRE";
            dgProdComanda.Columns[0].Width = 140;
            dgProdComanda.Columns[1].HeaderText = "CANTIDAD";
            dgProdComanda.Columns[2].HeaderText = "PRECIO";
           
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            
            // Confirmacion para cerrar la ventana
            switch (MessageBox.Show(this, "¿Estas seguro que deseas salir?", "Cerrar", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void ComandaUI_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            DatosComanda datos = DatosComanda.Instance();
            CompleteEvents.RaiseEvent(mesa, "2", nombreGarzon);
            // Ingresar Comanda comanda
            //enviar informacion a la mierda de mesas
            this.Close();
        }
        private void button2_Eliminar(object sender, EventArgs e)
        {
            //Eliminar producto de forma local sin haber ingresado a la comanda aun
            //Hay que hacer el caso de eliminar un producto que ya este ingresado en comanda para que despliegue el login administradora
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
          
        // ################ Panel Categorias ##############

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            nom_prod = dgProductos.SelectedRows[0].Cells[1].Value.ToString();
            
            string tot = dgProductos.SelectedRows[0].Cells[2].Value.ToString();
            int total;
            int cant;
            bool isNumeric = int.TryParse(tot.Substring(0, tot.Length - 3), out total);
            bool isNumero = int.TryParse(textBox1.Text, out cant);
            
            Console.WriteLine(nom_prod);
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(isNumeric);
            Console.WriteLine(isNumero);
            
            if (isNumeric && isNumero)
            {
                //Console.WriteLine("sonnumeros");
                dgProdComanda.Rows.Add();
                dgProdComanda.Rows[fila].Cells[0].Value = nom_prod;
                dgProdComanda.Rows[fila].Cells[1].Value = cant;
                total = total * cant;
                dgProdComanda.Rows[fila].Cells[2].Value = total ;
                dgProdComanda.Update();
                fila++;
                textBox1.Text = "1";
            }
            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panelProductos.Visible = false;
        }

        private void cargaDgProductos(string categoria)
        {
            panelProductos.Visible = true;
            labelCategoria.Text = categoria;
            ProductoConnect sc = new ProductoConnect();
            BindingSource bSource = sc.SelectProducto(categoria);
            dgProductos.DataSource = bSource;
            dgProductos.Columns[0].HeaderText = "ID";
            dgProductos.Columns[0].Visible = false;
            dgProductos.Columns[1].HeaderText = "NOMBRE";
            dgProductos.Columns[2].HeaderText = "PRECIO LISTA";
            dgProductos.Columns[3].HeaderText = "PRECIO DESCUENTO";
            dgProductos.Columns[1].Width = 320;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cargaDgProductos("RON");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargaDgProductos("CERVEZA");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargaDgProductos("VODKA");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cargaDgProductos("PISCO");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cargaDgProductos("COÑAC");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cargaDgProductos("TEQUILA");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cargaDgProductos("WHISKY");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cargaDgProductos("VINO");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cargaDgProductos("ESPUMANTE");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cargaDgProductos("BEBIDA");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cargaDgProductos("JUGO");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cargaDgProductos("CACHAZA");
        }

        //boton mas
        private void button15_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(textBox1.Text, out n);

            if (isNumeric)
            {
                n = n + 1;
                textBox1.Text = n + "";
            } 
        }

        //boton menos
        private void button2_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(textBox1.Text, out n);

            if (isNumeric)
            {
                if (n > 0)
                {
                    n = n - 1;
                    textBox1.Text = n + "";
                }
            }   
        }
        
       // ############### Fin Panel categoria ##############
    }
}
