using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

//to use DataTable
using System.Data;

//Add MySql Library
using MySql.Data.MySqlClient;

namespace ConnectCsharpToMysql
{
    class StockConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public StockConnect()
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
                        MessageBox.Show("No se pudo conectar con el servidor.  Contacte a un administrador");
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
        public void InsertStock(string id_insumo, string id_barra, string volumen, string cantidad)
        {
            string query = "INSERT INTO Stock (id_inusmo_ist, id_barra_ist, volumen, cantidad) VALUES('" + id_insumo + "', '" + id_barra + "', '" + volumen + "', '" + cantidad + "')";

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
        public void UpdateInsumo(string ID, string nom, string tipo, string volumen)
        {
            string query;
            //UPDATE `smiav_db`.`usuario` SET `clave`='1234', `cargo`='Mesero', `nick`='jorguito', `nombre`='Jorge ' WHERE `rut`='16245345-1';
            Console.WriteLine("volumen: "+volumen+" id: "+ID);
            query = "UPDATE insumo SET id='" + ID + "' , nombre='" + nom + "' , tipo='" + tipo + "' , volumen='" + volumen + "' WHERE ID='" + ID + "' ";

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
        public void DeleteInsumo(string ID)
        {
            string query = "DELETE FROM insumo WHERE id='" + ID + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement to load datagridview
        public BindingSource SelectStock()
        {
            string query = "SELECT i.nombre, i.tipo, i.volumen, i_s.volumen_total, i_s.id_barra_ist FROM insumo as i, insumo_stock as i_s where i.id=i_s.id_insumo_ist;";


            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            MyDA.SelectCommand = new MySqlCommand(query, connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            return bSource;
            
                
        }

        // retorna todos los datos del un insumo
        public List<string> SelectInsumoFull(string ID)
        {
            string query = "SELECT id, nombre, tipo, volumen FROM insumo WHERE id = '" + ID + "'";

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
                string tipo;
                string volumen;

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    //Console.WriteLine(String.Format("{0}, {1}",
                    //dataReader.GetString(0), dataReader.GetString(1))
                    //);
                    nombre = dataReader["nombre"].ToString();
                    Id = dataReader["id"].ToString();
                    tipo = dataReader["tipo"].ToString();
                    volumen = dataReader["volumen"].ToString();

                    //Console.WriteLine(cargo+" "+nick);
                    list.Add(Id);
                    list.Add(nombre);
                    list.Add(tipo);
                    list.Add(volumen);
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

        //Count statement
        public int CountInsumo(string clave, string campo)
        {
            string query = "SELECT Count(*) FROM insumo WHERE " + campo + "='" + clave + "'";
            int Count = -1;

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
