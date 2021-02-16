using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaDato
{
    public class ClassCapaEntidadActivacion 
    {

        private int _idactivacion;

        private DateTime _fecha;

        private int _idaliado;

        private int _iddomiciliario;

        public int getidactivacion
        {
            get { return _idactivacion; }
            set { _idactivacion = value; }
        }

        public DateTime getfecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public int getaliado
        {
            get { return _idaliado; }
            set { _idaliado = value; }
        }

        public int getiddomiciliario
        {
            get { return _iddomiciliario; }
            set { _iddomiciliario = value; }
        }

    }
}
