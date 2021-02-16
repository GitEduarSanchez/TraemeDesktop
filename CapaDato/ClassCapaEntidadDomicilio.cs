using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class ClassCapaEntidadDomicilio
    {
        private int _iddomicilio;

        private DateTime _fecha;

        private int _idcliente;

        private int _iddomiciliario;

        private string _nota;

        private double _tarifa;


        public int getiddomicilio
        {
            get { return _iddomicilio; }
            set { _iddomicilio = value; }
        }

        public DateTime getfecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public int getidcliente
        {
            get { return _idcliente; }
            set { _idcliente = value; }
        }

        public int getiddomiciliario
        {
            get { return _iddomiciliario; }
            set { _iddomiciliario = value; }
        }

        public string getnota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public double gettarifa
        {
            get { return _tarifa; }
            set { _tarifa = value; }
        }
    }
}
