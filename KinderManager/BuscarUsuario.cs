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
    public partial class BuscarUsuario : UserControl
    {
        Alumno alumno = null;
        Sql con = new Sql();
        SqlDataReader r = null;
        int modo; 

        public BuscarUsuario(int modo)
        {
            this.modo = modo;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
            cmbUser.SelectedIndex = -1;
            cmbUser.Items.Clear();
            if (this.txtNombre.Text == "" || this.txtApellido.Text == ""  )
                return;
            r = con.getReader("SELECT * FROM Alumno WHERE Nombre LIKE '%" + txtNombre.Text + "%'" + " AND Apellido LIKE '%" + txtApellido.Text + "%'");

            while (r.Read())
               cmbUser.Items.Add(r["Id_alumno"] + " - " + r["Apellido"] + " , " + r["Nombre"]);  
            
            if (cmbUser.Items.Count == 0)
                cmbUser.Items.Add("Sin Resultado");
            cmbUser.SelectedIndex = 0;
            r.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            if (modo == 1 || modo == 2 || modo == 3 || modo == 4) VentanaPrincipal.Interfaz.Controls.Add ( new MenuUsuarios () );
            else if (modo == 5 || modo == 6) VentanaPrincipal.Interfaz.Controls.Add ( new MenuPagos () );
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedItem == null){
                MessageBox.Show("No seleccionó nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Poner en el Excel
                return;
            }
            String row = cmbUser.SelectedItem.ToString();
            if (row.Equals("Sin Resultado")){
                MessageBox.Show("No hay usuario a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Poner en el excel
                return;
            }
            String idUser = null;
            foreach (char algo in row){
                if (algo == '-'){
                    break;
                }
                else{
                    idUser = idUser + algo;
                }
            }
            r = con.getReader("SELECT * FROM Alumno WHERE Id_alumno = " + idUser);
            r.Read();
            alumno = new Alumno((int)r["Id_alumno"]);
            r.Close();

            switch (modo)  // Aquí se ve si se mandan llamar ActualizarUsuario, MostrarUsuario o EliminarUsuario
            {
                case 1:
                    Dispose ();
                    VentanaPrincipal.Interfaz.Controls.Add(new EditarUsuario(alumno, (Procesos_Alumno.ObtenerAdeudos(alumno.getId()))));
                    break;
                case 2:
                    Dispose ();
                    VentanaPrincipal.Interfaz.Controls.Add(new MostrarUsuario(alumno));
                    break;
                case 3:
                    Dispose (); 
                    VentanaPrincipal.Interfaz.Controls.Add (new EliminarUsuario(alumno, (Procesos_Alumno.ObtenerAdeudos(alumno.getId()))));
                    break;
                case 4:
                    Dispose ();
                    VentanaPrincipal.Interfaz.Controls.Add(new UsuarioPadres(alumno));
                    break;
                case 5:
                    if (MessageBox.Show ( "¿Seguro que desea dar de alta a este alumno: " + alumno.getNombre () + " " + alumno.getApellido(),
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes) {
                            if (!Pagos.inscribirAlumno ( alumno.getId () )) return;
                    }
                    Dispose ();
                    VentanaPrincipal.Interfaz.Controls.Add ( new MenuPagos () );
                    break;
                case 6:
                    Dispose ();
                    VentanaPrincipal.Interfaz.Controls.Add ( new EstadoCuenta ( alumno ) );
                    break;
            }
        }
    }
}
