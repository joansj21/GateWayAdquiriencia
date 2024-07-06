using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BC.Modelos
{
    public class Pago
    {
        public string Pan { get; set; }
        public string ExpiryDate { get; set; }
        public string Cvv { get; set; }
        public string Amount { get; set; }
        public string IdentifyCommerce { get; set; }
        public string IdentifyTerminal { get; set; }
    }
}
