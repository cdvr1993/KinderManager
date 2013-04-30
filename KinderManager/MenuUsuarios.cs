using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinderManager
{
    public partial class MenuUsuarios : UserControl
    {
        public MenuUsuarios () {
            InitializeComponent ();
        }

        private void btnRegistrar_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new RegistrarUsuario () );
        }

        private void btnBuscar_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new BuscarUsuario ( 2 ) );
        }

        private void btnEditar_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new BuscarUsuario ( 1 ) );
        }

        private void btnAsignar_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new BuscarUsuario ( 4 ) );
        }

        private void btnEliminar_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new BuscarUsuario ( 3 ) );
        }

        private void btnReporte_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new ReporteAlumnos () );
        }

        private void salirToolStripMenuItem_Click ( object sender, EventArgs e ) {
            Application.Exit ();
        }

        private void regresarToolStripMenuItem_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new Menu () );
        }

        private void btnReferencias_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new Referencias());
        }
    }
}
