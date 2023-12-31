﻿using Newtonsoft.Json.Linq;
using Rifa;
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
        public Rifa Ganador { get; set; }

        public Rifa(DateTime FechaSorteo, string Descripcion, TipoRifa TipoRifa, int QBoletas)
        {
            _fechaSorteo = FechaSorteo;
            _descripcion = Descripcion;
            _tipoRifa = TipoRifa;
            _qBoletas=QBoletas;
        }
        public Rifa(TipoRifa tipoRifa)
        {
            _tipoRifa = tipoRifa;
        }
        public Rifa(JObject json)
        {
            Id = (string)json["Id"];
            FechaSorteo = (DateTime)json["FechaSorteo"];
            Descripcion = (string)json["Descripcion"];
            TipoRifa = (TipoRifa)(int)json["TipoRifa"];
            QBoletas = (int)json["QBoletas"];
        }
        public Rifa()
        {
        }
    }
    public enum TipoRifa
    {
        None = 0,
        Pequeña = 1,
        Mediana = 2,
        Grande = 3,
    }
}
