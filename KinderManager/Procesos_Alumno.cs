using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KinderManager
{
    class Procesos_Alumno
    {
        static Sql con = null;
        static SqlDataReader r = null;

        public static Boolean Registro(String Nombre, String Apellido, DateTime Nacimiento, String Sangre, String Calle, String Colonia, String Telefono, int padre, int madre, int grado, String grupo, int mod_pago, bool Acta, bool copyActa, bool copyCartilla, String Curp)
        {
            try
            {
                con = new Sql();
                r = con.getReader("SELECT MAX(Id_alumno) FROM Alumno");
                r.Read();
                int id_alumno = 0;
                if (!r.IsDBNull(0))
                    id_alumno = (int)r[0] + 1;
                r.Close();

                if (con.executeQuery(String.Format("INSERT INTO ALUMNO VALUES ({0:g},'{1:g}','{2:g}','{3:yyyy-MM-dd}','{4:g}','{5:g}','{6:g}','{7:g}',NULL, NULL,{10:g},'{11:g}',{12:g}, NULL)"
                   , id_alumno, Nombre, Apellido, Nacimiento, Sangre, Calle, Colonia, Telefono, null, null, grado, grupo, mod_pago, null)))
                {
                    con.closeConnection();
                    con = new Sql();
                    if (con.executeQuery("INSERT INTO DOCUMENTACION VALUES ( " + id_alumno + ",'" + Acta + "','" + copyActa + "','" + Curp + "','" + copyCartilla + "')"))
                    {
                        MessageBox.Show("Alumno registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.closeConnection();
                        return true;
                    }
                    else
                    {
                        con.closeConnection();
                        return false;
                    }
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


        public static float ObtenerAdeudos(int id_Alumno)
        {
            List<Pagos> nuevo = Pagos.getAllPagosFromStudent(id_Alumno);
            float adeudos = 0;

            if (nuevo != null)
            {
                foreach (Pagos adeudo in nuevo)
                {
                    if (adeudo.Liquidado == false)
                        adeudos += adeudo.total;
                }
            }
            return adeudos;
        }


        public static Boolean EliminarAlumno(Alumno alumno, float adeudos)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar a este alumno?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (adeudos == 0)
                    {
                        con = new Sql();
                        if (con.executeQuery(String.Format("DELETE FROM ALUMNO WHERE Id_alumno = {0:g} "
                           , alumno.getId())))
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

                    else
                    {
                        MessageBox.Show("No puede eliminar a un alumno que presenta adeudos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static String ObtenerModalidadPago(int mod)
        {
            try
            {
                con = new Sql();
                r = con.getReader("SELECT * FROM Informacion_pago WHERE Id_Modalidad = " + mod);
                r.Read();
                String modalidad = "";
                int i = 0;
                do
                {
                    if (i == 0 || i == 1)
                        modalidad = "Prekinder. Inscripción: $" + r["Inscripcion"] + " Colegiatura: $" + r["Colegiatura"];

                    else
                    {
                        modalidad = "Kinder. Inscripción: $" + r["Inscripcion"] + " Colegiatura: $" + r["Colegiatura"];
                    }
                    i++;

                } while (r.Read());
                r.Close(); // oJO
                con.closeConnection();
                return modalidad;
            }
            catch
            {
            }

            return "";
        }

        public static String[] obtenerPadre(int id_Padre)
        {
            if (id_Padre == 0)
                return null;
            try
            {
                con = new Sql();
                r = con.getReader("SELECT Nombre, Apellido, Celular FROM Padres_Alumno WHERE Id_padre = " + id_Padre);
                r.Read();
                String tel = "";
                if (r["Celular"].ToString().Equals(""))
                    tel = "No hay dato";
                else
                    tel = r["Celular"].ToString();
                String[] datos = { r["Nombre"].ToString(), r["Apellido"].ToString(), tel };
                con.closeConnection();
                return datos;
            }
            catch
            {
            }
            return null;
        }

        public static String[] obtenerMadre(int id_Madre)
        {
            if (id_Madre == 0)
                return null;
            try
            {
                con = new Sql();
                r = con.getReader("SELECT Nombre, Apellido, Celular FROM Madres_Alumno WHERE Id_madre = " + id_Madre);
                r.Read();
                String tel = "";
                if (r["Celular"].ToString().Equals(""))
                    tel = "No hay dato";
                else
                    tel = r["Celular"].ToString();
                String[] datos = { r["Nombre"].ToString(), r["Apellido"].ToString(), tel };
                con.closeConnection();
                return datos;
            }
            catch
            {
            }
            return null;
        }

        public static Boolean ModificarAlumno(Alumno alumno, float adeudos)
        {
            try
            {
                con = new Sql();
                if (MessageBox.Show("¿Seguro que desea modificar los datos de este alumno?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (adeudos == 0)
                    {
                        if (con.executeQuery("UPDATE Alumno SET Nombre = '" + alumno.getNombre() + "', Apellido = '" + alumno.getApellido() + "', Nacimiento = '" + alumno.getNacimiento().Year + "/" + alumno.getNacimiento().Month + "/" + alumno.getNacimiento().Day + "', Tipo_Sangre = '" + alumno.getSangre() + "', Calle = '" + alumno.getCalle() + "', Colonia = '" + alumno.getColonia() + "', Telefono = '" + alumno.getTelefono() + "', Grado = " + alumno.getGrado() + ", Grupo = '" + alumno.getGrupo() + "', Modalidad_pago = " + alumno.getModalidad() + " WHERE Id_alumno = " + alumno.getId()))
                        {
                            MessageBox.Show("Datos modificados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.closeConnection();
                            return true;
                        }
                        else
                        {
                            con.closeConnection();
                            return false;
                        }
                    }

                    else
                    {
                        MessageBox.Show("No puede modificar los datos de un alumno que presenta adeudos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static Boolean RegistrarDocumentacion(int idAlumno, bool Acta, bool copyActa, bool copyCartilla, String CURP)
        {
            try
            {
                if (CURP.Equals(""))
                    CURP = "No Hay Dato";
                con = new Sql();
                if (con.executeQuery("INSERT INTO DOCUMENTACION VALUES ( " + idAlumno + ",'" + Acta + "','" + copyActa + "','" + CURP + "','" + copyCartilla + "')"))
                {
                    MessageBox.Show("Documentación registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static String[] obtenerDocumentacion(int id_Alumno)
        {
            try
            {
                con = new Sql();
                r = con.getReader("SELECT Acta, Copias_Acta, Copia_Cartilla, Curp FROM Documentacion WHERE Id_alumno = " + id_Alumno);
                r.Read();
                String Acta = "No Entregada", Copy_Acta = "No Entregada", Copy_Cartilla = "No Entregada", Curp = "Entregada";
                if ((bool)r["Acta"])
                    Acta = "Entregada";
                if ((bool)r["Copias_Acta"])
                    Copy_Acta = "Entregada";
                if ((bool)r["Copia_Cartilla"])
                    Copy_Cartilla= "Entregada";
                Curp = r["Curp"].Equals("") ? "No Hay Datos" : (String) r["Curp"]; 
                String[] datos = {Acta, Copy_Acta, Copy_Cartilla, Curp};
                con.closeConnection();
                r.Close();
                return datos;
            }
            catch
            {
            }
            return null;
        }

        public static Boolean[] obtenerDocuBool(int id_Alumno)
        {
            try
            {
                con = new Sql();
                r = con.getReader("SELECT Acta, Copias_Acta, Copia_Cartilla FROM Documentacion WHERE Id_alumno = " + id_Alumno);
                r.Read();
                Boolean Acta = false, Copy_Acta = false, Copy_Cartilla = false;
                if ((bool)r["Acta"])
                    Acta = true;
                if ((bool)r["Copias_Acta"])
                    Copy_Acta = true;
                if ((bool)r["Copia_Cartilla"])
                    Copy_Cartilla = true;
                Boolean [] datos = { Acta, Copy_Acta, Copy_Cartilla};
                con.closeConnection();
                return datos;
            }
            catch
            {
            }
            return null;
        }

        public static Boolean ModificarDocumentacion(int id_Alumno, bool Acta, bool copyActa, bool copyCartilla, String CURP)
        {
            try
            {
                con = new Sql();
                if (con.executeQuery("UPDATE Documentacion SET Acta = '" + Acta + "', Copias_Acta = '" + copyActa + "', Copia_Cartilla = '" + copyCartilla + "', Curp = '" + CURP + "' WHERE Id_alumno = " + id_Alumno))
                {
                    MessageBox.Show("Documentación modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                //MessageBox.Show(e.Message);
            }
            return false;
        }

        public static List<Alumno> ReporteAlumnos(int grado, String grupo)
        {
            con = new Sql();
            r = con.getReader("SELECT Id_Alumno FROM Alumno WHERE Grado = " + grado + " AND Grupo = '" + grupo + "' ORDER BY (Apellido)");
            List<Alumno> nuevo = new List<Alumno>();
            while (r.Read())
            {
                Alumno alumno = new Alumno((int)r["Id_Alumno"]);
                nuevo.Add(alumno);
            }
            r.Close();
            if (nuevo.Count > 0)
                return nuevo;
            else
                return null;
        }

        public static Boolean asignarPadre(int id_Alumno, int id_Padre)
        {
            try
            {
                con = new Sql();
                if (con.executeQuery("UPDATE Alumno SET Id_Padre = " + id_Padre + " WHERE Id_alumno = " + id_Alumno))
                {
                    MessageBox.Show("Padre asignado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.closeConnection();
                    return true;
                }
                else
                {
                    con.closeConnection();
                    return false;
                }
            }
            catch { return false; }
        }

        public static Boolean asignarMadre(int id_Alumno, int id_Madre)
        {
            try
            {
                con = new Sql();
                if (con.executeQuery("UPDATE Alumno SET Id_Madre = " + id_Madre + " WHERE Id_alumno = " + id_Alumno))
                {
                    MessageBox.Show("Madre asignada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.closeConnection();
                    return true;
                }
                else
                {
                    con.closeConnection();
                    return false;
                }
            }
            catch { return false; }
        }
    }
}