using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BC.Modelos
{
    public class ResponsePago
    {
        public string pan { get; set; }
        public string trakingCode { get; set; }
        public string authorizationCode { get; set; }
        public string referenceCode { get; set; }
        public double amount { get; set; }
        public string responseAuthCode { get; set; }
    }
}
