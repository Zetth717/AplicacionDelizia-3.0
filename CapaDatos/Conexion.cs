using MySql.Data.MySqlClient;
using MySqlConnector;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;

namespace CapaDatos
{
    public class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "base_delizia";
        private string user = "root";
        private string password = "";
        private string cadena_conexion;

        public Conexion()
        {
            // server = "10.0.0.100";
            // password = "";
            cadena_conexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id=" + user +
                "; Password=" + password;
        }

        public MySqlConnection abrir_conexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadena_conexion);
                conexion.Open();
            }
            return conexion;
        }
        public List<List<string>> consultar(string consulta)
        {
            abrir_conexion();
            List<List<string>> resultados = new List<List<string>>();
            MySqlDataReader mySqlDataReader = null;

            if (conexion != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = abrir_conexion();
                mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    List<string> valores_columnas = new List<string>();

                    for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                    {
                        valores_columnas.Add(mySqlDataReader[i].ToString());
                    }

                    resultados.Add(valores_columnas);
                }
                mySqlDataReader.Close();
            }
            cerrar_conexion();
            return resultados;
        }

        public void modificar(string cadena)
        {
            abrir_conexion();
            if (conexion != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(cadena);
                mySqlCommand.Connection = abrir_conexion();
                mySqlCommand.ExecuteNonQuery();
            }
            cerrar_conexion();
        }

        public void cerrar_conexion()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
    }
}
