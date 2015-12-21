using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;

//to use DataTable
using System.Data;


namespace ConnectCsharpToMysql
{
    class ComandaConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public ComandaConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "smiav_db";
            uid = "root";
            password = "R00t..";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se pudo conectar con el servidor.  Contacte a un administrador del sistema");
                        break;

                    case 1045:
                        MessageBox.Show("usuario/contraseña Inválidos, por favor intente nuevamente");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void InsertProdComanda(string id_com, string id_prod, string cantidad, string tipo_venta)
        {
            string query = "INSERT INTO prod_atencion (id_comanda_pat, id_producto_pat, cantidad, tipo_venta) VALUES('" + id_com + "', '" + id_prod + "', '" + cantidad + "', '" + tipo_venta + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void UpdateProducto(string nom, string precio, string precioDescuento, string ID)
        {
            string query;

            query = "UPDATE producto SET id='" + ID + "' , nombre='" + nom + "' , precio='" + precio + "' , precio_desc='" + precioDescuento + "' WHERE ID='" + ID + "' ";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Eliminar buscando por rut
        public void DeleteProducto(string ID)
        {
            string query = "DELETE FROM producto WHERE ID='" + ID + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Agregar Insumos a un Producto (receta)
        public void agregarInsumo(string ID_Producto, string ID_Insumo, string volumen)
        {
            string query = "INSERT INTO insumo_producto (id_producto_ipr,id_insumo_ipr,volumen) VALUES('" + ID_Producto + "', '" + ID_Insumo + "', '" + volumen + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        //Eliminar insumos de un producto
        public void eliminarInsumo(string ID_Producto, string ID_Insumo)
        {
            string query = "DELETE FROM insumo_producto WHERE id_producto_ipr='" + ID_Producto + "' AND id_insumo_ipr='" + ID_Insumo + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        //Seleccionar insumos de un producto dado
        public BindingSource SelectInsumos(string id_producto)
        {
            string query = "SELECT ins.id,ins.tipo,ins.nombre, ip.volumen FROM insumo ins INNER JOIN insumo_producto ip ON ins.id = ip.id_insumo_ipr WHERE (ip.id_producto_ipr = '" + id_producto + "')";

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            MyDA.SelectCommand = new MySqlCommand(query, connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            return bSource;
        }

        //Select statement to load datagridview
        public BindingSource SelectProducto(string clave)
        {
            string query = "SELECT id,nombre,precio,precio_desc FROM producto WHERE categoria = '" + clave + "'";


            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            MyDA.SelectCommand = new MySqlCommand(query, connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            return bSource;

        }

        /*       
       //Select statement
       public List<string> SelectProducto(string clave)
       {
           string query = "SELECT * FROM producto WHERE tipo = '" + clave + "'";

           //Create a list to store the result
           List<string> list = new List<string>();

           //Open connection
           if (this.OpenConnection() == true)
           {
               //Create Command
               MySqlCommand cmd = new MySqlCommand(query, connection);
               //Create a data reader and Execute the command
               MySqlDataReader dataReader = cmd.ExecuteReader();

               string id,nombre,precio,precio_desc;  

               //Read the data and store them in the list
               while (dataReader.Read())
               {
                   id = dataReader["id"].ToString();
                   nombre = dataReader["nombre"].ToString();
                   precio = dataReader["precio"].ToString();
                   precio_desc = dataReader["precio_desc"].ToString();
                   list.Add(id);
                   list.Add(nombre);
                   list.Add(precio);
                   list.Add(precio_desc);
               }
               //close Data Reader
               dataReader.Close();

               //close Connection
               this.CloseConnection();

               //return list to be displayed
               return list;
           }
           else
           {
               return list;
           }
       }*/

        // retorna todos los datos del un usuario
        public List<string> SelectProductoFull(string ID)
        {
            string query = "SELECT id, nombre, precio, precio_desc FROM producto WHERE id = '" + ID + "'";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                string Id;
                string nombre;
                string precio;
                string precioDescuento;

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    //Console.WriteLine(String.Format("{0}, {1}",
                    //dataReader.GetString(0), dataReader.GetString(1))
                    //);
                    nombre = dataReader["nombre"].ToString();
                    Id = dataReader["id"].ToString();
                    precio = dataReader["precio"].ToString();
                    precioDescuento = dataReader["precio_desc"].ToString();

                    //Console.WriteLine(cargo+" "+nick);
                    list.Add(Id);
                    list.Add(nombre);
                    list.Add(precio);
                    list.Add(precioDescuento);
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        
        // retorna todos los produtos de una comanda       
        public BindingSource SelectProdComanda(int comanda)
        {
            string query = @"SELECT prod.nombre, pa.cantidad ,prod.precio FROM producto prod INNER JOIN
                            prod_atencion pa ON prod.id = pa.id_producto_pat
                           WHERE (pa.id_comanda_pat = '" + comanda + "')";
            //string query = @"Select * from insumo where (insumo.id = '" + comanda +"')";
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            MyDA.SelectCommand = new MySqlCommand(query, connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            return bSource;
        }
        

        //Count statement
        public int CountProducto(string clave, string campo)
        {
            string query = "SELECT Count(*) FROM producto WHERE " + campo + "='" + clave + "'";
            int Count = -1;

            Console.WriteLine("clave:" + clave + "campo:" + campo);

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}


