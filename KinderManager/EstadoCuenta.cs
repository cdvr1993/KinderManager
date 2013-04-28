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
    public partial class EstadoCuenta : UserControl
    {
        private float monto = 0;
        public EstadoCuenta (Alumno alumno) {
            InitializeComponent ();
            lblName.Text = "Estado de cuenta de " + alumno.getNombre () + " " + alumno.getApellido ();
            lblName.Location = new Point ( Width / 2 - lblName.Bounds.Width / 2, lblName.Location.Y );
            //  Obtenemos los pagos pendientes del alumno
            List<Pagos> tmp = Abonos.obtenerEstadoDeCuenta ( alumno.getId () );
            if (tmp != null) {
                foreach (Pagos p in tmp) {
                    float monto = Abonos.obtenerRestanteDelEstadoDeCuenta ( p.IdPago, p.Total );
                    tblEstado.Rows.Add ( new String[] {p.IdPago.ToString(),String.Format("{0:yyyy-MM-dd}",p.Date),p.Concepto,p.Subtotal.ToString(),
                p.ConceptoDescuento,p.Descuento.ToString(),monto.ToString(),p.Total.ToString()} );
                }
            }
        }

        private void btnAgregar_Click ( object sender, EventArgs e ) {
            if (tblEstado.SelectedRows.Count <= 0) {
                MessageBox.Show ( "Seleccione algún pago para agregarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            //  Se va a comprobar que se seleccionen los pagos más antiguos.
            List<DataGridViewRow> tmp = new List<DataGridViewRow> ();
            int suma = 1;
            agregarALaLista ( tmp, ref suma );
            Boolean continuidad = validarAgregar ( tmp, suma );
            //  Si se seleccionaron los más antiguos procedemes a agregarlos a la tabla.
            if (continuidad) {
                agregarALosPagos ( tmp );
            }else
                MessageBox.Show ( "Solo pueden agregar los pagos más antiguos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void agregarALaLista ( List<DataGridViewRow> tmp, ref int suma ) {
            Boolean encontrado;
            if (tblEstado.SelectedRows.Count > 1) {
                if (tblEstado.Rows.IndexOf ( tblEstado.SelectedRows[0] ) < tblEstado.Rows.IndexOf ( tblEstado.SelectedRows[1] )) suma = -1;
            }
            if (suma == 1) {
                foreach (DataGridViewRow row in tblPagos.Rows) tmp.Add ( row );
                foreach (DataGridViewRow row in tblEstado.SelectedRows) {
                    encontrado = false;
                    foreach (DataGridViewRow rowList in tmp) {
                        if (Convert.ToInt32 ( row.Cells[0].Value ) == Convert.ToInt32 ( rowList.Cells[0].Value )) {
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado) tmp.Add ( row );
                }
            } else {
                foreach (DataGridViewRow row in tblPagos.Rows) tmp.Add ( row );
                foreach (DataGridViewRow row in tblEstado.SelectedRows) {
                    encontrado = false;
                    foreach (DataGridViewRow rowList in tmp) {
                        if (Convert.ToInt32 ( row.Cells[0].Value ) == Convert.ToInt32 ( rowList.Cells[0].Value )) {
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado) tmp.Add ( row );
                }
            }
        }

        private Boolean validarAgregar ( List<DataGridViewRow> tmp, int suma ) {
            int lastIndex = -1;
            Boolean continuidad = false;
            foreach (DataGridViewRow row in tmp) {
                if (!(lastIndex == -1 || lastIndex == tblEstado.Rows.IndexOf ( row ) + suma)) {
                    continuidad = false;
                    break;
                }
                if (row.Index == 0) continuidad = true;
                lastIndex = tblEstado.Rows.IndexOf ( row );
            }
            return continuidad;
        }

        private void agregarALosPagos ( List<DataGridViewRow> lista ) {
            //  También hay que comprobar que no repita los pagos.
            tblPagos.Rows.Clear ();
            foreach (DataGridViewRow row in lista) {
                tblPagos.Rows.Add ( new String[] {row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString(),row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),row.Cells[4].Value.ToString(),row.Cells[5].Value.ToString(),row.Cells[6].Value.ToString(),
                    row.Cells[7].Value.ToString()} );
            }
            tblPagos.Sort ( tblPagos.Columns[1], ListSortDirection.Ascending );
        }

        private void btnQuitar_Click ( object sender, EventArgs e ) {
            if (tblPagos.SelectedRows.Count <= 0) {
                MessageBox.Show ( "Seleccione algún pago para quitarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            //  Solo se permite quitar los pagos más recientes, para que se salden las deudas más antiguas.
            Boolean continuidad = false;
            int lastIndex = -1;
            int suma = 1;
            // Nos permitirá saber si la selección se hizo de arriba hacia abajo o al revés.
            if (!(tblPagos.Rows.IndexOf ( tblPagos.SelectedRows[0] ) == tblPagos.Rows.Count - 1)) suma = -1;
            foreach (DataGridViewRow row in tblPagos.SelectedRows) {
                if (!(lastIndex == -1 || lastIndex == tblPagos.Rows.IndexOf ( row ) + suma)) {
                    continuidad = false;
                    break;
                }
                if (tblPagos.Rows.IndexOf ( row ) == tblPagos.Rows.Count - 1) continuidad = true;
                lastIndex = tblPagos.Rows.IndexOf ( row );
            }
            if (continuidad) {
                foreach (DataGridViewRow row in tblPagos.SelectedRows) tblPagos.Rows.Remove ( row );
            }
            else
                MessageBox.Show ( "Solo pueden eliminar los últimos pagos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void btnAceptar_Click ( object sender, EventArgs e ) {

            if (txtMonto.Text.Length <= 0) {
                MessageBox.Show ( "Por Favor inserte algo en el monto a pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            float sumaAPagar = 0;
            try {
                sumaAPagar = (float) Convert.ToDouble ( txtMonto.Text );
            } catch (FormatException) {
                MessageBox.Show ( "Únicamente números en el campo de monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            if (tblPagos.Rows.Count == 0) {
                MessageBox.Show ( "No hay pagos que realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            float minimo = (monto - (float) Convert.ToDouble ( tblPagos.Rows[tblPagos.Rows.Count - 1].Cells[6].Value ));
            if (sumaAPagar < minimo) {
                MessageBox.Show ( "No puede pagar menos de " + (minimo + 1) + ", si desea pagar menos elimine el último pago a realizar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                txtMonto.Text = "" + monto;
                return;
            }
            if (tblPagos.Rows.Count <= 0) {
                MessageBox.Show ( "No hay ningún pago a realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            List<int> ids = new List<int> ();
            foreach (DataGridViewRow row in tblPagos.Rows) ids.Add ( Convert.ToInt32 ( row.Cells[0].Value ) );
            if (!Abonos.realizarAbonosDeLaLista ( sumaAPagar, ids ))
                MessageBox.Show ( "Ha habido errores durante el pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            else {
                if (tblPagos.Rows.Count == 0)
                    MessageBox.Show ( "Abono realizado con éxito", "Abono exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information );
                else
                    MessageBox.Show ( "Abonos realizados con éxito", "Abonos almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            btnCancelar_Click ( null, null );
        }

        private void btnCancelar_Click ( object sender, EventArgs e ) {
            Dispose ();
            VentanaPrincipal.Interfaz.Controls.Add ( new MenuPagos () );
        }

        private void tblPagos_RowsAdded ( object sender, DataGridViewRowsAddedEventArgs e ) {
            calcularMonto ();
        }

        private void txtMonto_TextChanged ( object sender, EventArgs e ) {
            if (txtMonto.Text.Length == 0) return;
            if (txtMonto.Text.CompareTo ( "-" ) == 0) {
                MessageBox.Show ( "No puede introducir numeros negativos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                txtMonto.Text = "" + monto;
                return;
            }
            try {
                float sumaAPagar = (float) Convert.ToDouble ( txtMonto.Text );
                if (sumaAPagar > monto) {
                    MessageBox.Show ( "No puede pagar más de lo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    txtMonto.Text = "" + monto;
                    return;
                }
            } catch (FormatException) {
                MessageBox.Show ( "Introduzca solo números en el campo de monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                txtMonto.Text = "" + monto;
            }
        }

        private void tblPagos_RowsRemoved ( object sender, DataGridViewRowsRemovedEventArgs e ) {
            calcularMonto ();
        }

        private void calcularMonto () {
            //  Calculará el nuevo monto cuando se agrega o elimina una fila
            monto = 0;
            foreach (DataGridViewRow row in tblPagos.Rows) monto += (float) Convert.ToDouble ( row.Cells[6].Value );
            txtMonto.Text = "" + monto;
        }
    }
}
