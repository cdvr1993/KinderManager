using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KinderManager
{
    class Abonos
    {
        private int idAbono;
        private float monto;
        private DateTime fecha;

        public Abonos () { }

        public static Boolean realizarAbonosDeLaLista(float monto,List<int> idPagos){
            try {
                Sql con = new Sql ();
                SqlDataReader r;
                float total = 0, pagado = 0;
                Boolean error = false;
                foreach (int id in idPagos) {
                    r = con.getReader ( String.Format ( "Select total from pagos where id_pago={0:g}", id ) );
                    r.Read ();
                    total = (float) Convert.ToDouble ( r["total"] );
                    r.Close ();
                    r = con.getReader ( String.Format ( "Select monto from abonos inner join pago_abono on abonos.id_abono=pago_abono.id_abono"
                        + " where id_pago={0:g}", id ) );
                    while (r.Read ())  pagado += (float) Convert.ToDouble ( r["monto"] );
                    r.Close ();
                    if ((total - pagado) <= monto) {
                        con.executeQuery ( String.Format ( "Update pagos set liquidado={0:g} where id_pago={1:g}", 1, id ) );
                        if (!realizarAbono ( id, (total - pagado), DateTime.Now )) error = true;
                    } else realizarAbono ( id, monto, DateTime.Now );
                    monto -= (total - pagado);
                    pagado = 0;
                }
                if (error) return false;
            } catch (SqlException) { }
            return true;
        }

        public static List<Pagos> obtenerEstadoDeCuenta ( int idAlumno ) {
            try {
                Sql con = new Sql ();
                List<Pagos> tmp = new List<Pagos> ();
                SqlDataReader r = con.getReader ( String.Format ( "Select pagos.id_pago from pagos inner join [pago-alumno] on " +
                    "pagos.id_pago=[pago-alumno].id_pago where id_alumno={0:g} and fecha<='{1:yyyy-MM-dd}' and liquidado={2:g}", idAlumno,
                    new DateTime(2014,06,15)/*DateTime.Now*/, 0 ) );
                while (r.Read ()) tmp.Add ( Pagos.getInformation ( (int) r[0] ) );
                if (tmp.Count > 0) return tmp;
            } catch (SqlException) { }
            return null;
        }

        public static float obtenerRestanteDelEstadoDeCuenta ( int idPago, float total ) {
            try {
                Sql con = new Sql ();
                SqlDataReader r = con.getReader ( String.Format ( "Select monto from abonos inner join pago_abono on abonos.id_abono=pago_abono.id_abono" +
                    " where id_pago={0:g}", idPago ) );
                float monto = 0;
                while (r.Read ()) monto += (float) Convert.ToDouble ( r["monto"] );
                return total - monto;
            } catch (SqlException) { }
            return total;
        }

        public static Boolean realizarAbono ( int idPago, float monto, DateTime fecha ) {
            try {
                Sql con = new Sql ();
                int id = 0;
                SqlDataReader r = con.getReader ( String.Format ( "Select max(id_abono) from abonos" ) );
                r.Read ();
                if (!r.IsDBNull ( 0 )) id = (int) r[0] + 1;
                r.Close ();
                if (con.executeQuery ( String.Format ( "Insert into abonos values({0:g},{1:f},'{2:yyyy-MM-dd}')", id, monto, fecha ) )) {
                    con.executeQuery ( String.Format ( "Insert into pago_abono values({0:g},{1:g})", idPago, id ) );
                }
                return true;
            } catch (SqlException) { }
            return false;
        }
    }
}
