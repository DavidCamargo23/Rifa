using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
        public class Rifa
        {
        private string _descripcion;
        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
        private DateTime _fechaSorteo;
        public DateTime FechaSorteo
        {
            get
            {
                return _fechaSorteo;
            }
            set
            {
                _fechaSorteo = value;
            }
        }
        public decimal _ValorBoleta;
        public Decimal ValorBoleta
        {
            get
            {
                return _ValorBoleta;
            }
            set
            {
                _ValorBoleta = value;
            }
        }
        public List<Puesto> Puestos { get; set; }
        public Rifa(DateTime fechaSorteo)
        {
            _fechaSorteo = fechaSorteo;
        }
    }
}
