using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ClassCapaEntidadStado
    {
        private int _idstado;

        private string _descripcion;

        public int getidstado
        {
            get { return _idstado; }
            set { _idstado = value; }
        }

        public string getdescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

    }
}
