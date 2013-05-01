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

namespace KinderManager
{
    public partial class EditarUsuario : UserControl
    {
        Alumno alumno = null;
        float adeudos; 
        public EditarUsuario(Alumno alumno, float adeudos)
        {
            InitializeComponent();
            this.alumno = alumno;
            this.adeudos = adeudos;
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

            String[] rowCurp = Procesos_Alumno.obtenerDocumentacion(alumno.getId());
            Boolean[] rowDocu = Procesos_Alumno.obtenerDocuBool(alumno.getId());
            this.chkActa.Checked = rowDocu[0];
            this.chkCopiaActa.Checked = rowDocu[1];
            this.chkCopiasCartilla.Checked = rowDocu[2];
            this.txtCURP.Text = rowCurp[3];

            if (alumno.getGrupo().Equals("No") == true)
                this.cmbGrupo.SelectedIndex = 0;
            if (alumno.getGrupo().Equals("A ") == true)
                this.cmbGrupo.SelectedIndex = 1;
            if (alumno.getGrupo().Equals("B ") == true)
                this.cmbGrupo.SelectedIndex = 2;
            if (alumno.getGrupo().Equals("C ") == true)
                this.cmbGrupo.SelectedIndex = 3;
            this.cmbPago.SelectedIndex = alumno.getModalidad();
            this.txtNombre.Text = alumno.getNombre().ToString();
            this.txtApellido.Text = alumno.getApellido().ToString();
            this.cmbSangre.Text = alumno.getSangre();
            DateTime nuevo = alumno.getNacimiento();
            this.cmbDay.SelectedIndex = nuevo.Day - 1;
            this.cmbMes.SelectedIndex = nuevo.Month - 1;
            this.cmbYear.SelectedIndex = nuevo.Year - 2005;
            this.txtCalle.Text = alumno.getCalle();
            this.txtColonia.Text = alumno.getColonia();
            this.txtTel.Text = alumno.getTelefono();
            this.cmbGrado.SelectedIndex = alumno.getGrado();
            this.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool chequeo;
            chequeo = validaciones();
            if (chequeo == false)
            {
                return;
            }
            int Mes = cmbMes.SelectedIndex + 1;
            String fecha = cmbDay.SelectedItem.ToString() + "/" + Mes.ToString() + "/" + cmbYear.SelectedItem.ToString();
            DateTime nacimiento = Convert.ToDateTime(fecha);
            Alumno nuevo = new Alumno(alumno.getId(), txtNombre.Text, txtApellido.Text, nacimiento, cmbSangre.SelectedItem.ToString(), txtCalle.Text, txtColonia.Text, txtTel.Text, alumno.getPadre(), alumno.getMadre(), Convert.ToInt16(cmbGrado.SelectedItem), cmbGrupo.SelectedItem.ToString().Trim(), cmbPago.SelectedIndex);

            Boolean check = Procesos_Alumno.ModificarAlumno(nuevo, adeudos);
            if (check == false) // Uno de lso errores. Actualizar Excel
                MessageBox.Show("Error al intentar editar los datos del alumno. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Boolean checkDocu = Procesos_Alumno.ModificarDocumentacion(alumno.getId(), this.chkActa.Checked, this.chkCopiaActa.Checked, this.chkCopiasCartilla.Checked, this.txtCURP.Text);
            if (checkDocu == false) // Uno de lso errores. Actualizar Excel
                MessageBox.Show("Error al intentar editar los datos de documentación del alumno. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            // Form1.main.Controls.Add(new wUsuario());
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
            VentanaPrincipal.Interfaz.Controls.Add(new MenuUsuarios());
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
                    MessageBox.Show("Seleccione un grupo para grados distintos a '0' ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (this.cmbGrado.SelectedIndex != 0 && !(this.cmbPago.SelectedIndex == 2 || this.cmbPago.SelectedIndex == 3))
            {
                {
                    MessageBox.Show("El método de pago elegido no es aplicable para Kinder. Seleccione el correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
    }
} 