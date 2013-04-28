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
    public partial class MenuPagos : UserControl
    {
        public MenuPagos () {
            InitializeComponent ();
        }

        private void generarPagosDelAñoToolStripMenuItem_Click ( object sender, EventArgs e ) {
            if (MessageBox.Show ( "¿Seguro que desea generar los pagos del ciclo " + DateTime.Now.Year + "-" + (DateTime.Now.Year + 1) +
                " ?", "Confirmar creación de Pagos", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes) {
                    if (Pagos.generarPagosAnuales ()) {
                        MessageBox.Show ( "Pagos generados con éxito", "Pagos del ciclo agregados", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information );
                    }
            }
        }

        private void btnInscribir_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new BuscarUsuario ( 5 ) );
        }

        private void btnAbono_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new BuscarUsuario ( 6 ) );
        }

        private void regresarToolStripMenuItem_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new Menu () );
        }

        private void salirToolStripMenuItem_Click ( object sender, EventArgs e ) {
            Application.Exit ();
        }
    }
}
