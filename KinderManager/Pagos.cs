using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KinderManager
{
    class Pagos
    {
        private int idPago = 0;
        private String concepto = null, conceptoDescuento;
        public float subtotal = 0, descuento = 0, total = 0;
        private DateTime date;
        private Boolean liquidado = false;

        public Pagos() { }

        private static Pagos getInformation(int id)
        {
            try
            {
                Sql con = new Sql();
                SqlDataReader r = con.getReader(String.Format("Select * from pagos where id_pago={0:g}", id));
                r.Read();
                Pagos pago = new Pagos();
                pago.idPago = Convert.ToInt32(r["id_pago"]);
                pago.concepto = "" + r["concepto"];
                pago.conceptoDescuento = "" + r["concepto_descuento"];
                pago.subtotal = (float)Convert.ToDouble(r["subtotal"]);
                pago.descuento = (float)Convert.ToDouble(r["descuento"]);
                pago.total = (float)Convert.ToDouble(r["total"]);
                pago.date = r.GetDateTime(6);
                pago.liquidado = (Convert.ToInt32(r["liquidado"]) == 1) ? true : false;
                return pago;
            }
            catch (SqlException e)
            {
               // Program.log.WriteLine(e.Message);
            }
            //Devolvería nulo solo en caso de que se lanze una excepción entonces no se agregaría.
            return null;
        }

        public static List<Pagos> getAllPagosFromStudent(int id)
        {
            //Buscara todos los Pagos de un estudiante.
            try
            {
                Sql con = new Sql();
                SqlDataReader r = con.getReader(String.Format("Select id_pago from [pago-alumno] where id_alumno={0:g}", id));
                List<Pagos> tmp = new List<Pagos>();
                while (r.Read())
                {
                    Pagos pago = getInformation((int)r["id_pago"]);
                    if (pago != null)
                        tmp.Add(pago);
                }
                con.closeConnection();
                if (tmp.Count > 0)
                    return tmp;
            }
            catch (SqlException e)
            {
                //Program.log.WriteLine(e.Message);
            }
            return null;
        }

        public List<Pagos> getAllPagosFromStudentInRange(int id, DateTime first, DateTime final)
        {
            //Buscara todos los pagos de un estudiante en un rango de fechas.
            try
            {
                Sql con = new Sql();
                //Primero hacemos una consulta en la tabla de cruce.
                SqlDataReader r = con.getReader(String.Format("Select id_pago from [pago-alumno] where id_alumno={0:g}", id));
                Sql con1 = new Sql();
                List<Pagos> tmp = new List<Pagos>();
                while (r.Read())
                {
                    //Posteriormente comprobamos que dicho pago este en el rango de fechas solicitado.
                    SqlDataReader r1 = con1.getReader(String.Format("Select id_pago from pagos where id_pago={0:g} and fecha>='{1:yyyy-MM-dd}' and fecha<='{2:yyyy-MM-dd}'",
                        r["id_pago"], first, final));
                    if (r1.Read())
                    {
                        Pagos pago = getInformation((int)r1["id_pago"]);
                        tmp.Add(pago);
                    }
                }
                if (tmp.Count > 0)
                    return tmp;
            }
            catch (SqlException e)
            {
               // Program.log.WriteLine(e.Message);
            }
            return null;
        }

        public List<Pagos> getAllPagosByDate(DateTime date)
        {
            //Obtiene los pagos de una fecha en especifico y devuelve la lista.
            try
            {
                Sql con = new Sql();
                SqlDataReader r = con.getReader(String.Format("Select id_pago from pagos where fecha='{0:yyyy-MM-dd}'", date));
                List<Pagos> tmp = new List<Pagos>();
                while (r.Read())
                {
                    Pagos pago = getInformation((int)r["id_pago"]);
                    if (pago != null) //Se valida que la función si este devolviendo un pago correcto.
                        tmp.Add(pago);
                }
                con.closeConnection();
                if (tmp.Count > 0)
                    return tmp;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public List<Pagos> getAllPagosByRange(DateTime first, DateTime final)
        {
            //Esta función devuelve los pagos en un rango determinado de fechas, puede usarse para ver los pagos que van del mes en curso.
            try
            {
                Sql con = new Sql();
                SqlDataReader r = con.getReader(String.Format("Select id_pago from pagos where fecha>='{0:yyyy-MM-dd}' and fecha<='{01:yyyy-MM-dd}'", first, final));
                List<Pagos> tmp = new List<Pagos>();
                while (r.Read())
                {
                    Pagos pago = getInformation((int)r["id_pago"]);
                    if (pago != null)
                        tmp.Add(pago);
                }
                con.closeConnection();
                if (tmp.Count > 0)
                    return tmp;
            }
            catch (SqlException e)
            {
                //Program.log.WriteLine(e.Message);
            }
            return null;
        }

        private Boolean actualizarPago(String campo)
        {
            try
            {
                //Actualizara el pago, pero previamente se debe hacer una busqueda para tener el id.
                Sql con = new Sql();
                int liquidadoBit = (liquidado) ? 1 : 0;
                //A continuación se genera el query dependiendo del campo que se desea actualizar.
                String query = "";
                if (campo.CompareTo("concepto") == 0)
                    query = String.Format("Update pagos set {0:g}='{1:g}' where id_pago={2:g}", campo, this.concepto, this.idPago);
                else if (campo.CompareTo("subtotal") == 0)
                    query = String.Format("Update pagos set {0:g}='{1:f}' where id_pago={2:g}", campo, this.subtotal, this.idPago);
                else if (campo.CompareTo("descuento") == 0)
                    query = String.Format("Update pagos set {0:g}='{1:f}' where id_pago={2:g}", campo, this.descuento, this.idPago);
                else if (campo.CompareTo("concepto_descuento") == 0)
                    query = String.Format("Update pagos set {0:g}='{1:g}' where id_pago={2:g}", campo, this.conceptoDescuento, this.idPago);
                else if (campo.CompareTo("total") == 0)
                    query = String.Format("Update pagos set {0:g}='{1:f}' where id_pago={2:g}", campo, this.total, this.idPago);
                else if (campo.CompareTo("date") == 0)
                    query = String.Format("Update pagos set {0:g}='{1:yyyy-MM-dd}' where id_pago={2:g}", campo, this.date, this.idPago);
                else
                    query = String.Format("Update pagos set {0:g}='{1:g}' where id_pago={2:g}", campo, (liquidado ? 1 : 0), this.idPago);
                if (con.executeQuery(query))
                {
                    MessageBox.Show("Pago actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                con.closeConnection();
            }
            catch (SqlException e)
            {
               // Program.log.WriteLine(e.Message);
            }
            return false;
        }

        public Boolean realizarPago(String concepto, String conceptoDescuento, float subtotal, float descuento, float total, DateTime date, Boolean liquidado)
        {
            try
            {
                //Recibe todos los valores del pago para registrarlo en la BD.
                Sql con = new Sql();
                SqlDataReader r = con.getReader("Select max(id_pago) from pagos");
                r.Read();
                int id = 0;
                if (!r.IsDBNull(0))
                    id = (int)r[0];
                r.Close();
                int liquidadoBit = (liquidado) ? 1 : 0;
                if (con.executeQuery(String.Format("Insert into pagos values({0:g},'{1:g}',{2:f},{3:f},'{4:g}',{5:f},'{6:yyyy-MM-dd}',{7:g})"
                    , id, concepto, subtotal, descuento, conceptoDescuento, total, date, liquidadoBit)))
                {
                    MessageBox.Show("Pago realizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.closeConnection();
            }
            catch (SqlException e)
            {
                //Program.log.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public Boolean generarPagosAnuales () {
            Sql con = new Sql (), con1 = new Sql();
            try {
                SqlDataReader r = con.getReader ( String.Format ( "Select * from alumno inner join informacion_pago on " +
                    "modalidad_pago=id_modalidad" ) ), r1;
                while (r.Read ()) {
                    int id = 0, lim = 0;
                    //  Se obtiene cuantos pagos se harán al año.
                    if ((int) r["id_modalidad"] == 0 || (int) r["id_modalidad"] == 2) lim = 11;
                    else lim = 10;
                    //  Va a generar cada uno de los pagos que se deberán a hacer en el año.
                    for (int i = 0, mes = 8 , year = DateTime.Now.Year; i < lim ; i++, mes++) {
                        r1 = con1.getReader ( String.Format ( "Select max(id_pago) from pagos" ) );
                        r1.Read ();
                        if (!r1.IsDBNull ( 0 ))
                            id = (int) r1[0];
                        r1.Close ();
                        DateTime fecha = new DateTime ( year, mes, 1 );
                        con.executeQuery ( String.Format ( "Insert into pagos values({0:g},{1:g},{2:f},{3:f},{4:g},{5:f},{6:yyyy-MM-dd}," +
                            "{7:g}", id, "Colegiatura", r["colegiatura"], 0, "Ninguno", r["Colegiatura"], fecha, 0 ) );
                        if (mes == 12) {
                            mes = 0;
                            year++;
                        }
                    }
                }
            } catch (SqlException) {
            }
            return false;
        }

        //A continuación están todo los GET'S de los miembros de la clase.
        public int IdPago
        {
            //No permitiremos modificar ID'S por eso solo tiene GET.
            get
            {
                return this.idPago;
            }
        }

        public String Concepto
        {
            get
            {
                return this.concepto;
            }
            set
            {
                String tmp = this.concepto;
                this.concepto = value;
                if (!actualizarPago("concepto"))
                {
                    MessageBox.Show("Imposible actualizar el concepto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.concepto = tmp;
                }
            }
        }

        public String ConceptoDescuento
        {
            get
            {
                return this.conceptoDescuento;
            }
            set
            {
                String tmp = this.conceptoDescuento;
                this.conceptoDescuento = value;
                if (!actualizarPago("concepto_descuento"))
                {
                    MessageBox.Show("Imposible actualizar el Concepto del descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.conceptoDescuento = tmp;
                }
            }
        }

        public float Subtotal
        {
            get
            {
                return this.subtotal;
            }
            set
            {
                float tmp = this.subtotal;
                this.subtotal = value;
                if (!actualizarPago("subtotal"))
                {
                    MessageBox.Show("Imposible actualizar el subtotal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.subtotal = tmp;
                }
            }
        }

        public float Descuento
        {
            get
            {
                return this.descuento;
            }
            set
            {
                float tmp = this.descuento;
                this.descuento = value;
                if (!actualizarPago("descuento"))
                {
                    MessageBox.Show("Imposible actualizar el descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.descuento = tmp;
                }
            }
        }

        public float Total
        {
            get
            {
                return this.total;
            }
            set
            {
                float tmp = this.total;
                this.total = value;
                if (!actualizarPago("total"))
                {
                    MessageBox.Show("Imposible actualizar el total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.total = tmp;
                }
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                DateTime tmp = this.date;
                this.date = value;
                if (!actualizarPago("date"))
                {
                    MessageBox.Show("Imposible actualizar la fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.date = tmp;
                }
            }
        }

        public Boolean Liquidado
        {
            get
            {
                return this.liquidado;
            }
            set
            {
                Boolean tmp = this.liquidado;
                this.liquidado = value;
                if (!actualizarPago("liquidado"))
                {
                    MessageBox.Show("Imposible actualizar la liquidez del pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.liquidado = tmp;
                }
            }
        }
    }
}
