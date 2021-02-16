using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ClassCapaEntidadDomiciliario
    {

        private int _iddomiciliario;

        private string _nombre;

        private string _apellido;

        private string _documento;

        private string _foto;

        private int _idstado;

        private DateTime _fecha_cambio;

        public int getiddomiciliario
        {
            get { return _iddomiciliario; }
            set { _iddomiciliario = value; }
        }

        public string getnombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string getapellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string getdocumento
        {
            get { return _documento; }
            set { _documento = value; }
        }

        public string getfoto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public int getidstado
        {
            get { return _idstado; }
            set { _idstado = value; }
        }

        public DateTime getfechacambio
        {
            get { return _fecha_cambio; }
            set { _fecha_cambio = value; }
        }
    }
}
