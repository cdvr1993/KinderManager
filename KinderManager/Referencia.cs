using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderManager
{
    class Referencia
    {
        private int id_ref;
        private String nombre, apellido, calle, colonia, telefono, celular, parentesco;

        public Referencia(int id, String nombre, String apellido, String calle, String colonia,
            String telefono, String celular, String parentesco)
        {
            init(id, nombre, apellido, calle, colonia, telefono, celular, parentesco);
        }

        public void init(int id, String nombre, String apellido, String calle, String colonia, 
            String telefono, String celular, String parentesco){

            id_ref = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.calle = calle;
            this.colonia = colonia;
            this.telefono = telefono;
            this.celular = celular;
            this.parentesco = parentesco;

        }

        public int getId()
        {
            return id_ref;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getApellido()
        {
            return apellido;
        }

        public String getCalle()
        {
            return calle;
        }

        public String getColonia()
        {
            return colonia;
        }

        public String getTelefono()
        {
            return telefono;
        }

        public String getCelular()
        {
            return celular;
        }

        public String getParentesco()
        {
            return parentesco;
        }
    }
}
