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
    
        public bool EstaComprado { get; set; }
        public Comprador Comprador { get; set; }
    }
}
