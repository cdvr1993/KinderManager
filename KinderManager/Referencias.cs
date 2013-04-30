using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KinderManager
{
    public partial class Referencias : UserControl
    {
        List<int> t1_id_list;
        List<int> t1_id_selectlist;

        public Referencias()
        {
            InitializeComponent();
            t1_id_list = new List<int>();
            t1_id_selectlist = new List<int>();

            txt_nombre.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_apellido.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_colonia.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_parentesco.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_buscarnombre.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_buscarapellido.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            b_registrar.Click += new EventHandler(this.buttons_Click);
            b_agregarref.Click += new EventHandler(this.buttons_Click);
            b_buscar.Click += new EventHandler(this.buttons_Click);
            b2_buscar.Click += new EventHandler(this.buttons_Click);
            b2_veralum.Click += new EventHandler(this.buttons_Click);
            b2_verref.Click += new EventHandler(this.buttons_Click);
            b2_elimref.Click += new EventHandler(this.buttons_Click);
            b2_cargaref.Click += new EventHandler(this.buttons_Click);
            b1_actref.Click += new EventHandler(this.buttons_Click); ;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar))
            { e.Handled = true;  return;}
            

        }

       
        private void buttons_Click(object sender, EventArgs e)
        {
            if (sender.Equals(b_registrar))
            {
                if (textoVacio())
                {
                    MessageBox.Show("Llene todos los campos antes de registrar la referencia");
                    return;
                }
                else if (alumnosVacio())
                {
                    MessageBox.Show("Agregue alumnos a la referencia antes de registrarla");
                    return;
                }
               

                Sql con = new Sql();
                SqlDataReader r = con.getReader("SELECT MAX(Id_ref) FROM Referencias");
                r.Read();

                int id = (int)r.GetInt32(0) + 1;
                Console.WriteLine(id);

                Sql con2 = new Sql();

                if(con2.executeQuery("INSERT INTO Referencias VALUES (" + id + ", \'" + txt_nombre.Text + "\',\'"
                    + txt_apellido.Text + "\', \'" + txt_calle.Text + "\', \'" + txt_colonia.Text +
                "\', \'" + txt_parentesco.Text + "\', \'" + mtxt_telefono.Text + "\', \'" + mtxt_celular.Text + "\')"))
                    MessageBox.Show("Referencia Registrada");
                else 
                    MessageBox.Show("No se puedo Registrar la Referencia");

                String query = "INSERT INTO [Alumno-Referencia] (Id_alumno, Id_ref) VALUES";

                Console.WriteLine("ID" + t1_id_selectlist[0]);

                for (int i = 0; i < t1_id_selectlist.Count; i++)
                {
                    if (i == t1_id_selectlist.Count - 1)
                        query += "(" + t1_id_selectlist[i] + "," + id + ");";
                    else
                        query += "(" + t1_id_selectlist[i] + "," + id + "),";
                }

                Console.WriteLine(query);
                Sql con3 = new Sql();
                SqlDataReader r3 = con3.getReader(query);

                MessageBox.Show("Referencia registrada con éxito");

            }
            else if (sender.Equals(b_agregarref))
            {
                for (int i = 0; i < chklist_resultados.Items.Count; i++)
                {
                    if (chklist_resultados.GetItemCheckState(i) == CheckState.Checked)
                        // Do selected stuff
                        if (!list_agregar.Items.Contains(chklist_resultados.Items[i]))
                        {
                            list_agregar.Items.Add((String)chklist_resultados.Items[i]);

                            t1_id_selectlist.Add(t1_id_list[i]);
                        }

                }
            }
            else if (sender.Equals(b_buscar))
            {
                chklist_resultados.Items.Clear();

                if (txt_buscarnombre.Text == "" && txt_buscarapellido.Text == "") return;

                Sql con = new Sql();

                String query = "SELECT * FROM Alumno WHERE Nombre LIKE '%" + txt_buscarnombre.Text +
                        "%'" + " AND Apellido LIKE '%" + txt_buscarapellido.Text + "%'";

                Console.WriteLine(query);

                SqlDataReader r = con.getReader(query);

                while (r.Read())
                {

                    String item = "Id: " + r["Id_alumno"] + " Grado: " + r["Grado"]
                        + " Nombre: " + r["Nombre"] + " Apellido: " + r["Apellido"];

                    t1_id_list.Add((int)r["Id_alumno"]);

                    if (!chklist_resultados.Items.Contains(item))
                        chklist_resultados.Items.Add(item, false);
                } 
            }
            else if (sender.Equals(b2_buscar)){
                
                dataGridView1.Rows.Clear();
                

                if (txt2_buqueda.Text == "") return;

                int selectindex = combo2_busqueda.SelectedIndex;
                Sql con = new Sql();
                Sql con2 = new Sql();
                SqlDataReader r = null;


                if (selectindex == -1) 
                    return;
                else if (selectindex == 0)
                {
                    r = con.getReader("SELECT * FROM Referencias WHERE Nombre LIKE '%" +
                       txt2_buqueda.Text + "%' AND Apellido LIKE '%" + txt2_buscarapellido.Text + "%'");

                    while (r.Read())
                    {
                        dataGridView1.Rows.Add(r["Id_ref"], r["Nombre"], r["Apellido"]);
                    }
                }
                else if (selectindex == 1)
                {

                   
                    r = con.getReader("SELECT * FROM Alumno WHERE Nombre LIKE '%" +
                       txt2_buqueda.Text + "%' AND Apellido LIKE '%" + txt2_buscarapellido.Text + "%'");

                    while (r.Read())
                    {
                        dataGridView2.Rows.Add(r["Id_alumno"], r["Nombre"], r["Grado"]);
                    }

                }
             
            }else if(sender.Equals(b2_veralum))
            {
                Sql con = new Sql();
                SqlDataReader r;

                dataGridView2.Rows.Clear();

                int id_ref = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                if (id_ref < 0) return;

                Sql con3 = new Sql();
                r = con3.getReader("SELECT Alumno.* FROM ALUMNO INNER JOIN [Alumno-Referencia] ON alumno.Id_alumno = [Alumno-Referencia].Id_alumno INNER JOIN Referencias ON Referencias.Id_ref = [Alumno-Referencia].Id_ref WHERE Referencias.Id_ref = " + id_ref);

                while (r.Read())
                {
                    dataGridView2.Rows.Add(r["Id_alumno"],r["Nombre"] + " " + r["Apellido"], r["Grado"]);
                }

             }
            else if (sender.Equals(b2_verref))
            {
                Sql con = new Sql();
                SqlDataReader r;

                dataGridView1.Rows.Clear();

                int id_alum = (int)dataGridView2.SelectedRows[0].Cells[0].Value;

                if (id_alum < 0) return;

                Sql con3 = new Sql();
                r = con3.getReader("SELECT *  FROM Referencias, [Alumno-Referencia]" +  
                   "WHERE [Alumno-Referencia].Id_alumno = " + id_alum + " AND Referencias.Id_ref = [Alumno-Referencia].Id_ref");

                while (r.Read())
                {
                    dataGridView1.Rows.Add(r["Id_ref"],r["Nombre"], r["Apellido"]);
                }

            }
            else if (sender.Equals(b2_elimref))
            {
                Sql con = new Sql();
   

                dataGridView2.Rows.Clear();

                int id_ref = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                if (id_ref < 0) return;

                if(con.executeQuery("DELETE FROM Referencias WHERE Id_ref = " + id_ref +
                    "; DELETE FROM [Alumno-Referencia] WHERE Id_ref = " + id_ref)) 
                    MessageBox.Show("Registro Eliminado");
                else
                    MessageBox.Show("No se pudo eliminar el registro");

                MessageBox.Show("Referencia Eliminada");

            }
            else if (sender.Equals(b2_cargaref))
            {
                tabc_ref.SelectedIndex = 0;

                int id_ref = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                if (id_ref < 0) return;

                Sql con = new Sql();
                SqlDataReader r = con.getReader("SELECT * FROM Referencias WHERE Id_ref = " + id_ref);
                r.Read();

                txt_nombre.Text = r["Nombre"].ToString();
                
                txt_apellido.Text = (string)r["Apellido"].ToString();
                txt_calle.Text = (string)r["Calle"].ToString();
                txt_colonia.Text = (string)r["Colonia"].ToString();
                mtxt_celular.Text = (string)r["Celular"].ToString();
                mtxt_telefono.Text = (string)r["Telefono"].ToString();
                txt_parentesco.Text = (string)r["Parentesco"].ToString();
                 
            }
            else if(sender.Equals(b1_actref))
            {
                if (textoVacio())
                {
                    MessageBox.Show("Llene todos los campos antes de registrar la referencia");
                    return;
                }
                else if(dataGridView1.Rows.Count == 0){
                    MessageBox.Show("Selecciona en la ventana de Busqueda, a la referencia a reemplazar");
                }



                int id_ref = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                if (id_ref < 0)
                {
                    MessageBox.Show("Selecciona una referencia en la pestaña de busquedas");
                    tabc_ref.SelectedIndex = 1;
                    return;
                }

                Sql con = new Sql();

                Console.WriteLine("UPDATE Referencias SET " +
                "Nombre = \'" + txt_nombre.Text + "\', " +
                "Apellido = \'" + txt_apellido.Text + "\', " + "Calle = \'" + txt_calle.Text + "\', "
                + "Colonia = \'" + txt_colonia.Text + "\', " + "Parentesco = \'" + txt_parentesco.Text + "\', "
                + "Telefono = \'" + mtxt_telefono.Text + "\', " + "Apellido = \'" + mtxt_celular.Text + "\' " +
                "WHERE Id_ref = " + id_ref);

                if (con.executeQuery("UPDATE Referencias SET " +
                "Nombre = \'" + txt_nombre.Text + "\', " +
                "Apellido = \'" + txt_apellido.Text + "\', " + "Calle = \'" + txt_calle.Text + "\', "
                + "Colonia = \'" + txt_colonia.Text + "\', " + "Parentesco = \'" + txt_parentesco.Text + "\', "
                + "Telefono = \'" + mtxt_telefono.Text + "\', " + "Celular = \'" + mtxt_celular.Text + "\' " +
                "WHERE Id_ref = " + id_ref)) MessageBox.Show("Referencia Actualizada");
                else 
                    MessageBox.Show("No se pudo actualizar el registro");
                

            }
            
            

        }

        private Boolean textoVacio()
        {
            if (txt_apellido.Text == "" || txt_nombre.Text == "" || txt_calle.Text == "" || txt_colonia.Text == ""
                || txt_parentesco.Text == "" || mtxt_celular.Text == "" || mtxt_telefono.Text == "")
                return true;

            return false;
        }

        private Boolean alumnosVacio()
        {

            if (list_agregar.Items.Count < 1)
                return true;
                
            return false;
        }

        private void Ventana_P_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void regresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new MenuUsuarios());
        }

       

    }
}
