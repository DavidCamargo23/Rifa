using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
    public class Puesto
    {
        private int _numero;
        public int Numero
            {
                get
                {
                    return _numero;
                }
                set
                {
                    _numero = value;
                }
            }

        private bool _estaComprado;
        public bool EstaComprado
        {
            get
            {
                return _estaComprado;
            }
            set
            {
                _estaComprado = value;
            }
        }
        private Comprador _comprador;
        public Comprador Comprador
        {
            get
            {
                return _comprador;
            }
            set
            {
                _comprador = value;
            }
        public Puesto(int Numero, bool Estacomprado, Comprador comprador)
        {
            _numero = Numero;
            _estaComprado = Estacomprado;
            _comprador = Comprador;
        }
    }
    }
}
