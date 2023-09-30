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
        private Decimal _valorBoleta;
        public Decimal ValorBoleta
        {
            get
            {
                return _valorBoleta;
            }
            set
            {
                _valorBoleta = value;
            }
        }
        private List<Puesto> _puestos;
        public List<Puesto> Puestos
        {
            get
            {
                return _puestos;
            }
            set
            {
                _puestos = value;
            }
        }
        public Rifa(DateTime fechaSorteo)
        {
            _fechaSorteo = fechaSorteo;
        }
        public Rifa(string descripcion)
        {
            _descripcion = descripcion;
        }
    }
}
