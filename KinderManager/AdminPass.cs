using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KinderManager
{
    public partial class AdminPass : UserControl
    {
       // private bool check;
        static Sql con = null;
        static SqlDataReader r = null;

        public AdminPass()
        {
            InitializeComponent();
        }

        public void checarUsuario()
        {
            con = new Sql();
            r = con.getReader("SELECT * FROM Usuarios WHERE Password = '" + txtPass.Text + "'");
            r.Read();
            if (!r.HasRows)
            {
                MessageBox.Show("Permiso denegado. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.Close();
                txtPass.Text = "";
                return;
            }
            else
            {
                Dispose();
                VentanaPrincipal.Interfaz.Controls.Add(new Menu());
            }    
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            checarUsuario(); 
        }
    }
}
