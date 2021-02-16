using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ClassCapaEntidadVehiculoPorDomiciliario
    {

        private int _idvehiculo_por_domiciliari;

        private int _idvehiculo;

        private int _iddomiciliario;

        public int getidvehiculopordomiciliario
        {
            get { return _idvehiculo_por_domiciliari; }
            set { _idvehiculo_por_domiciliari = value; }
        }

        public int getidvehiculo
        {
            get { return _idvehiculo; }
            set { _idvehiculo = value; }
        }

        public int getiddomiciliario
        {
            get { return _iddomiciliario; }
            set { _iddomiciliario = value; }
        }

    }
}
