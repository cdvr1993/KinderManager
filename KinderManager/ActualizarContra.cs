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
    public partial class ActualizarContra : UserControl
    {
        public ActualizarContra()
        {
            InitializeComponent();
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
            {
                MessageBox.Show("Sólo se admiten letras, acentos y espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new MenuAdmin());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean check = Procesos_Admin.ModificarAdmin(txtNombre.Text, txtApellido.Text, txtoldPass.Text, txtNewPass.Text);
            if (check == false) // Uno de lso errores. Actualizar Excel
                MessageBox.Show("Error al modificar la contraseña. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reestablecer_Controles();
        }

        private void reestablecer_Controles()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtoldPass.Text = "";
            txtNewPass.Text = "";
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new MenuAdmin());
        }
    }
}
