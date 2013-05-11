using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KinderManager
{
    class Procesos_Admin
    {
        static Sql con = null;
        static SqlDataReader r = null;

        public static Boolean Registro(String Nombre, String Apellido, String Pass)
        {
            try
            {
                con = new Sql();
                r = con.getReader("SELECT MAX(id_Usuarios) FROM Usuarios");
                r.Read();
                int id_user = 0;
                if (!r.IsDBNull(0))
                    id_user = (int)r[0] + 1;
                r.Close();

                if (con.executeQuery(String.Format("INSERT INTO USUARIOS VALUES ({0:g},'{1:g}','{2:g}','{3:g}')"
                   , id_user, Nombre, Apellido, Pass)))
                {
                    MessageBox.Show("Administrador registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.closeConnection();
                    return true;
                }

                else
                {
                    con.closeConnection();
                    return false;
                }
            }
            catch
            {
                // 
            }
            return false;
        }

        public static Boolean EliminarAdmin(String Password)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar a este administrador?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        con = new Sql();
                        if (con.executeQuery(String.Format("DELETE FROM USUARIOS WHERE Password = '{0:g}' "
                           ,Password)))
                        {
                            MessageBox.Show("Alumno eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.closeConnection();
                            return true;
                        }
                        else
                        {
                            con.closeConnection();
                            return false;
                        }
                }
            }
            catch
            {
                // 
            }
            return false;
        }

        public static Boolean ModificarAdmin(String Nombre, String Apellido, String oldPass, String newPass)
        {
            try
            {
                con = new Sql();
                if (MessageBox.Show("¿Seguro que desea modificar la contraseña?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        if (con.executeQuery("UPDATE Usuarios SET Password = '" + newPass + "' WHERE Nombre = '" + Nombre + "' AND Apellido = '" + Apellido + "' AND Password = '" + oldPass + "'"))
                        {
                            MessageBox.Show("Password modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.closeConnection();
                            return true;
                        }
                        else
                        {
                            con.closeConnection();
                            return false;
                        }
                }
            }
            catch
            {

                //MessageBox.Show(e.Message);
            }
            return false;
        }

    }
}
