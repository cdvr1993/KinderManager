using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KinderManager
{
    public partial class Ventana_Padres : UserControl
    {

        int madre_o_padre = -1;

        public Ventana_Padres()
        {
            InitializeComponent();

            txt1_nombre.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt1_apellido.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt1_empresa.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt1_ocupacion.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            b1_registrar.Click += new EventHandler(this.buttons_Click);
            b2_buscar.Click += new EventHandler(this.buttons_Click);
            b2_cargardatos.Click += new EventHandler(this.buttons_Click);
            b1_actualizar.Click += new EventHandler(this.buttons_Click);
            b2_eliminar.Click += new EventHandler(this.buttons_Click);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar))
            { e.Handled = true; return; }

        }

        private void buttons_Click(object sender, EventArgs e)
        {
            if (sender.Equals(b1_registrar))
            {

                Padres parent = new Padres(txt1_nombre.Text, txt1_apellido.Text, txt1_ocupacion.Text,
                    txt1_empresa.Text, mtxt_telefono.Text, mtxt_celular.Text, txt1_email.Text);

                if (parent.areFieldsEmpty())
                {
                    MessageBox.Show("Llene todos los campos");
                    return;
                }
                else if (!parent.isValidEmail())
                {
                    MessageBox.Show("El email que ingresaste no es valido");
                }
                
                Sql con = new Sql();
                String query = "", query2 = "", query3 = "";

                if (cmb1_MH.SelectedIndex == 0) { query = "SELECT MAX(Id_madre) FROM Madres_alumno";
                query2 = "INSERT INTO Madres_alumno ";
                query3 = "SELECT * FROM Madres_alumno ";
                }
                else {query = "SELECT MAX(Id_padre) FROM Padres_alumno ";
                query2 = "INSERT INTO Padres_alumno";
                query3 = "SELECT * FROM Padres_alumno ";
                }

                SqlDataReader r = con.getReader(query);
                r.Read();

                int id = 0;

                if (r.Read())
                    if (!r.IsDBNull(0))
                        id = r.GetInt32(0);

                Sql con_check = new Sql();
                Console.WriteLine(query3 + "WHERE Nombre = '" + txt1_nombre.Text + "' "
                    + "AND Apellido = '" + txt1_apellido.Text + "' AND Email = '" + txt1_email.Text + "'");
                SqlDataReader check = con_check.getReader(query3 + "WHERE Nombre = '" + txt1_nombre.Text + "' "
                    + "AND Apellido = '" + txt1_apellido.Text + "' AND Email = '" + txt1_email.Text + "'");

                if (check.Read())
                {
                    if (!check.IsDBNull(0))
                    {
                        MessageBox.Show("Este usuario ya ha sido registrado registrado");
                        return;
                    }
                }


                Sql con2 = new Sql();

                if (con2.executeQuery(query2 + " VALUES (" + id + ", \'" + parent.getNombre() + "\',\'"
                    + parent.getApellido() + "\', \'" + parent.getOcupacion() + "\', \'" + parent.getEmpresa() +
                "\', \'" + parent.getTelefono() + "\', \'" + parent.getCelular() + "\', \'" + parent.getEmail() + "\')"))
                    MessageBox.Show("Padre Registrado");
                else
                    MessageBox.Show("No se pudo registrar el padre");
            }
            else if(sender.Equals(b1_actualizar))
            {
                
                Padres parent = new Padres(txt1_nombre.Text, txt1_apellido.Text, txt1_ocupacion.Text,
                    txt1_empresa.Text, mtxt_telefono.Text, mtxt_celular.Text, txt1_email.Text);

                if (parent.areFieldsEmpty())
                {
                    MessageBox.Show("Llene todos los campos");
                    return;
                }
                else if (!parent.isValidEmail())
                {
                    MessageBox.Show("El email que ingresaste no es valido");
                }

                int id_ref = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                Sql con = new Sql();

                if (madre_o_padre == 0)
                {
                    if (con.executeQuery("UPDATE Padres_alumno SET " +
                    "Nombre = \'" + parent.getNombre() + "\', " +
                    "Apellido = \'" + parent.getApellido() + "\', " + "Ocupacion = \'" + parent.getOcupacion() +
                    "\', Empresa = \'" + parent.getEmpresa() + "\', " + "Telefono = \'" + parent.getTelefono() +
                    "\', Celular = \'" + parent.getCelular() + "\', " + "Email = \'" + parent.getEmail() + "\' " +
                    "WHERE Id_padre = " + id_ref))
                        MessageBox.Show("Se ha actualizado el padre");
                }
                else
                {
                    if (con.executeQuery("UPDATE Madres_alumno SET " +
                    "Nombre = \'" + parent.getNombre() + "\', " +
                    "Apellido = \'" + parent.getApellido() + "\', " + "Ocupacion = \'" + parent.getOcupacion() +
                    "\', Empresa = \'" + parent.getEmpresa() + "\', " + "Telefono = \'" + parent.getTelefono() +
                    "\', Celular = \'" + parent.getCelular() + "\', " + "Email = \'" + parent.getEmail() + "\' " +
                    "WHERE Id_madre = " + id_ref))
                        MessageBox.Show("Se ha actualizado la madre");
                }

                



            }
            else if (sender.Equals(b2_buscar))
            {
                dataGridView1.Rows.Clear();

                Sql con = new Sql();
                String table = "", id = "";

                if (cmb2_selec.SelectedIndex == 0)
                {
                    table = "Madres_Alumno";
                    id = "Id_madre";
                }
                else if (cmb2_selec.SelectedIndex == 1)
                {
                    table = "Padres_Alumno";
                    id = "Id_padre";
                }
                else if(cmb2_selec.SelectedIndex == 2)
                {
                    Sql con2 = new Sql();

                    SqlDataReader r = con.getReader("SELECT P.Id_padre, P.Nombre, P.Apellido, P.Telefono, P.Celular, " + 
                    "P.Email FROM Alumno , Padres_alumno AS P WHERE Alumno.Id_padre = P.Id_padre " +  
                    "AND Alumno.Nombre LIKE '%" + txt2_buscarnombre.Text + "%' AND Alumno.Apellido LIKE " + 
                    "'%" + txt2_buscarapellido.Text + "%'");

                    SqlDataReader r2 = con2.getReader("SELECT M.Id_madre, M.Nombre, M.Apellido, M.Telefono, M.Celular, " +
                     "M.Email FROM Alumno , Madres_alumno AS M WHERE Alumno.Id_madre = M.Id_madre " +
                     "AND Alumno.Nombre LIKE '%" + txt2_buscarnombre.Text + "%' AND Alumno.Apellido LIKE " +
                     "'%" + txt2_buscarapellido.Text + "%'");

                    while (r.Read())
                    {
                        dataGridView1.Rows.Add(r["Id_padre"], r["Nombre"] + " " +  r["Apellido"], r["Telefono"], 
                            r["Celular"], r["Email"]);
                    }

                    while (r2.Read())
                    {
                        dataGridView1.Rows.Add(r2["Id_madre"], r2["Nombre"] + " " + r2["Apellido"], r2["Telefono"],
                               r2["Celular"], r2["Email"]);
                    }

                    return;
                }

                SqlDataReader rn = con.getReader("SELECT * FROM " + table + " WHERE Nombre LIKE '%" + 
                        txt2_buscarnombre.Text + "%'" + " AND Apellido LIKE '%" + txt2_buscarapellido.Text + "%'");

                while (rn.Read())
                {
                    dataGridView1.Rows.Add(rn[id], rn["Nombre"], rn["Apellido"], rn["Telefono"], rn["Celular"], rn["Email"]);
                }

            }//end of buscar
            else if (sender.Equals(b2_cargardatos))
            {
                if (dataGridView1.Rows.Count == 0) { MessageBox.Show("Selecciona una fila válida"); return; }

                tabControl1.SelectedIndex = 0;

                int id_ref = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                String email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                Sql con = new Sql();
                Sql con2 = new Sql();

                SqlDataReader r = null;

                if (cmb2_selec.SelectedIndex == 0)
                {
                    r = con.getReader("SELECT * FROM Madres_alumno WHERE Id_madre = " + id_ref);
                    madre_o_padre = 1;
                }
                else if (cmb2_selec.SelectedIndex == 1)
                {
                    r = con.getReader("SELECT * FROM Padres_alumno WHERE Id_padre = " + id_ref);
                    madre_o_padre = 0;
                }
                else if (cmb2_selec.SelectedIndex == 2)
                {
                    r = con.getReader("SELECT * FROM Padres_alumno WHERE Email = '" + email + "'");
                    madre_o_padre = 0;

                    if (!r.Read())
                    {
                        r = null;
                        r = con2.getReader("SELECT * FROM Madres_alumno WHERE Id_madre = " + id_ref);
                        madre_o_padre = 1;
                    }


                }

                r.Read();

                txt1_nombre.Text = r["Nombre"].ToString();
                txt1_apellido.Text = r["Apellido"].ToString();
                txt1_ocupacion.Text = r["Ocupacion"].ToString();
                txt1_empresa.Text = r["Empresa"].ToString();
                txt1_email.Text = r["Email"].ToString();
                mtxt_celular.Text = r["Celular"].ToString();
                mtxt_telefono.Text = r["Telefono"].ToString();



            }
            else if(sender.Equals(b2_eliminar))//else if its button eliminar
            { 
                if (dataGridView1.Rows.Count == 0) { MessageBox.Show("Selecciona una fila válida"); return; }

                int id_ref = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                String email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                Sql con = new Sql();
                Sql con2 = new Sql();

                SqlDataReader r = null;

                if (cmb2_selec.SelectedIndex == 0)
                {
                    madre_o_padre = 0;
                }
                else if (cmb2_selec.SelectedIndex == 1)
                {
                    madre_o_padre = 1;
                }
                else//tiene seleccionado alumnos
                {
                    r = con.getReader("SELECT * FROM Padres_alumno WHERE Email = '" + email + "'");
                    madre_o_padre = 0;

                    if (!r.Read())
                    {
                        r = null;
                        r = con2.getReader("SELECT * FROM Madres_alumno WHERE Id_madre = " + id_ref);
                        madre_o_padre = 1;
                    }
                }

                if (madre_o_padre == 0)
                {
                    if (con.executeQuery("DELETE FROM Madres_alumno WHERE Id_madre = " + id_ref))
                        MessageBox.Show("Registro eliminado");
                    else
                        MessageBox.Show("No se pudo eliminar el registro");
                }
                else if (madre_o_padre == 1)
                {
                    if (con.executeQuery("DELETE FROM Padres_alumno WHERE Id_padre = " + id_ref))
                        MessageBox.Show("Registro eliminado");
                    else
                        MessageBox.Show("No se pudo eliminar el registro");
                }

                dataGridView1.Rows.Clear();

            }//fin del eliminar

        }

        private void regresarToolStripMenuItem_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new Menu () );
        }

        private void salirToolStripMenuItem_Click ( object sender, EventArgs e ) {
            Application.Exit ();
        }
    }
}
