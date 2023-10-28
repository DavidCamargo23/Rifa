using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
    public class Comprador
    {
        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        private string _metodoPago;
        public string MetodoPago
        {
            get
            {
                return _metodoPago;
            }
            set
            {
                _metodoPago = value;
            }
        }
        private DateTime _fechaPago;
        public DateTime FechaPago
        {
            get
            {
                return _fechaPago;
            }
            set
            {
                _fechaPago = value;
            }
        }
        public Comprador(string firstName, string lastName,DateTime FechaPago)
        {
            _nombre = firstName + lastName;
            _fechaPago = FechaPago;
        }
    }
}
