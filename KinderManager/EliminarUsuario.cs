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
    public partial class EliminarUsuario : UserControl 
    {
       Alumno alumno;
       float adeudos;

        public EliminarUsuario(Alumno alumno, float adeudos)
        {
            this.alumno = alumno;
            this.adeudos = adeudos;
            InitializeComponent();
            anadirCeldas();
            this.Show();
        }

        public void anadirCeldas (){
            string[] row = null;
            row = new string[] { alumno.getNombre(), alumno.getApellido(), alumno.getNacimiento().Day.ToString() + "/" + alumno.getNacimiento().Month.ToString() + "/" + alumno.getNacimiento().Year.ToString(), alumno.getGrado().ToString(), alumno.getGrupo(), adeudos.ToString() };
            tablaUser.Rows.Add(row);
        }
 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new MenuUsuarios());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean check = Procesos_Alumno.EliminarAlumno(alumno, adeudos);
            if (check == false) // Uno de lso errores. Actualizar Excel
                MessageBox.Show("Error al intentar eliminar al alumno. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
