using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinderManager
{
    public partial class ReporteAlumnos: UserControl 
    {
        public ReporteAlumnos()
        {
            this.tablaUser = null;
            InitializeComponent();
            this.cmbGrado.SelectedIndex = 0;
            this.cmbGrupo.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            tablaUser.Rows.Clear(); 
            int grado = cmbGrado.SelectedIndex;
            String grupo = (String)cmbGrupo.SelectedItem;
            List<Alumno> nuevo = Procesos_Alumno.ReporteAlumnos(grado, grupo);
            if (nuevo != null)
            {
                foreach (Alumno alumno in nuevo)
                {
                    string[] row = null;
                    row = new string[] { alumno.getApellido(), alumno.getNombre(), alumno.getNacimiento().Day.ToString() + "/" + alumno.getNacimiento().Month.ToString() + "/" + alumno.getNacimiento().Year.ToString(), alumno.getSangre(), alumno.getGrado().ToString(), alumno.getGrupo(), alumno.getCalle(), alumno.getColonia(), alumno.getTelefono()};
                    tablaUser.Rows.Add(row);
                }
            }
        }

        private void btnCancelar_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new MenuUsuarios () );
        }
    }
}