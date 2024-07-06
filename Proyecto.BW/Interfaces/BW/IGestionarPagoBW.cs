using Proyecto.BC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BW.Interfaces.BW
{
    public interface IGestionarPagoBW
    {
        Task<bool> direcionaPago(Pago pago);

    }
}
