using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ClassCapaEntidadAliado
    {
        private int _idaliado;

        private string _nombre;

        private string _telefono;

        private string _direccion;

        private string _logo;

        public int getidaliado
        {
            get { return _idaliado; }
            set { _idaliado = value; }
        }

        public string getnombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string gettelefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string getdireccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string getaliado
        {
            get { return _logo; }
            set { _logo = value; }

        
        }
    }
}
