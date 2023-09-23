using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifa
{
        public class Rifa
        {
            public string Descripcion { get; set; }
            public DateTime FechaSorteo { get; set; }
            public decimal ValorBoleta { get; set; }
            public List Puestos { get; set; }
        }
}
