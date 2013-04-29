using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// Al registrar, dejo los índeces de padre y madre como nulos 
namespace KinderManager
{
    public partial class RegistrarUsuario : UserControl  
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
            Sql con = new Sql();
            SqlDataReader r = con.getReader("SELECT * FROM Informacion_pago");
            r.Read();
            String[] pagos = new String[4];
            int i = 0;
            do
            {
                if (i == 0 || i == 1)
                    pagos[i] = "Prekinder. Inscripción: $" + r["Inscripcion"] + " Colegiatura: $" + r["Colegiatura"];

                else
                {
                    pagos[i] = "Kinder. Inscripción: $" + r["Inscripcion"] + " Colegiatura: $" + r["Colegiatura"];
                }
                i++;

            } while (r.Read());

            this.cmbPago.Items.AddRange(new object[] {
            pagos[0],pagos[1], pagos[2], pagos[3]
           });
            r.Close();
            con.closeConnection();
            reestablecer_Controles();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool chequeo;
            chequeo = validaciones();
            if (chequeo == false)
            {
                return;
            }
            String Nombre = txtNombre.Text;
            String Apellido = txtApellido.Text;
            int Mes = cmbMes.SelectedIndex + 1;
            String fecha = cmbDay.SelectedItem.ToString() + "/" + Mes.ToString() + "/" + cmbYear.SelectedItem.ToString();
            DateTime nacimiento = Convert.ToDateTime(fecha);
            String Sangre = (String)cmbSangre.SelectedItem;
            String Calle = txtCalle.Text;
            String Colonia = txtColonia.Text;
            String Tel = txtTel.Text;
            int grado = cmbGrado.SelectedIndex;
            String grupo = (String) cmbGrupo.SelectedItem;
            int mod = cmbPago.SelectedIndex;
            // Se le manda "0" en los id's de padres y madres, pero al registrarlo el valor queda nulo
            Boolean check = Procesos_Alumno.Registro(Nombre, Apellido, nacimiento, Sangre, Calle, Colonia, Tel, 0, 0, grado, grupo, mod, chkActa.Checked, chkCopiaActa.Checked, chkCopiasCartilla.Checked, txtCURP.Text);
            if (check == false) // Uno de lso errores. Actualizar Excel
                MessageBox.Show("Error en el registro. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reestablecer_Controles();
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

        private void txtKeyPressNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                MessageBox.Show("Sólo se admiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
      

        private Boolean validaciones()
        {
            if (this.txtApellido.Text == "" || this.txtNombre.Text == "" || this.txtCalle.Text == "" || this.txtColonia.Text == "" || this.txtTel.Text == "")
            {
                MessageBox.Show("Existe algún campo vacío. Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.cmbGrado.SelectedIndex == 0 && this.cmbGrupo.SelectedIndex != 0)
            {
                {
                    MessageBox.Show("Seleccione NO para el Grupo de Pre-Kinder (Grupo es 0)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (this.cmbGrado.SelectedIndex != 0 && this.cmbGrupo.SelectedIndex == 0)
            {
                {
                    MessageBox.Show("Seleccione un grupo para el grado correspondiente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (this.cmbGrado.SelectedIndex == 0 && !(this.cmbPago.SelectedIndex == 0 || this.cmbPago.SelectedIndex == 1))
            {
                {
                    MessageBox.Show("El método de pago elegido no es aplicable para Pre-Kinder. Seleccione el correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (this.cmbGrado.SelectedIndex !=0 && !(this.cmbPago.SelectedIndex == 2 || this.cmbPago.SelectedIndex == 3))
            {
                {
                    MessageBox.Show("El método de pago elegido no es aplicable para Kinder. Seleccione el correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
         
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add ( new MenuUsuarios () );
        }

        private void reestablecer_Controles()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtColonia.Text = "";
            txtTel.Text = "";
            txtCURP.Text = "";
            chkActa.Checked = false;
            chkCopiaActa.Checked = false;
            chkCopiasCartilla.Checked = false;
            this.cmbDay.SelectedIndex = 0;
            this.cmbGrado.SelectedIndex = 0;
            this.cmbGrupo.SelectedIndex = 0;
            this.cmbMes.SelectedIndex = 0;
            this.cmbPago.SelectedIndex = 0;
            this.cmbSangre.SelectedIndex = 0;
            this.cmbYear.SelectedIndex = 0;
        }
    }
} 