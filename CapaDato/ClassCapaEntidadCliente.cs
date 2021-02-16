using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ClassCapaEntidadCliente
    {

        private int _idcliente;

        private string _nombre;

        private string _barrio;

        private string _telefono;

        public int getidcliente
        {
            get { return _idcliente; }
            set { _idcliente = value; }
        }

        public string getnombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string getbarrio
        {
            get { return _barrio; }
            set { _barrio = value; }
        }

        public string gettelefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }


    }
}
