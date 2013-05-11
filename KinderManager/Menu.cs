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
    public partial class Menu : UserControl
    {
        public Menu () {
            InitializeComponent ();
        }

        private void btnUsuarios_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new MenuUsuarios () );
        }

        private void btnPagos_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new MenuPagos () );
        }

        private void btnPadres_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new Ventana_Padres () );
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new MenuAdmin());
        }
    }
}
