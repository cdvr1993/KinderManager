using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinderManager
{
    class Pruebas
    {
        public Pruebas () {
            //new Pagos ().realizarPago ( "Inscripción", "Ninguno", 2000, 0, 2000, DateTime.Now, true );
            //List<Pagos> tmp = new Pagos ().getAllPagosByDate ( DateTime.Now );
            //List<Pagos> tmp1 = new Pagos ().getAllPagosByRange ( new DateTime ( 2013, 4, 1 ), new DateTime ( 2013, 4, 30 ) );
            //foreach (Pagos pago in tmp) MessageBox.Show ( pago.Concepto );
            //foreach (Pagos pago in tmp1) MessageBox.Show ( pago.Concepto + "\n" + pago.Total );
            //List<Pagos> tmp = new Pagos ().getAllPagosFromStudentInRange ( 0, new DateTime ( 2013, 4, 1 ), new DateTime ( 2013, 4, 30 ) );
            //foreach (Pagos pago in tmp) MessageBox.Show ( pago.Concepto );
            modificacionPago ();
        }

        private void modificacionPago () {
            List<Pagos> tmp1 = new Pagos ().getAllPagosByRange ( new DateTime ( 2013, 4, 1 ), new DateTime ( 2013, 4, 30 ) );
            tmp1[0].Total = 3500;
            tmp1[0].Subtotal = 4000;
            tmp1[0].Descuento = 500;
        }
    }
}
