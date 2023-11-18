using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
    public class Rifa
    {
        private string _id;
        public string Id { get => _id; set => _id = value; }
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
        private TipoRifa _tipoRifa;
        public TipoRifa TipoRifa
        {
            get
            {
                return _tipoRifa;
            }
            set
            {
                _tipoRifa = value;
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
        private int _qBoletas;
        public int QBoletas
        {
            get
            {
                return _qBoletas;
            }
            set
            {
                _qBoletas = value;
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
        public Comprador Ganador { get; set; }

        public Rifa(DateTime fechaSorteo, string descripcion, TipoRifa tipoRifa)
        {
            _fechaSorteo = fechaSorteo;
            _descripcion = descripcion;
            _tipoRifa = tipoRifa;
        }
        public Rifa(TipoRifa tipoRifa)
        {
            _tipoRifa = tipoRifa;
        }
        public DateTime fechaSorteo = DateTime.UtcNow;
    }
    public enum TipoRifa
    {
        None = 0,
        Pequeña = 1,
        Mediana = 2,
        Grande = 3,
    }
}
