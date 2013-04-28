using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KinderManager
{
    class Padres
    {
        private String nombre, apellido, ocupacion, empresa, telefono, celular, email;
        private const string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

        public Padres(String nombre, String apellido, String ocupacion, String empresa, 
            String telefono, String celular, String email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ocupacion = ocupacion;
            this.empresa = empresa;
            this.telefono = telefono;
            this.celular = celular;
            this.email = email;

        }

        public bool areFieldsEmpty(){

            if (nombre == "" || apellido == "" || ocupacion == "" || empresa == "" || telefono == "" || celular == ""
                || email == "")
                return true;

            return false;
        }

        public bool isValidEmail()
        {
            if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
            return false;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getApellido()
        {
            return apellido;
        }

        public String getOcupacion()
        {
            return ocupacion;
        }

        public String getEmpresa()
        {
            return empresa;
        }

        public String getTelefono()
        {
            return telefono;
        }

        public String getCelular()
        {
            return celular;
        }

        public String getEmail()
        {
            return email;
        }

    }
}
