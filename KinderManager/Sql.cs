using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KinderManager
{
    class Sql
    {
        private const String conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=Kinder;Persist Security Info=True;User ID=root;Password=toor";
        private SqlConnection con = null;
        public Sql()
        {
            //Crea una nueva conexión usando el String de conexión.
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error 1000: No se puede conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SqlDataReader getReader(String query)
        {
            //Ejecuta una búsqueda en la base de datos y devuelve el conjunto de resultados.
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                return cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error 1001: No se puede ejecutar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public Boolean executeQuery(String query)
        {
            //Ejecuta una acción de registro de un nuevo campo, una modificación de un registro o se borraa un registro.
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                    return true;
            }
            catch (SqlException e)
            {

               // Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                MessageBox.Show("Error 1002: No se puede actualizar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public void closeConnection() { con.Close(); } //Finaliza la conexión, no es tan necesario ya que cuando dejas de usar la instancia
            //se cierra, pero se recomienda su uso.
    }
}
