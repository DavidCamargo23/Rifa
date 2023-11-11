using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
    public class Comprador
    {
        private string _id;
        public string Id { get => _id; set => _id =value; }
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
        private MetodoPago _metodoPago;
        public MetodoPago MetodoPago
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
        private int _numeroBoleta;
        public int  NumeroBoleta
        {
            get
            {
                return _numeroBoleta;
            }
            set
            {
                _numeroBoleta = value;
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
        public Comprador()
        {
            
        }
        public Comprador(string firstName, string lastName,DateTime FechaPago, MetodoPago MetodoPago,int NumeroBoleta)
        {
            _nombre = firstName + lastName;
            _fechaPago = FechaPago;
            _metodoPago = MetodoPago;
            _numeroBoleta = NumeroBoleta;
        }
        public Comprador(JObject json)
        {
            Id = (string)json["Id"];
            Nombre = (string)json["Nombre"];
        }
    }
}
public enum MetodoPago
        {
            none = 0,
            Efectivo = 1,
            Tarjeta = 2,
            PSE = 3,
        }
