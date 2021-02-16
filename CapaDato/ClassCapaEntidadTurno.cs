using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ClassCapaEntidadTurno
    {
        private int _idturno;

        private DateTime _fecha;

        private int _iddomiciliario;

        public int getidturno
        {
            get { return _idturno; }
            set { _idturno = value; }
        }

        public DateTime getfecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public int getiddomiciliario
        {
            get { return _iddomiciliario; }
            set { _iddomiciliario = value; }
        }
    }
}
