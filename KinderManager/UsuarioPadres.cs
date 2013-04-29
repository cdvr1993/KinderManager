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
    public partial class UsuarioPadres : UserControl 
    {
        Alumno alumno;
        Sql con = new Sql();
        SqlDataReader r = null;

        public UsuarioPadres(Alumno alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
            this.Show(); 
        }

        private void btnBuscarMadre_Click(object sender, EventArgs e)
        {
            txtNombreMadre.Focus();
            cmbMadre.SelectedIndex = -1;
            cmbMadre.Items.Clear();

            if (this.txtNombreMadre.Text == "" || this.txtApellidoMadre.Text == "")
                return;
            r = con.getReader("SELECT * FROM Madres_Alumno WHERE Nombre LIKE '%" + txtNombreMadre.Text + "%'" + " AND Apellido LIKE '%" + txtApellidoMadre.Text + "%'");
            while (r.Read())
                cmbMadre.Items.Add(r["Id_madre"] + " - " + r["Apellido"] + " , " + r["Nombre"]);
            if (cmbMadre.Items.Count == 0)
                cmbMadre.Items.Add("Sin Resultado");
            cmbMadre.SelectedIndex = 0;
            r.Close();
        }

        private void btnBuscarPadre_Click(object sender, EventArgs e)
        {
            txtNombrePadre.Focus();
            cmbPadre.SelectedIndex = -1;
            cmbPadre.Items.Clear();

            if (this.txtNombrePadre.Text == "" || this.txtApellidoPadre.Text == "")
                return;
            r = con.getReader("SELECT * FROM Padres_Alumno WHERE Nombre LIKE '%" + txtNombrePadre.Text + "%'" + " AND Apellido LIKE '%" + txtApellidoPadre.Text + "%'");
            while (r.Read())
                cmbPadre.Items.Add(r["Id_padre"] + " - " + r["Apellido"] + " , " + r["Nombre"]);
            if (cmbPadre.Items.Count == 0)
                cmbPadre.Items.Add("Sin Resultado");
            cmbPadre.SelectedIndex = 0;
            r.Close();
        }

        private void btnAceptarPadre_Click(object sender, EventArgs e)
        {
            if (cmbPadre.SelectedItem == null)
            {
                MessageBox.Show("No seleccionó nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Poner en el Excel
                return;
            }

            String row = cmbPadre.SelectedItem.ToString();

            if (row.Equals("Sin Resultado"))
            {
                MessageBox.Show("No hay papá a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Poner en el excel
                return;
            }

            String idPadre = null;

            foreach (char algo in row)
            {
                if (algo == '-')
                {
                    break;
                }
                else
                {
                    idPadre = idPadre + algo;
                }
            }

            r = con.getReader("SELECT Id_padre FROM Padres_Alumno WHERE Id_padre = " + idPadre);
            r.Read();
            int id_Padre = (int)r["Id_Padre"];
            r.Close();

            bool chequeo = Procesos_Alumno.asignarPadre(alumno.getId(), id_Padre);
            if (chequeo == false)
                MessageBox.Show("Error al intentar asignar el papá al alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAceptarMadre_Click(object sender, EventArgs e)
        {
            if (cmbMadre.SelectedItem == null)
            {
                MessageBox.Show("No seleccionó nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Poner en el Excel
                return;
            }

            String row = cmbMadre.SelectedItem.ToString();

            if (row.Equals("Sin Resultado"))
            {
                MessageBox.Show("No hay mamá a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Poner en el excel
                return;
            }

            String idMadre = null;

            foreach (char algo in row)
            {
                if (algo == '-')
                {
                    break;
                }
                else
                {
                    idMadre = idMadre + algo;
                }
            }

            r = con.getReader("SELECT Id_madre FROM Madres_Alumno WHERE Id_madre = " + idMadre);
            r.Read();
            int id_Madre = (int)r["Id_madre"];
            r.Close();

            bool chequeo = Procesos_Alumno.asignarMadre(alumno.getId(), id_Madre); 
            if (chequeo == false)
                MessageBox.Show("Error al intentar asignar la mamá al alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
