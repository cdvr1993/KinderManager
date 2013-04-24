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
            VentanaPrincipal.Interfaz.Controls.Clear ();
            VentanaPrincipal.Interfaz.Controls.Add ( new MenuUsuarios () );
        }
    }
}
