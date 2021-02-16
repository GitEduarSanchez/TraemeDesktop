using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ClassCapaEntidadVehiculo
    {
        private int _idvehiculo;

        private string _placa;

        public int getidvehiculo
        {
            get { return _idvehiculo; }
            set { _idvehiculo = value; }
        }

        public string getplaca
        {
            get { return _placa; }
            set { _placa = value; }
        }
    }
}
