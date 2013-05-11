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
    public partial class MenuAdmin : UserControl
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new Menu());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new RegistroAdmin());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new ActualizarContra());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
