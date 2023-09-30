using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
    public class Puesto
    {
        public int _Numero;
        public int Numero
            {
                get
                {
                    return _Numero;
                }
                set
                {
                    _Numero = value;
                }
            }

        public bool _EstaComprado;
        public bool EstaComprado
        {
            get
            {
                return _EstaComprado;
            }
            set
            {
                _EstaComprado = value;
            }
        }
        public Comprador _Comprador;
        public Comprador Comprador
        {
            get
            {
                return _Comprador;
            }
            set
            {
                _Comprador = value;
            }
        }
    }
}
