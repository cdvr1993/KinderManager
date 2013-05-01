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
    public partial class MostrarUsuario : UserControl 
    {
        Alumno alumno;
        public MostrarUsuario(Alumno alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
            anadirCeldasUser();
            anadirCeldasDir();
            anadirCeldasAdmin();
            anadirCeldasPadre();
            anadirCeldasMadre();
            this.Show(); 
        }

        public void anadirCeldasUser()
        {
            string[] row = null;
            row = new string[] { alumno.getNombre(), alumno.getApellido(), alumno.getNacimiento().Day.ToString() + "/" + alumno.getNacimiento().Month.ToString() + "/" + alumno.getNacimiento().Year.ToString(), alumno.getSangre(), alumno.getGrado().ToString(), alumno.getGrupo()};
            tablaUser.Rows.Add(row);
        }

        public void anadirCeldasDir()
        {
            string[] row = null;
            row = new string[] { alumno.getCalle(), alumno.getColonia(), alumno.getTelefono()};
            tablaDir.Rows.Add(row);
        }

        public void anadirCeldasAdmin()
        {
            string[] row = null;
            String mod = Procesos_Alumno.ObtenerModalidadPago(alumno.getModalidad());
            string[] row1 = Procesos_Alumno.obtenerDocumentacion(alumno.getId());
            row = new string[] {mod, "$" + Procesos_Alumno.ObtenerAdeudos(alumno.getId()).ToString(), row1[0], row1[1], row1[2], row1[3]};
            tablaAdmin.Rows.Add(row);
        }

        public void anadirCeldasPadre()
        {
            String r = "No hay dato";
            string[] row = null;
            if (Procesos_Alumno.obtenerPadre(alumno.getPadre()) == null)
            {
                row = new string[] { r, r, r };
                tablaPadre.Rows.Add(row);
            }
            else
                tablaPadre.Rows.Add(Procesos_Alumno.obtenerPadre(alumno.getPadre()));

        }

        public void anadirCeldasMadre()
        {
           String r = "No hay dato";
           string[] row = null;
           if (Procesos_Alumno.obtenerMadre(alumno.getPadre()) == null)
           {
               row = new string[] { r, r, r };
               tablaMadre.Rows.Add(row);
           }
           else
              tablaMadre.Rows.Add(Procesos_Alumno.obtenerMadre(alumno.getMadre()));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new MenuUsuarios());
        }
       
    }
}
