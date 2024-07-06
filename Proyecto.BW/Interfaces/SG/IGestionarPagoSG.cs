using Proyecto.BC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BW.Interfaces.SG
{
    public interface IGestionarPagoSG
    {

        Task<bool> direcionaPago(Pago pago);
    }
}
