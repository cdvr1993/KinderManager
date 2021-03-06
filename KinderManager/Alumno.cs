﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KinderManager
{
    public class Alumno
    {
        private int id_Alumno, grado, idPadre, idMadre, modalidad_pago;
        private String Nombre = null, Apellido = null, Tipo_Sangre = null, Calle = null, Colonia = null, Telefono = null, grupo = null;
        private DateTime Nacimiento;

        public Alumno(int id_Alumno, String Nombre, String Apellido, DateTime Nacimiento, String Tipo_Sangre, String Calle, String Colonia, String Telefono, int idPadre, int idMadre, int Grado, String Grupo, int modalidad_pago)
        {
            init(id_Alumno, Nombre, Apellido, Nacimiento, Tipo_Sangre, Calle, Colonia, Telefono, idPadre, idMadre, Grado, Grupo, modalidad_pago);
        }

        public Alumno(int id_Alumno)
        {
            Sql con = new Sql();
            SqlDataReader r = con.getReader("SELECT * FROM Alumno WHERE Id_Alumno = " + id_Alumno);
            r.Read();
            int id_madre;
            int id_padre;
            if (r.IsDBNull(8))
                id_padre = 0;
            else
                id_padre = (int)r["Id_padre"];

            if (r.IsDBNull(9))
                id_madre = 0;
            else
                id_madre = (int)r["Id_madre"];

            init((int)r["Id_alumno"], (String)r["Nombre"], (String)r["Apellido"], Convert.ToDateTime(r["Nacimiento"]), (String)r["Tipo_Sangre"], (String)r["Calle"], (String)r["Colonia"], (String)r["Telefono"], id_padre, id_madre, (int)r["Grado"], (String)r["Grupo"], (int)r["Modalidad_pago"]);
            r.Close();
        }

        public void init(int id_Alumno, String Nombre, String Apellido, DateTime Nacimiento, String Tipo_Sangre, String Calle, String Colonia, String Telefono, int idPadre, int idMadre, int Grado, String Grupo, int modalidad_pago)
        {
            this.id_Alumno = id_Alumno;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Nacimiento = Nacimiento;
            this.Tipo_Sangre = Tipo_Sangre;
            this.Calle = Calle;
            this.Colonia = Colonia;
            this.Telefono = Telefono;
            this.idPadre = idPadre;
            this.idMadre = idMadre;
            this.grado = Grado;
            this.grupo = Grupo;
            this.modalidad_pago = modalidad_pago;
        }

        public int getId()
        {
            return this.id_Alumno;
        }

        public int getMadre()
        {
            return this.idMadre;
        }

        public int getPadre()
        {
            return this.idPadre;
        }

        public String getNombre()
        {
            return this.Nombre;
        }

        public String getApellido()
        {
            return this.Apellido;
        }

        public String getCalle()
        {
            return this.Calle;
        }

        public String getColonia()
        {
            return this.Colonia;
        }

        public String getTelefono()
        {
            return this.Telefono;
        }

        public DateTime getNacimiento()
        {
            return this.Nacimiento;
        }

        public int getGrado()
        {
            return this.grado;
        }

        public String getGrupo()
        {
            return this.grupo;
        }
        public String getSangre()
        {
            return this.Tipo_Sangre;
        }
        public int getModalidad()
        {
            return this.modalidad_pago;
        }
    }
}